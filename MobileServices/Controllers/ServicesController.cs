using MobileServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileServices.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        //Here I receive the model from the user validate if the user select only one if not show the user the errors
        [HttpPost]
        public ActionResult Index(Packages model)
        {
            if (model.packageA == false && model.packageB == false && model.packageC == false)
            {
                ModelState.AddModelError("atleastOne","**Select at least one package**");
                return View(model);
            }
            else if(model.packageA == true && model.packageB == true)
            {
                ModelState.AddModelError("notTwo", "**Error : You cant select two or more packages select only one at a time**");
                return View(model);
            }
            else if (model.packageA == true && model.packageC == true)
            {
                ModelState.AddModelError("notTwo", "** Error : You cant select two or more packages select only one at a time**");
                return View(model);
            }
            else if (model.packageB == true && model.packageC == true)
            {
                ModelState.AddModelError("notTwo", "** Error : You cant select two packages select only one at a time**");
                return View(model);
            }
            else if (model.packageA == true && model.packageB == true && model.packageC == true)
            {
                ModelState.AddModelError("notAll", "**Error :You cant select all packages select only one**");
                return View(model);
            }

            //I am redirecting the user to Thank you page and storing the choice in the ViewBag
            if (model.packageA)
            {
                ViewBag.Choice = "A";
                return View("ThankYou");
            }
                
            else if (model.packageB)
            {
                ViewBag.Choice = "B";
                return View("ThankYou");
            }
            else
            {
                ViewBag.Choice = "C";
                return View("ThankYou");
            }
        }
    }
}