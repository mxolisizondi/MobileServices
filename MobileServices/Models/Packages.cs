using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobileServices.Models
{
    //This is the model I used to see which package or plan did the user select if A is selected it will store true
    public class Packages
    {
        [Display(Name = "Chooose Package A")]
        public bool packageA { get; set; }

        [Display(Name = "Chooose Package B")]
        public bool packageB { get; set; }

        [Display(Name = "Chooose Package C")]
        public bool packageC { get; set; }
    }
}