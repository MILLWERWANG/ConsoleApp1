using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//接收到命令列參數 、StringBuilder範例
namespace ConSolStringBulder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sbd = new StringBuilder();
            sbd.AppendLine("接收到命令列參數");
            foreach (string a in args)
            {
                sbd.AppendFormat("{0}", a);

            }
             Console.WriteLine(sbd);
            Console.ReadLine();//只是為了停住畫面,此行無意義
        }
    }
}
