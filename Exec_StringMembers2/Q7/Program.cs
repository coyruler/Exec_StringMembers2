using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算兩數之和,並只呈現小數二位數
            
           
            Console.WriteLine("請輸入第一值");
            string value1 = Console.ReadLine();
            double d1 = Convert.ToDouble(value1);

            Console.WriteLine("請輸入第一值");
            string value2 = Console.ReadLine();
            double d2 = Convert.ToDouble(value2);

            double d3 = d1 + d2;
            d3 = Math.Round(d3, 2,MidpointRounding.AwayFromZero);

            string result = d3.ToString("#.##");
            Console.WriteLine(result);
        }
    }
}
