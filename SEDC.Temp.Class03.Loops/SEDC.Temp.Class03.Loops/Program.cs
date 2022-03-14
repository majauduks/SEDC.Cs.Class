using System;

namespace SEDC.Temp.Class03.Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int timestoItterate = 100;
            //for(int index = timestoItterate; index>0; index--)
            //{
            //    Console.WriteLine(index);
            //}
            //        int index = 0;
            //        while (index < 10)
            //        {
            //            index++;
            //            Console.WriteLine(index);

            //        }
            //        int counter = 0;
            //        string str = "Maja-paja";
            //        while (str == "Maja-paja")
            //        {
            //            Console.WriteLine(str);
            //            if (counter == 10)
            //            {
            //                str = "Maja-ne-paja";
            //                Console.WriteLine(str);
            //            }
            //            counter += 2;
            //        }

            //        Console.ReadLine();


            //        bool isActive = true;

            //        while (isActive)
            //        {
            //                //Console.Clear();
            //            Console.WriteLine("1. Say hello");
            //            Console.WriteLine("2. Say goodbye");
            //            Console.WriteLine("3. Say something else");
            //            Console.WriteLine("0. Exit application");

            //            string input = Console.ReadLine();
            //            bool isValidInput = int.TryParse(input, out int selection);

            //            if (!isValidInput)
            //            {

            //                Console.WriteLine("Please enter a valid input");
            //                continue;



            //                if (selection == 1)
            //                {

            //                    Console.WriteLine("1. Say hello");
            //                }
            //                else if (selection == 2)
            //                {
            //                    Console.WriteLine("2. Say goodbye");
            //                }
            //                else if (selection == 3)
            //                {
            //                    Console.WriteLine("3. Say something else");
            //                }

            //                else if (selection == 0)
            //                {
            //                    Console.WriteLine("0. Exit application");

            //                }

            //                else
            //                {
            //                    Console.WriteLine("Please enter a valid input");
            //                }
            //            }
            //        }




            int counter = 0;

            //do
            //{
            //    Console.WriteLine("Will be executed at least once");
            //}
            //while (counter != 0);


            while (true)
            {

                Console.WriteLine("Enter a valid number");
                string inputUser = Console.ReadLine();

                if(inputUser == "A")
                {
                    Console.WriteLine("Thank you for using our app");
                    break;
                }
                bool isValidInput = int.TryParse(inputUser, out int selection);
                if (!isValidInput)
                {
                    Console.WriteLine("Not a valid number");
                    continue;
                }
                if (selection == 0)

                {
                    Console.WriteLine("Thank you for using our app");
                    break;
                }
                int result = selection * 10;
                 Console.WriteLine(result);

            }
            

            while (true)
            {
                if (false)
                {
                    while (true)
                    {
                        if(true)
                        {
                            continue;
                        }
                        break;
                    }

                    continue;
                  
                }
                break;
            }


           Console.ReadLine();


        }

    }


}

