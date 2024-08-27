using Microsoft.AspNetCore.Mvc;

namespace Assignment_01_MVC.Controllers
{
    public class HomeController : Controller
    {
        // public ActionResult Index()
        // {
        //     // ContentResult contentResult = new ContentResult();
        //     // contentResult.Content = "Hello from Content Result";
        //     // return contentResult;
        //     return Content("Hello from Content Result");
        // }
        // public ActionResult AboutUs()
        // {
        //     return Redirect("https://www.google.com");
        // }
        //
        // public ActionResult ContactUs()
        // {
        //     return RedirectToAction("Index");
        // }
        //
        // public string Error()
        // {
        //     return "Hello from Error";
        // }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
