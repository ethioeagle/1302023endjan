using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class Grade
    {
        public int Studentid { get; set; }
        public string  FName { get; set; }
        public string  LName { get; set; }
        public string  Sex { get; set; }
        public int  Age { get; set; }

        public string GetGrade(int mark)
        {
            if (mark > 90) return "A";
            else if (mark > 80) return "B";
            else if (mark > 70) return "C";
            else if (mark > 60) return "D";
            else return "F";
            
        }
    }
}
