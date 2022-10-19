using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
            string date1 = "1100225";
            string date2 = date1.Substring(0, 3);

            int year = Convert.ToInt32(date2);
            year = year + 1911;

            string month= date1.Substring(3,2);
            string day = date1.Substring(5,2);

            string date3=$"{year}/{month}/{day}";
            var date4 = Convert.ToDateTime(date3);

            Console.WriteLine(date4.ToString("yyyy/MM/dd"));

        }
    }
}
