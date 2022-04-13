using System;
using System.Collections.Generic;
using System.Globalization;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>
            {
                "12/11/2020",
                "4",
                "2000000 Private 12/29/2025",
                "400000 Public 07/01/2020",
                "5000000 Public 01/02/2024",
                "3000000 Public 10/26/2023"
            };

            TradeProcessor tradeProcessor = new TradeProcessor();

            var Risks = tradeProcessor.ToProcessTradeFile(input);

            Risks.ForEach(f => Console.WriteLine(f));

            Console.ReadKey();
        }        
    }
}
