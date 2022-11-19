using Core.Model;
using Data.EntityFramework;
using ExzampleProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.Concrete;
using System.Diagnostics;

namespace ExzampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        OgrenciManager cm = new OgrenciManager(new EfOgrenciDal());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var model = cm.TGetList();


            return View(model);
        }
        public JsonResult AddOgrenci(Ogrenci ogrenci)
        {

            cm.TAdd(ogrenci);


            var sehend = JsonConvert.SerializeObject(ogrenci);

            return Json(sehend);
        }
        public PartialViewResult Create()
        {

          
           

            return PartialView();
        }


        public IActionResult Privacy()
        {
            var model = cm.TGetList();


            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}