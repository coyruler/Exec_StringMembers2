using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比對使用者輸入值是否為 "Allen" 不拘大小寫
            Console.WriteLine("請輸入名稱");
            string value;
            value = Console.ReadLine();

            value = value.ToLower();
            string value2 = "Allen";
            value2 = value2.ToLower();

            if(value == value2)
            {
                Console.WriteLine("輸入正確");
            }
            else
            {
                Console.WriteLine("輸入錯誤");
            }

        }
    }
}
