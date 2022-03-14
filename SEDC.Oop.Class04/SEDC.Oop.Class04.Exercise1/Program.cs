using System;

namespace SEDC.Oop.Class04.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                int number1 = getANumberFromUser();
                int number2 = getANumberFromUser();
                Console.WriteLine("Enter if you want * or /");
                string choice = Console.ReadLine();

                //if (!isNumber1Okay && !isNumber2Okay)
                //{
                //    Console.WriteLine("Enter a valid number");
                //    continue;
                //}

                switch(choice)
                {
                    case "*":
                flag = false;
                Console.WriteLine(multiply(number1, number2));
                        break;
                    case "/":
                Console.WriteLine(divide(number1,number2));
                        break;
                    default:
                        Console.WriteLine(multiply(number1, number2));
                        break;


                }
            }
        }


            public static int multiply(int a, int b)
            {

                return a * b;
            }

            public static int divide(int a, int b)
            {
                if (b != 0)
                    return a - b;
                else
                {
                    Console.WriteLine("Cant devide by zero");
                    return 0;
                }
            }

        public static int getANumberFromUser()
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
    
