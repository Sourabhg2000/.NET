using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvanceMath math=new AdvanceMath();
            Console.WriteLine(math.Addition(1000, 1000));
            math.Notice();
            //Sales sales=new DubaiSales();
            //Console.WriteLine($"India Sales Net Profit without GST is INR {sales.SalesNetProfit(12000,13000,150000)}");
            //Console.WriteLine($"India Sales Net Profit with 18% GST is INR {sales.SalesNetProfit(12000, 13000, 150000,sales.GetTaxPercent("FOOD"))}");
            //Console.WriteLine($"Dubai Sales Net Profit with 18% GST is INR {sales.SalesNetProfit(12000, 13000, 150000, sales.GetTaxPercent("FOOD"), 10000)}");
        }
    }
}
