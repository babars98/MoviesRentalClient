using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MoviesRentalClient.Models;
using Newtonsoft.Json;

namespace MoviesRentalClient.Controllers
{
    public class AccountController : Controller
    {

        private readonly AccountService.AccountServiceClient _accountService;

        public AccountController()
        {
            _accountService = new AccountService.AccountServiceClient();
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = SignInUser(model.Email, model.Password);
            var b = Session["UserInfo"];
            if (result)
                return RedirectToLocal(returnUrl);

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
        }

        private bool SignInUser(string email, string password)
        {
            var result = _accountService.Login(email, password);
            if (result != null)
            {
                var user = JsonConvert.DeserializeObject<RegisterViewModel>(result);
                Session["UserInfo"] = user;
                return true;
            }

            return false;
        }


        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = _accountService.Register(model.Name, model.Email, model.Password);
                if (result)
                {
                    SignInUser(model.Email, model.Password);

                    return RedirectToAction("Home", "Movie");
                }
                AddErrors(new IdentityResult("Error while registering user."));
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Remove("UserInfo");
            Session.Abandon();
            return RedirectToAction("Home", "Movie");
        }

        public bool IsUserLoggedIn()
        {
            var user = GetLoggedInUser();
            return user != null;
        }

        public RegisterViewModel GetLoggedInUser()
        {
            return Session != null ? (RegisterViewModel)Session["UserInfo"] : null;
        }

        #region Helpers
        // Used for XSRF protection when adding external logins


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Home", "Movie");
        }
        #endregion
    }
}