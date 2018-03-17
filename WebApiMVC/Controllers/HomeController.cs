using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApiMVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var httpCLient = new HttpClient();
            Models.RandomLI rmVar = new Models.RandomLI();
            rmVar.from = 1;
            rmVar.to = 20;
            Random rnd = new Random();
            string url = string.Format(@"http://localhost:61813/api/LoremIpsum/{0}", rnd.Next(rmVar.from, rmVar.to));
            var json = await httpCLient.GetStringAsync(url);
            Models.LIContent liResult = new Models.LIContent();
            liResult.Description = @json.Replace('"', ' ');
            liResult.Description = liResult.Description.Trim();
            return View(liResult);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}