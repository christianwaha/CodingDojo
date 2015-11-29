using Logic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NumberInWords(int value = 1337)
        {
            return View(value);
        }

        public PartialViewResult GetNumberInWords(int value)
        {
            string result = string.Empty;

            if (ViewData.ModelState.IsValid)
            {
                NumberConverter converter = new NumberConverter();
                result = converter.Convert(value);
            }
            else
            {
                result = "Error";
            }

            return PartialView((object)result);
        }
    }
}