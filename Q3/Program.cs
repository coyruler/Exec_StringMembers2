using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
            string name = "aLLeN kUO";
            string name2 = name.ToLower();
            string name3 = name2.Substring(0, 1);
            name3=name3.ToUpper();
            string name4 = name2.Substring(1, 5);
            string name5 = name2.Substring(6, 1);
            name5 = name5.ToUpper();
            string name6 = name2.Substring(7, 2);
            Console.WriteLine(name3+ name4+ name5+ name6);
        }
    }
}
