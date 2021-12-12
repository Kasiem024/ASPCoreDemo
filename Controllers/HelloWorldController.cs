using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASPCoreDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;

            return View();

            // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}