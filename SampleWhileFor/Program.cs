using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//While範例：小於20可被３整除的數字
namespace SampleWhileFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            StringBuilder aa = new StringBuilder();
            while(i <21)
                {
                
                if ((i%3)==0)
                {
                    aa.Append(i);
                    aa.Append("　");
                    i++;
                }
                else
                {
                    i++;
                    continue;//跳過當次迴圈未完成的程式,進下個迴圈
                }
               
            }
            Console.WriteLine($"可以被3整除的數字{aa}");

            Console.ReadLine();
        }
    }
}
