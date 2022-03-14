using System;

namespace SEDC.Oop.Class04.Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine(date);


            DateTime customDate = new DateTime(1992, 10, 15);
            Console.WriteLine(customDate);


            string date1 = "12.15.2022";
            string date2 = "12/15/2022";
            string date3 = "12/15/22";
            string date4 = "jan.15.12";
            string date5 = "12-15-2012";


            DateTime convertedDate = DateTime.Parse(date1);
            Console.WriteLine(convertedDate);
            DateTime convertedDate2 = DateTime.Parse(date2);
            Console.WriteLine(convertedDate2);
            DateTime convertedDate3 = DateTime.Parse(date3);
            Console.WriteLine(convertedDate3);
            DateTime convertedDate4 = DateTime.Parse(date4);
            Console.WriteLine(convertedDate4);
            DateTime convertedDate5 = DateTime.Parse(date5);
            Console.WriteLine(convertedDate5);


            DateTime currentDate = DateTime.Today;
            Console.WriteLine(currentDate);
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);
            DateTime currentDay = DateTime.Today.Date;
            Console.WriteLine();
            Console.WriteLine($"Today, {currentDay.ToString("yyyy.MM.dd")} is international Pi day");

            DateTime addedDays = currentDateAndTime.AddDays(5);
            Console.WriteLine(currentDateAndTime);
            DateTime removedDays = currentDateAndTime.AddDays(-10);
            Console.WriteLine(removedDays);

            int year = currentDateAndTime.Year;
            int day=currentDate.Day;
            int month = currentDateAndTime.Month;

            string dateFormat1 = currentDateAndTime.ToString("M/dd/yy");
            Console.WriteLine(dateFormat1);

            //string dateFormat2 = currentDateAndTime.ToString("yy.m");
            //Console.WriteLine(dateFormat2);      --------->>>> Ovde dava problem

            string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:dddd}", currentDateAndTime);
            Console.WriteLine(dateFormat3);

            Console.ReadLine();


        }
    }
}
