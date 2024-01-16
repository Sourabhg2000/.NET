using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    //SalesNetProfit = Incoming Money - Outgoing Money
    //Outgoing Money - COGS, Expense, GST
    //Incoming Money - actualSales
    internal class Sales
    {
        public virtual int GetTaxPercent(string field)
        {
            if (field=="IT")
            {
                return 18;
            }
            else
            {
                return 12;
            }
        }
        public double SalesNetProfit(double cogs, double expense, double actualSales)
        {
            return actualSales - (cogs + expense);
        }
        public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount);
        }
    }
}
