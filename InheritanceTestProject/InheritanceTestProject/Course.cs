using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InheritanceTestProject
{
    class Course
    {
       public int Id;
       public string Name;
       static List<Course> courses = new List<Course>() {
            new Course(1,"java"),
           new Course(3,"php"),
           new Course(1,".net"),
           new Course(4,"java"),
            new Course(2,".net"),
        };
      

        // public static void GetCourseById(int id)
        // {
        // foreach (var course in courses)
        // {
        //if (course.Id == id)

        //  course.ShowData();
        // }
        // }
        public static void GetCourseByStudentId(int Studentid)
        {
            foreach(var StudentId in courses)
            {
               
                    StudentId.ShowData();
            }
        }


            
        public Course(int id,string name)
        {
                Id = id;
               Name = name;
        }
        public void ShowData()
        {
            //Console.WriteLine("enter the id");
            Console.WriteLine("your id is {0}", Id);
            Console.WriteLine("course name is {0}", Name);
          //  Console.WriteLine("student id is {0}", StudentId);
            //Console.WriteLine("course id is {0}", CourseId);
            Console.ReadLine();
        }
       

    }
}
