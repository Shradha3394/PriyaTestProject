using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTestProject
{
   public class Person 
   {
        public int Id;
        public string Name;
        public Person(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public void GetId()
        {
            Console.WriteLine("id {0}", Id);
        }
        public void GetName()
        {
            Console.WriteLine("name {0}",Name);
        }
      
   }
}
