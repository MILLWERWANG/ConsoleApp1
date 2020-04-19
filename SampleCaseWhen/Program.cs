using System;
using System.Collections;
using System.Collections.Generic;
//CaseWhen述敍類型比對
namespace SampleCaseWhen
{
    class Program
    {
        static void DisplayInfo(object instance)
        {
            switch (instance)
            {
                case null:
                    Console.WriteLine("物件為null");
                    break;
                case Array arr when arr.Length == 0: //比對型態為Array且為空陣列
                    Console.WriteLine("這是個空陣列");
                    break;
                case Array arr: //比對型態為Array
                    Console.WriteLine($"陣列包含{arr.Length}個元素");
                    break;
                case IList ls when ls.Count == 0: //比對型態為list且為空list
                    Console.WriteLine("這是個空list");
                    break;
                case IList ls: //比對型態為list
                    Console.WriteLine($"列表總共有{ls.Count}項");
                    break;
                case String str://比對型態為string
                    Console.WriteLine($"此列{str}為字串型態");
                    break;
                case int aa://比對型態為int
                    Console.WriteLine($"此列{aa}為INT型態");
                    break;
                default: //不認得的型態直接取出原物件型態
                    Console.WriteLine($"我不認得這串字{instance.GetType()}");
                    break;
            }       
        }

        static void Main(string[] args)
        {
            //測試一空參考 
            DisplayInfo(null);
            //測試二空陣列           
            int[] intarr = { };
            DisplayInfo(intarr);
            //測試三含有值陣列
            int[] intarr2 = {4,5,55,77,99 };
            DisplayInfo(intarr2);
            //測試四空List
            List<long> listet = new List<long>();
            DisplayInfo(listet);
            //測試四含有清單項的List
            List<long> listet2 = new List<long> { 3,1,5,33,99,88,22};
            DisplayInfo(listet2);
            //測試五含String
            string str1 = "{我是測試}";  
            DisplayInfo(str1);
            //測試六含Int
            int int1 = 12345678;
            DisplayInfo(int1);
            //測試七不認得的型態
            double dob1 = 0.1;
            DisplayInfo(dob1);

            Console.ReadLine();

        }
    }
}
