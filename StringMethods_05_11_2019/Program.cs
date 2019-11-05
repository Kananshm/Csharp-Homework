using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods_05_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            StringMethod Str = new StringMethod();
            Str.str = "Musa Musayev";


            string mes = "Kanan Mammmadli";

            Console.WriteLine(Str.str.Replace("ayev","Altay"));
            //string mes = "Kanan Mammadli";

            //Console.WriteLine(mes.Length); 

            //Str.IndexOf("s");
            //.WriteLine(Str.IndexOf("v"));
            //Str.GetLength();
            //Console.WriteLine(Str.GetLength());


            //Str.Substring(1, 4);
            //Console.WriteLine(Str.Substring(1,4));
            Console.ReadKey();
        }
    }
}
