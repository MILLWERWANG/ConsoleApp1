using System;
//NameSpace範例  
namespace TEST
{
    public class CAR
    {
        public void run(string AA)
        {
            Console.WriteLine(AA + "開車囉");

        }
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TEST.CAR C = new TEST.CAR();
            C.run("miller");

        }
    }
}
