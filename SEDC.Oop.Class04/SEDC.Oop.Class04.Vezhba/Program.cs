using System;

namespace SEDC.Oop.Class04.Vezhba
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime inAMonth = today.AddMonths(1);
            DateTime inAMonthAndThreedays = inAMonth.AddDays(3);
            DateTime oneYearAndTwoMonthsAgo = today.AddYears(-1).AddMonths(-2);
            int  month = today.Month;
            int year = today.Year;

            Console.WriteLine("Today" + today);
            Console.WriteLine($"The date in exactly a month: {inAMonth}");
            Console.WriteLine(string.Format("The date in exactly a month and 3 days will be: {0}", inAMonthAndThreedays));
            Console.WriteLine("The date a year and two months ago: {0}", oneYearAndTwoMonthsAgo);
            Console.WriteLine("The month today is: " + month);
            Console.WriteLine("The year today would be: " + year);


        }
    }
}
