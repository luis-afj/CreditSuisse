﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreditSuisse.Enums;

namespace CreditSuisse
{
    class TradeProcessor
    {
        public Risk ToProcessTrade(Trade trade, DateTime referenceDate)
        {
            ICategory cat1 = new ExpiredCategory(referenceDate);
            ICategory cat2 = new HighRiskCategory();
            ICategory cat3 = new MediumRiskCategory();
            ICategory cat4 = new NoCategory();

            cat1.Next = cat2;
            cat2.Next = cat3;
            cat3.Next = cat4;

            return cat1.GetCategory(trade);
        }

        public List<Risk> ToProcessTradeFile(List<string> inputFile)
        {
            List<Risk> FileRisks = new List<Risk>();
            DateTime referenceDate = Convert.ToDateTime(inputFile[0].Trim());            
            int numberTrades = Convert.ToInt32(inputFile[1].Trim());
            Trade trade = new Trade();
            string[] colsTrade;

            for (int i = 2; i < numberTrades + 2; i++)
            {
                colsTrade = inputFile[i].Split(' ');

                trade.Value = Convert.ToDouble(colsTrade[0].Trim());
                trade.ClientSector = colsTrade[1].Trim();

                var cultureInfo = new CultureInfo("en-US");
                trade.NextPaymentDate = DateTime.Parse(colsTrade[2].Trim(), cultureInfo);

                FileRisks.Add(ToProcessTrade(trade, referenceDate));
            }

            return FileRisks;
        }
    }
}
