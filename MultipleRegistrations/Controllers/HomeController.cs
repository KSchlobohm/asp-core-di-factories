using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultipleRegistrations.MarketingPromos;
using MultipleRegistrations.Models;

namespace MultipleRegistrations.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMarketingPromoProvider _marketingPromoProvider;

        public HomeController(IMarketingPromoProvider marketingPromoProvider)
        {
            _marketingPromoProvider = marketingPromoProvider;
        }

        public IActionResult Index()
        {
            var promo = _marketingPromoProvider.GetMarketingPromo();
            ViewBag.MarketingPromo = promo.GetMessage();
            return View();
        }

        public IActionResult Privacy()
        {
            var promo = _marketingPromoProvider.GetMarketingPromo();
            ViewBag.MarketingPromo = promo.GetMessage();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
