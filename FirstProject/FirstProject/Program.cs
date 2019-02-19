using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ToUpper();
            Percentage();
        }
        public static void ToUpper()
        {
            string str = "heLlo world";
            string[] strArr;
            strArr = new string[5];
            char[] splitchar = { ' ' };
            strArr = str.Split(splitchar);

            strArr[0] = strArr[0][0].ToString().ToUpper();
            strArr[1] = strArr[1].ToString().ToUpper();

            Console.WriteLine("ToUppercase is:-{0} ", strArr);


            Console.ReadLine();

        }

        private static void PrintNoOneToTen()
        {
            Console.Write("display number one to ten");
            Console.WriteLine("");
            for (var i = 1; i <= 10; i++)
            {
                Console.Write(" ");
                Console.Write("{0}", i);
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


        static void Percentage()
        {
            int per;
            Console.Write("enter the number");
            string number = Console.ReadLine();
            per =Convert.ToInt32(number);
            Console.WriteLine("");

            
            switch(per)
            {
                case 'F':
                    if (per <= 29)
                        Console.WriteLine("Fail");
                    break;
                case '2':
                    if(per>30 && per<=44)
                    Console.WriteLine("Third division");
                    break;
                case '3':
                      if(per>45&&per<=59)
                    Console.WriteLine("Second division");
                    break;
                case '4':
                    if(per>60&&per<=100)
                    Console.WriteLine("First division");
                    break;
                  //default:
                  // Console.WriteLine("Input wrong");
                   // break;

            }
                    
                    Console.ReadLine();
        }
    }
}

    



       
     
























