using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuelTankDataAcsess.Data;
using FuelTankDataAcsess.Repositories;

namespace FuelTankWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CompanyDataRespository Company = new CompanyDataRespository(new DataContext());
            AdressRepository Adres = new AdressRepository(new DataContext());

            return View();
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