using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // call the controller's View method
        // uses view template to generate HTML response
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // view data dictionary object
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            // pass the data to the view
            return View();
        }
    }
}
