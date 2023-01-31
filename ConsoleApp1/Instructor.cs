using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Instructor
    {
    public int InstructorId { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string Gender { get; set; }
    public int DepartmentId { get; set; }
    public int EducationLevelId { get; set; }
    public DateTime DOB { get; set; }
    public int Reportto { get; set; }

        public string GetInstructorInfo()
        {
            string sqlConstrg = " Data Source = DESKTOP-P80G2BV ; Initial Catalog = SMS_NEW ; " +
                "Trusted_Connection = True;";
            string query = "select * from [dbo].[Instructor]\r\nwhere [InstructorId] in (75,79,38,17,31)";

            SqlDataReader dataReader;
            string output = " ";
            using (SqlConnection sqkn = new SqlConnection(sqlConstrg))
            {
                SqlCommand sqcd = new SqlCommand(query, sqkn);
                sqcd.Connection.Open();
                dataReader = sqcd.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + "\n";
                }
            }
            return output;
        }


    }
}
