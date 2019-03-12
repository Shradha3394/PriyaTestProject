using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTestProject
{
    class Teacher : Person
    {
        public int Salary;
        public string Subject;
        


         public Teacher(int id, string name, int salary, string subject) :base(id, name)
         {

            Salary = salary;
            Subject = subject;
         }
      


        public void ShowData()
        {
            Console.WriteLine("your salary is {0}", Salary);
            Console.WriteLine("your subject is {0}", Subject);
            Console.WriteLine("your id is  {0}",Id);
            Console.WriteLine("your name is {0}", Name);
            

        }
        
    }
}
