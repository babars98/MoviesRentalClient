using MoviesRentalClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesRentalClient.Controllers
{
    public class MovieController : Controller
    {

        private readonly MovieService.MoviesServiceClient _movieService;

        public MovieController()
        {
            _movieService = new MovieService.MoviesServiceClient();
        }
        // GET: Movie
        public ActionResult Home()
        {
            var moviesList = new List<Movies>();
            var movies = _movieService.GetAllMovies();
            if (movies != null)
                moviesList = JsonConvert.DeserializeObject<List<Movies>>(movies);

            return View(moviesList);
        }

        public ActionResult Detail(int movieId)
        {
            var movie = _movieService.GetMovie(movieId);
            var movieObj = JsonConvert.DeserializeObject<Movies>(movie);
            var user = GetUserInfofromSession();
            ViewBag.IsMovieAlreadyRented = _movieService.IsMovieAlreadyRented(user.UserId, movieId);
            return View(movieObj);
        }

        public ActionResult RentedMovies()
        {
            var user = GetUserInfofromSession();
            var moviesList = new List<Movies>();

            var movies = _movieService.RentedMovies(user.UserId);
            if (movies != null)
                moviesList = JsonConvert.DeserializeObject<List<Movies>>(movies);
            return View(moviesList);
        }

        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(Movies model)
        {
            HttpPostedFileBase file = Request.Files["imagefile"];
            string filename = string.Concat(DateTime.Now.ToString("Mddyyyyhhmmsstt"), file.FileName);
            string path = System.IO.Path.Combine(Server.MapPath("~/images/"), filename);
            file.SaveAs(path);
            var pathtoSave = @"\images\" + filename;

            var result = _movieService.AddMovie(model.MovieName, pathtoSave, model.Description);

            if (result)
                return RedirectToAction("Home");

            ModelState.AddModelError("", "Problem adding Moive.");
            return View(model);
        }

        [HttpPost]
        public JsonResult DeleteMovie(int movieId)
        {
            var result = _movieService.DeleteMove(movieId);
            return Json(result, JsonRequestBehavior.AllowGet);
        } 

        [HttpPost]
        public JsonResult RentMovie(int movieId)
        {
            var user = GetUserInfofromSession();
            var result = _movieService.RentMovie(movieId, user.UserId);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private RegisterViewModel GetUserInfofromSession()
        {
            return (RegisterViewModel)Session["UserInfo"];
        }
    }
}