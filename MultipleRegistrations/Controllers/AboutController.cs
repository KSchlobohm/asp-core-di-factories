using Microsoft.AspNetCore.Mvc;
using MultipleRegistrations.MarketingPromos;

namespace MultipleRegistrations.Controllers
{
    public class AboutController : Controller
    {
        private readonly IMarketingPromoProvider _marketingPromoProvider;

        public AboutController(IMarketingPromoProvider marketingPromoProvider)
        {
            _marketingPromoProvider = marketingPromoProvider;
        }

        public IActionResult Index()
        {
            var promo = _marketingPromoProvider.GetMarketingPromo();
            ViewBag.MarketingPromo = promo.GetMessage();
            return View();
        }
    }
}
