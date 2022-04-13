using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    public class ExpiredCategory : ICategory
    {
        public ICategory Next { get; set; }
        public DateTime ReferenceDate { get; set; }
        public ExpiredCategory(DateTime referenceDate)
        {
            ReferenceDate = referenceDate;
        }
        public Risk GetCategory(Trade trade)
        {
            if (trade.NextPaymentDate < ReferenceDate.AddDays(30))
                return Risk.EXPIRED;

            return Next.GetCategory(trade);
        }
    }
}
