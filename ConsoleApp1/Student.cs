using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Studentid { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        //public List<Student> GetStudents()
        //{
        //    SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-P80G2BV;SMS_NEW;Trusted_Connection = True;");
        //    SqlCommand cmd = sqlConnection.CreateCommand();
        //    cmd.CommandText = "Select * from Student";

        //    sqlConnection.Open();
        //    cmd.ExecuteReader();

        //    return null;
        //}

        public string GetStudentinfo()
        {
            string sqlConstrg = " Data Source = DESKTOP-P80G2BV ; Initial Catalog = SMS_NEW ; " +
                "Trusted_Connection = True;";
            string query = "select * from student\r\nwhere [StudentId] in(5,6,8,9,16,17,18,22,33,103)";
                
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

