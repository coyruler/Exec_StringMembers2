using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //隱藏手機的資訊呈現 0935****46
            Console.WriteLine("請輸入手機號碼");
            string phoneNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 10)
            {
                Console.WriteLine("phoneNumber 格式不對");
                return;
            }

            string phoneNumber2 = phoneNumber.Substring(0, 4) + new string('*', 4) + phoneNumber.Substring(8, 2);
            Console.WriteLine(phoneNumber2);


        }
    }
}
