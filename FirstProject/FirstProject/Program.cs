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
			PrintPattern1();

		}

		//Print Pattern
		static void PrintPattern1()
		{
			for (var i = 1; i <= 3; i++)
			{
				for (var j = 1; j <=3-i; j++)
				{
					Console.Write(" ");
				}
				for (var k = 1; k <= (2 * i) - 1 ; k++)
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

	        
	    }


	    //*****
	    // ***
	    //  *
	    static void PrintPattern3()
	    {


	    }
    }
}
// Task2:string Reverse

       
     
























