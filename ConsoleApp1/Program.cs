using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Course K = new Course();
        //    int e = K.TotalCrHrs();
        //    Console.WriteLine("Your Total Cr Hrs is {0} .", e);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    Course H = new Course();
        //    Console.WriteLine("Your Total Credit  Hours is {0 } .", H.AddCrHrs(4, 6, 8));
        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {

            Course c = new Course();
            Console.WriteLine(c.GetCourseInfo());

            Department d = new Department();
            Console.WriteLine(d.GetDepartmentInfo());

            Faculty f = new Faculty();
            Console.WriteLine(f.GetFacultyInfo());

            Grade g = new Grade();
            Console.WriteLine(g.GetHighestGradeInfo());

            Instructor i = new Instructor();
            Console.WriteLine(i.GetInstructorInfo());

            Student s = new Student();
            Console.WriteLine(s.GetStudentinfo());


            Console.ReadLine();

        }
    }
}
