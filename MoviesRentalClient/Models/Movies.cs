using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesRentalClient.Models
{
    public class Movies : CommonBase
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie name required")]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public DateTime DateRented { get; set; }
    }
}