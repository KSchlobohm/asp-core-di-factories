using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;

namespace MultipleRegistrations.MarketingPromos
{
    public class RoutBasedPromoFactory : IMarketingPromoProvider
    {
        private readonly IEnumerable<IMarketingPromo> _promotions;
        private readonly DefaultMarketingPromotion _defaultPromo;
        private readonly IActionContextAccessor _contextAccessor;

        public RoutBasedPromoFactory(IActionContextAccessor contextAccessor, IEnumerable<IMarketingPromo> promotions, DefaultMarketingPromotion defaultPromo)
        {
            _contextAccessor = contextAccessor;
            _promotions = promotions;
            _defaultPromo = defaultPromo;
        }

        public IMarketingPromo GetMarketingPromo()
        {
            var routeBasedPromotionName = GetNameOfMarketingPromotionClass();
            foreach (var promo in _promotions)
                if (promo.GetType().Name == routeBasedPromotionName)
                    return promo;

            return _defaultPromo;
        }

        private string GetNameOfMarketingPromotionClass()
        {
            var theControllerName = _contextAccessor.ActionContext.RouteData.Values["controller"] as string;
            var theActionName = _contextAccessor.ActionContext.RouteData.Values["action"] as string;

            return $"{theControllerName}Controller{theActionName}ActionPromo";
        }
    }
}
