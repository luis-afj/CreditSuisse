using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    public interface ICategory
    {
        //string ToCategorize(Trade trade);
        Risk GetCategory(Trade trade);
        ICategory Next { get; set; }
    }
}
