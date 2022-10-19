using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比對使用者輸入值是否為 "Allen", 區分大小寫
            Console.WriteLine("請輸入名字");
            string name1 = Console.ReadLine();
            string name2 = "Allen";
            bool result = Equals(name1, name2);
            if(result == true)
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
