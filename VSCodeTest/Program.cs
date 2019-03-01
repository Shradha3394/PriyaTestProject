using System;

namespace FirstProject
{
    class Program
    {
        public static void Main(string[] args)
        {
           var array = new int[] { 8, 9, 3, 7 };
            
            foreach(var arr in array) {  
            Console.WriteLine(arr);}  
          
            Console.ReadLine();
        }

        private static void PrintNoOneToTen()
        {
            Console.WriteLine("display number one to ten");
            for (var i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("");
        }

        //Print Pattern
        static void PrintPattern1()
        {
            for (var i = 1; i <= 3; i++)
            {
                for (var j = 1; j <= 3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (var k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //  1
        // 234
        //56789
        static void PrintPattern2()
        {
            var number = 0;

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 1; j <= 3 - i; j++)
                {
                    Console.Write(" ");
                }

                for (var k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("{0}", ++number);

                }
                Console.WriteLine("");
            }
        }

        //*****
        // ***
        //  *
        static void PrintPattern3()
        {
            for (var i = 5; i >= 1; i--)
            {
                for (var j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (var k = 0; k <= i - 2; k++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        //stringreverse
        static void stringreverse()
        {
            string name = " ", revname = " ";
            int vowelsCount = 0, spaceCount = 0;
            char str;
            Console.WriteLine("enter the string:");
            name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revname = revname + name[i];
                //Titlecase                

                // name=char.ToUpper(name[0])+name.Substring(1);


                //Console.WriteLine("string with first letter uppercase:[name]");


            }

            //vowels & space count
            for (int i = 0; i < name.Length; i++)
            {
                str = name[i];
                if (str == 'a' || str == 'e' || str == 'i' || str == 'o' || str == 'u')
                {
                    vowelsCount++;
                }
                else if (str == ' ')
                {
                    spaceCount++;
                }


            }


            Console.WriteLine("reverse string is:-{0}", revname);
            // Console.WriteLine("ToUppercase is {0}",ToUpper);
            Console.WriteLine("No of vowles:{0}", vowelsCount);
            Console.WriteLine("No of space:{0}", spaceCount);

            Console.ReadLine();





        }
        static void printpercentage()
        {

            Console.Write("enter the number");
            for (int i = 1; i > 100; i++)
            {
                Console.Write("wrong input:-{0}", i);
            }
            Console.ReadLine();





        }


    }
}
