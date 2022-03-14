using System;

namespace SEDC.OOP.Class02.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SEDC!");


            // brojki

            let a = 3;
            int number = 3;
            long bigNumber = 89743824627864781326478123786318274; // cannot add a big number in a 32-bit variable
            short shortNumber = 12000;
            byte smallNumber= 8;



            double doublePrecisionNumber = 12.937842;
            float singlePrecisionNumber = 12.2F;


            // string

            string str = "Jas sum Maja";
            char bukva = 'M';


            // boolean

            bool trueOrFalse = false;


            // DateTime

            DateTime currentDate = new DateTime();

            int module = 10;
            module %= 3;
            Console.WriteLine(module);



        }
    }
}
