using System.ComponentModel.DataAnnotations;
using System;

namespace try.Models
{
    public class Employees
    {
        [Key]
        public int Employeeid { get; set; }
        public string Name { get; set; }
}
}
