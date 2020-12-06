using System;
  
namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Namecheck aa = new Namecheck(); //宣告aa為Namecheck物件並實例化
            try {
                aa.NameLengthCheck = "11111111";//傳入字串字串長度檢查
                if (aa.NameNumCheck("22222a"))
                {
                    Console.WriteLine("數字字串驗証OK");
                }
                else { Console.WriteLine("非全數字字串"); }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ ex.Message}");
            }
         
            Console.WriteLine($"{aa.NameLengthCheck}");
        }
    }
    
    class Namecheck
    {
        string Rtn_name;
        public String NameLengthCheck
        {
            get { return Rtn_name; } //回傳屬性設定值
            set
            {
                if (value.Length > 15) //value 為屬性傳入設定值
                { throw new Exception("超過15個字"); }
                else
                {
                    Rtn_name = value; //設定回傳屬性設定值
                }
            }

        } //字串長度驗証,用屬性的做法
        public bool NameNumCheck(string name)//全數字字串驗証,建置函數的作法.
        {
          long i;
            if (long.TryParse(name, out i)) //tryparse的用途字串若為全數字則回傳true
                {
                      return  true;
                     }
            else
            {      
                     return false;
            }
        }
                


        
    }
}
