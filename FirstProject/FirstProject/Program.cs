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
            List<Student> students = new List<Student>() { new Student("abc", 1, 2, 22), new Student("priya", 2, 1, 23), new Student("ram", 4, 3, 18) };
            foreach (var student in students)
            {
                if(student.StudentAge>20)
                   student.Display();

            }
            Console.ReadLine();

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
        //static void PrintPattern2()








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
            per = Convert.ToInt32(number);



            switch (per)
            {
                case var expression when per <= 29:
                    Console.WriteLine("Fail");
                    break;
                case var expression when per > 30 && per <= 44:
                    Console.WriteLine("Third division");
                    break;
                case var expression when per > 45 && per <= 59:
                    Console.WriteLine("Second division");
                    break;
                case var expression when per > 60 && per <= 100:
                    Console.WriteLine("First division");
                    break;
                default:
                    Console.WriteLine("Input wrong");
                    break;

            }

            Console.ReadLine();
        }
        static void CheckNumber()
        {
            int num;
            Console.Write("enter the number");
            string number = Console.ReadLine();
            num = Convert.ToInt32(number);
            switch (num)
            {
                case var expression when num == 0:
                    Console.WriteLine("number is zero");
                    break;
                case var expression when num < 0:
                    Console.WriteLine("number is negative");
                    break;
                default:
                    Console.WriteLine("number is positive");
                    break;
            }
            Console.ReadLine();
        }
    }

 }
class Student
{
    public void Display()
    {
       
        Console.WriteLine("welcome {0}", StudentName);
        Console.WriteLine("your id is {0}", StudentID);
        Console.WriteLine("your rank is {0}", StudentRank);
        Console.WriteLine("your age is {0}", StudentAge);


    }
    string StudentName;
    int StudentID;
   public  int StudentRank, StudentAge;
    public Student(string name, int ID, int Rank, int Age)
    {
        StudentName = name;
        StudentID = ID;
        StudentRank = Rank;
        StudentAge = Age;
        
    }
}



    
      
 
            
    





















    


    



       
     
























