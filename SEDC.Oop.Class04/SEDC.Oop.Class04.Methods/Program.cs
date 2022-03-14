using System;

namespace SEDC.Oop.Class04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            sayHello();


            // Console.WriteLine(sum(2, 4));

            //or

            int result = sum(2, 4);
            Console.WriteLine(result);


            Console.WriteLine(welcomeUser("MaePae", 27, true));



















            Console.ReadLine();

        }

        private static int sum (int a, int b)
        {
            int result = a + b;
        
            return result;
        }
            static void sayHello ()
            {
                Console.WriteLine("Hello SEDC");
            }


        internal static string welcomeUser (string userName, int age, bool shouldBeColored)
        {
            if (shouldBeColored)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }

            string str = string.Empty;

            if(age>30) {
                str = "Welcome mr." + userName + "!";
            }

            str = "Welcome" + userName + "!";
            return str;
        }
    }
}
