using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    public class MediumRiskCategory : ICategory
    {
        public ICategory Next { get; set; }

        public Risk GetCategory(Trade trade)
        {
            if (trade.Value > 1000000 && Sector.PUBLIC.ToString().Equals(trade.ClientSector?.ToUpper()))
                return Risk.MEDIUMRISK;

            return Next.GetCategory(trade);
        }
    }
}
