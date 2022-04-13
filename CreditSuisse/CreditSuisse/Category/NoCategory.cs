using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    public class NoCategory : ICategory
    {
        public ICategory Next { get; set; }

        public Risk GetCategory(Trade trade)
        {
            return Risk.NORISK;
        }
    }
}
