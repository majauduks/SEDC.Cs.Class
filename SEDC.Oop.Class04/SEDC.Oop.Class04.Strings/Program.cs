using System;

namespace SEDC.Oop.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Trajan";
            string hello1 = "Hello" + name;

            string hello2 = string.Format("Hello {0}" , name);
            string hello3 = $"Hello {name}";

            Console.WriteLine("Hello1: " + hello1 + "\n" +  "Hello2:" + hello2 + "Hello3:" + hello3);

            string path = "Check your c:\\ drive";
            string a = "We will have a \"fair\" selection";
            string b = "The \"\\n\" sign means: new line";
            string polesno = @"The \n sign means:new line";
           
            Console.WriteLine(polesno);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(path); 

            string filePath= $@"System\Windows\{name}";
            string cc = @"Check your c:\\drive";

            Console.WriteLine();

            string myStringCurrency = string.Format("{0:C}", 150);
            Console.WriteLine(myStringCurrency);


            int phoneNumber = 077132213;
            int number = 077 - 512 - 050;
            Console.WriteLine(number);
            string formatedNumber = string.Format("{0:0##-###-###}", phoneNumber);
            Console.WriteLine(formatedNumber);
            string formatedWithMultipleStrings = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}", "Hello", "my", "name", "is", "Maja", "and", "this", "shit", "is");

            string ourString = "            We are lerning c# and it is FUN and EASY, okay maybe just FUN.                                          ";
            string lowerLetters = ourString.ToLower();
            Console.WriteLine(lowerLetters);
            string upperLetters = ourString.ToUpper();
            Console.WriteLine(upperLetters);

            string[] splitted = ourString.Trim().Split(' ');
            Console.WriteLine("The length is: " + splitted.Length);

            foreach(string word in splitted)
            {
                Console.WriteLine(word);
            }


            Console.WriteLine(formatedWithMultipleStrings);

            string substring = ourString.Trim().Substring(15,30);
            Console.WriteLine(substring);


            Console.ReadLine();



        }

    }
}
