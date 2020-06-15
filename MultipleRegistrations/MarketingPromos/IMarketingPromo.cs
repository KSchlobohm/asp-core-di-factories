using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleRegistrations.MarketingPromos
{
    public interface IMarketingPromo
    {
        string GetMessage();
    }
    
    public class DefaultMarketingPromotion : IMarketingPromo
    {
        public string GetMessage()
        {
            return "No promotions available";
        }
    }

    public class HomeControllerIndexActionPromo : IMarketingPromo
    {
        public string GetMessage()
        {
            return "Buy one now and get one free!";
        }
    }

    public class AboutControllerIndexActionPromo : IMarketingPromo
    {
        public string GetMessage()
        {
            return "Use code HELLOWORLD for 50% off today!";
        }
    }
}
