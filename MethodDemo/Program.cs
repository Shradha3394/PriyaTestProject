using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // problem 4:calling a method
         //   Method.Sum(2,3);
            //Problem 1:create and access variable
            int Number = 2;
            Number = Number * 2;
            Console.WriteLine("Double of a number: {0}", Number);
            string Name = "hello";
            Console.WriteLine(Name);
            Console.ReadLine();



           
        }
    }
 
    class Method
    {
        //Problem 2: method creation
      //  public static void Sum()
       // {


        //}

        //Problem 3:pass parameter to the method created in problem 2
        //problem 5:print sum
        public static void Sum(int num1, int num2)
        {
            int total;

            total = num1 + num2;
           
           Console.WriteLine("Sum of two numbers:{0}", total);
            Console.ReadLine();
           


        }
       



    }
          
    
    
}
