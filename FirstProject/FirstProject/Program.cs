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
            PrintNoOneToTen();
           // PrintPattern1();
           //PrintPattern2();
          //  PrintPattern3();

        }

        private static void PrintNoOneToTen()
        {
            Console.Write("display number one to ten");
            Console.WriteLine("");
            for(var i=1;i<=10;i++)
            {
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
            for (var i = 1; i <= 3; i++)
            {
                for (var j = 1; j <= 3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (var k = 1;k<=(2 * i)-1;k++)
                {
                    Console.Write("1");
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
                for (var j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }



        }
    }
}
    



       
     
























