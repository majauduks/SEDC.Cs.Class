using System;

namespace SEDC.OOP.Class02.Exercises.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //double prvaVarijabla;
            //double vtoraVarijabla;
            //prvaVarijabla = 9846871236782647;
            //vtoraVarijabla = 90748942897823;
            //double podeleniVarijabli = vtoraVarijabla / prvaVarijabla;
            //int broj1 = 934872;
            //int broj2 = 9084923;
            //Console.WriteLine(podeleniVarijabli);
            //Console.WriteLine(podeleniVarijabli > broj1/broj2);
            //var x = broj1 / broj2;

            //string rechenica = "bjfksdhfjkdsa";
            //string vtoraRechenica = "jkshfjkdsa";
            //string konkatenirano = rechenica + vtoraRechenica;

            //string devet = "9";
            //string tri = "3";
            //string spoeni= devet + tri;

            //int broj = 89374823;
            //string zbor = "fiuafi";
            //string dveteZaedno = broj + zbor;
            //Console.WriteLine(dveteZaedno);



            //int n = 102;
            //int m = 5;
            //int s = n / m;
            //Console.WriteLine(s);


            //Console.WriteLine("==========DATA ENTRY============");
            //string input = Console.ReadLine();
            //Console.WriteLine("This is the input value: " + input);


            //// int parsedToInteger = int.Parse(input);
            //// Console.WriteLine(parsedToInteger);

            //// bool parsedToBoolean = Convert.ToBoolean(input);
            //// Console.WriteLine("This is the parced input value" + parsedToBoolean);
            //// int parsedToBoolean = Convert.ToInt32(input);

            //long parsedToLong = 0;
            //bool isValidInput = long.TryParse(input, out parsedToLong);

            //bool isValidInput1 = long.TryParse(input, out long parsedToLong1);
            //Console.WriteLine(parsedToLong);
            //string parsedToString = parsedToLong.ToString();

        //    Console.WriteLine("=====BRANCHING=====");

        //    string input = Console.ReadLine();
        //    bool isValidInteger = int.TryParse(input, out int parsedInput);
        //   if(isValidInteger)
        //        Console.WriteLine(parsedInput);
        //else
        //Console.WriteLine("Ne e validen vnesot");
        //    int firstNumber = 5;
        //    int secondNumber = 10;
        //    int thirdNumber = 15;
        //    int fourthNumber = 20;
        //    if(firstNumber<secondNumber && firstNumber>thirdNumber)
        //        Console.WriteLine("Pobjedila sam");
        //    else if (thirdNumber <fourthNumber || secondNumber > fourthNumber)
        //        Console.WriteLine("it's a true statement");
        //    else if (firstNumber < secondNumber)
        //        Console.WriteLine("The second else if statement is sooooo tru yooooooooooo");
        //   else 
        //        Console.WriteLine("hehz, sepak ne");
        //    Console.ReadLine();

            //int someNumber = 15;

            //Console.WriteLine("=========switch=========");
            //switch (someNumber)
            //{
            //    case 1:
            //        break;
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    case 4:
            //        break;
            //    default:
            //        Console.WriteLine("Je suis Default");
            //        break;



            //        float branchesOnTree = 12;
            //        float applesOnABranch = 8;
            //        float applesInABasket = 5;
            //        float amountOfBaskets = 0;

         
            //    amountOfBaskets = branchesOnTree / applesInABasket;
            //    float baskets = branchesOnTree * applesOnABranch / applesInABasket;
            //Console.WriteLine(baskets);



            //string numberOne = Console.ReadLine();
            //string numberTwo = Console.ReadLine();
            //bool isValid = int.TryParse(numberOne, out int parsedToInt);
            //bool isValidTwo = int.TryParse(numberTwo, out int ParsedToIntTwo);
            //if (parsedToInt>ParsedToIntTwo)
            //    Console.WriteLine("Number one is larger"); 
            //else
            //    Console.WriteLine("Number two is larger");

            //if (parsedToInt % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}
            //if (ParsedToIntTwo % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}


            Console.WriteLine("Enter a number from 1 - 3"); 
            string input = Console.ReadLine();
            bool isValidNumber = int.TryParse(input, out int numberInput);

            switch(numberInput)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;

                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;

                default:
                    Console.WriteLine("Enter a valid number");
                    break;
            }    



        }
    }
    }

