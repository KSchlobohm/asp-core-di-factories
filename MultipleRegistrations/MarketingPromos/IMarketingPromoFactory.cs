using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleRegistrations.MarketingPromos
{
    public interface IMarketingPromoProvider
    {
        IMarketingPromo GetMarketingPromo();
    }
}
