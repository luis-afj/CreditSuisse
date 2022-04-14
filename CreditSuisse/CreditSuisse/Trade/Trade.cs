using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    public class Trade : ITrade
    {
        public double Value { get; private set; }
        public string ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }
        

        public Trade()
        {
        }

        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            this.Value = value;
            this.ClientSector = clientSector;
            this.NextPaymentDate = nextPaymentDate;
        }
    }
}
