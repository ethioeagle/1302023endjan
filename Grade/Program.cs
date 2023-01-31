using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Grade G = new Grade();
            Console.WriteLine("The grade is {0}", G.GetGrade(50));
            Console.ReadLine();
            
        }
    }
}
