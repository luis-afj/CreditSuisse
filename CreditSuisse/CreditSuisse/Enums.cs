using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse
{
    public class Enums
    {  
        public enum Risk 
        { 
            EXPIRED, 
            HIGHRISK, 
            MEDIUMRISK, 
            NORISK
        }

        public enum Sector 
        { 
            PUBLIC, 
            PRIVATE 
        }
    }
}
