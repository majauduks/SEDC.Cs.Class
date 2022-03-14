using System;

namespace SEDC.Oop.Class04.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeChanged = "Jas sum edna mnogu fancy niza";
            Console.WriteLine("Vnesi od kade sakash da pochnuva nizata");
            int arrayBeginning = GetInfo();
            Console.WriteLine("Vnesi kolu sakash da e dolga nizata");
            int arrayLenght = GetInfo();
            string changed = toBeChanged.Substring(arrayBeginning, arrayLenght);
            Console.WriteLine(changed);



            Console.ReadLine();
        }
        public static int GetInfo()
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                bool isInputOkay = int.TryParse(input, out int number);
                if (isInputOkay)
                {
                    return number;
                }
                Console.WriteLine("Enter a valid number");
            }

            return 0;
        }
    }
}
