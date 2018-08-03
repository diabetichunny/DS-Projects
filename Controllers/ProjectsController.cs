using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MyProjects.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StockTicker()
        {
            return View();
        }

        public IActionResult Sentiment_Analizer()
        {
            return View();
        }

        public IActionResult Cat_Dog()
        {
            return View();
        }
    }
}