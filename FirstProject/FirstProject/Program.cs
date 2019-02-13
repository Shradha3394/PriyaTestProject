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
			PrintPattern();

		}


		//Print Pattern
		static void PrintPattern()
		{
			
			int i, j,k;
			for (i = 1; i <= 3; i++)
			{

				for (j = 1; j <=3; j++)
				{
					Console.Write("*");
					Console.WriteLine(" ");
				}
				for (k = 2; k <= i+1 ; k++)
				{
					Console.Write(" * ");
					Console.WriteLine(" ");
				}

			}
			  
            	Console.WriteLine("");
			Console.ReadLine();
		}
		
	
		
	}
}
// Task2:string Reverse

       
     
























