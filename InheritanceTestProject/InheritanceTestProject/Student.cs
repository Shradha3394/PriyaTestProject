using System;
using System.Collections;
using System.Collections.Generic;
namespace InheritanceTestProject
{
    class Student
    {
        //public int Rank;
        // public int RollNo;

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<int> CourseIds { get; set; }


        //public ICollection<Student> Students { get; set; }

        static List<Student> students = new List<Student>() {
            new Student(1,4,23,"riya",2,1),
           new Student(3,5,22,"ram",3,2),
           new Student(1,6,25,"piya",4,3),

        };

        // List<int> intList = new List<int>() { 2,3,4 };

     
        public Student(int id,  int rank,int rollno,string studentname, int studentid, int courseids)// : base(id, name)
        {

          //  Rank = rank;
           // RollNo = rollno;
            StudentId = studentid;
            StudentName = studentname;
            //List <int>CourseIds = c.courseids ;
            




        }


        public void ShowData()
        {
            //  Console.WriteLine("your rank is {0}", Rank);
            // Console.WriteLine("your RollNo is {0}", RollNo);
            // Console.WriteLine("your id is {0}", Id);
            //  Console.WriteLine("your name is {0}", Name);

            Console.WriteLine("student name is {0}", StudentName);
            Console.WriteLine("student id is {0}",StudentId);
            Console.WriteLine("course id is {0}", CourseIds);
           
            Console.ReadLine();
        }

        



    }
}
