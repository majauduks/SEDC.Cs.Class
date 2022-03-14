using System;

namespace SEDC.Oop.arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[5];
            // numbers[0] = 1;
            // numbers[1] = 2;
            // numbers[4] = 5;

            // Console.WriteLine(numbers[2]);
            // Console.WriteLine(numbers[4]);


            //// numbers[5] = 10;

            // string[] names = new string[10]
            // {
            //     "Maja",
            //     "Vlatko",
            //     "Stefan",
            //     "Aneta",
            //     "fhsja",
            //     "nfjskda",
            //     "njksdfa",
            //     "Trajan",
            //     "njfsa",
            //     "nfsd"

            // };


            // bool[] booleans = { true, true, true, false };

            // double[] doubles = { 1.1, 1.2, 1.3, 1.4 };

            // int lengthOfArray = names.Length;

            // for(int i=0; i < names.Length; i++)
            // {
            //     Console.WriteLine(names[i]);
            // }


            // int indexOfVlatko = Array.IndexOf(names,"Vlatko");
            // Console.WriteLine(indexOfVlatko); ;



            // Array.Resize(ref names, 6);

            // names[5] = "Sofki";

            // Array.Sort(names);

            // for(int i=0; i <names.Length; i++)
            //     Console.WriteLine(names[i]); 

            // Console.WriteLine(names[5]);




            // foreach(string element in names)
            // {
            //     if(element == "Aneta")
            //     {
            //         continue;
            //     }


            //     if(element=="Trajan")
            //     {
            //         break;
            //     }
            //     Console.WriteLine("Foreach with names:" + element);
            // }


            // string [] words =
            // {
            //     "jas",
            //     "sakam",
            //     "da",
            //     "se",
            //     "istrcham"
            // };

            // float[] decimals =
            // {
            //     1.2f,
            //     1.1f,
            //     1.3f,
            //     1.4f,
            //     1.5f
            // };


            // char[] characters =
            // {
            //     'm',
            //     'a',
            //     'j',
            //     'a',
            //     'n'
            // };

            // bool[] booleansVezhba =
            // {
            //     true,
            //     true,
            //     true,
            //     true,
            //     true
            // };


            // int[][] arrays =
            // {
            //    new int[] {
            //       1,
            //         2
            //     },

            //    new int[] {
            //         1,

            //     }
            //    };



            // int[] fiveElements = new int[5];
            // int sum = 0;

            // int counter = 0;
            //while(counter<fiveElements.Length)
            // {
            //     Console.WriteLine("Vnesi element");


            //    bool isElementOkay = int.TryParse(Console.ReadLine(), out fiveElements[counter]);
            //     if (isElementOkay)

            //     {
            //         sum += fiveElements[counter];
            //     }

            //     else
            //     {
            //         Console.WriteLine("Vnesi validen broj");
            //         continue;
            //     }

            //     counter++;

            // }

            // Console.WriteLine(sum);


            string[] myNames = new string[5];

            string charEntered = "Y";
            int brojac = 0;

            while (charEntered == "Y")
            {
                Console.WriteLine("Dali sakate da vnesete ushte iminja? Vnesi Y(es) ili N(o)");
                string odgovor = Console.ReadLine();
                if (odgovor == "Y")
                {
                    Console.WriteLine("Vnesi go imeto");

                    if (myNames.Length < brojac)
                    {
                        Array.Resize(ref myNames, brojac);
                        myNames[brojac] = Console.ReadLine();
                        continue;
                    }

                    myNames[brojac] = Console.ReadLine();

                }


                else if (odgovor == "N")
                {
                    charEntered = "N";
                }
                else
                {
                    Console.WriteLine("Vnesi validen odgovor");
                }
                brojac++;
            }

            foreach (string name in myNames)
            {
                Console.WriteLine(name);
            }
        }

    }
}
