﻿using System;
//此練習為自建函數自己叫用的做法，使用到多載的寫法及this關鍵字;
//關鍵字guid表示在system的NameSpace中，全域唯一識別項Object
namespace ConsoleThisFunction
{
    class program
    {
        public class Production //建立類別
        {
            public Guid ProductID { get; set; } //建立屬性
            public string ProductName { get; set; }//建立屬性
            public DateTime ProductDate { get; set; }//建立屬性
            public decimal ProductPrice { get; set; }//建立屬性
            public Production(Guid pid, string pname, DateTime pdate, decimal price) //實例化Production類別
            {
                ProductID = pid;
                ProductName = pname;
                ProductDate = pdate;
                ProductPrice = price;
            }
            //以下是多載 Overloading的做法

            public Production(string pname, DateTime pdate, decimal price) : this(Guid.NewGuid(), pname, pdate, price) { } //利用this自叫函數;並自帶4個參數
            public Production(string pname, DateTime pdate) : this(Guid.NewGuid(), pname, pdate, 0) { } //自帶2個參數pname及pdate，其它參數用預設值
            public Production(DateTime pdate) : this(Guid.NewGuid(), "未知產品", pdate, 0) { }//自帶1個參數pdate

            public Production() : this(Guid.NewGuid(), "品名不詳", DateTime.Today, 0) { }//無自帶參數;完全用預設值
                                                                                     //結束多載

        }

        static void Main(string[] args)
        {
            Production p1 = new Production(); //沒傳任可參數時
            Console.WriteLine($"產品編號:{ p1.ProductID}\n 產品名稱:{p1.ProductName}\n 生產日期:{ p1.ProductDate}\n 價格:{p1.ProductPrice}");

            Production p2 = new Production("筆電", new DateTime(2020, 12, 12)); //只傳4個參數中的2個，品名及日期
            Console.WriteLine($"產品編號:{ p2.ProductID}\n 產品名稱:{p2.ProductName}\n 生產日期:{ p2.ProductDate}\n 價格:{p2.ProductPrice}");

            Production p3 = new Production(new DateTime(2020, 12, 12));//僅傳日期
            Console.WriteLine($"產品編號:{ p3.ProductID}\n 產品名稱:{p3.ProductName}\n 生產日期:{ p3.ProductDate}\n 價格:{p3.ProductPrice}");

            Production p4 = new Production("桌機", new DateTime(2020, 12, 12), 10000);//僅傳日期
            Console.WriteLine($"產品編號:{ p4.ProductID}\n 產品名稱:{p4.ProductName}\n 生產日期:{ p4.ProductDate}\n 價格:{p4.ProductPrice}");

        }
    }
}