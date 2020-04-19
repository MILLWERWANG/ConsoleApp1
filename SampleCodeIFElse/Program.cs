using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IF-ESLE範例程式
namespace SampleCodeIFElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入資料");

            string Strinput = Console.ReadLine();
            if (uint.TryParse(Strinput,out uint number) && number>0)
                //tryParse轉換後則會回傳給number,且tryPares傳回True,無法轉換會傳false
            {
                if ((number % 2) == 0)
                {
                    Console.WriteLine($"你輸入{number}的是偶數");
                }
                else {
                    Console.WriteLine($"你輸入{number}的是奇數");
                }
            }
            else
            {
                Console.WriteLine("輸入資料型別有錯誤");
            }
            Console.ReadLine();
        }
    }
}
