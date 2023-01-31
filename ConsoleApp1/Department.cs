using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }

        public string GetDepartmentInfo()
        {
            string sqlConstrg = " Data Source = DESKTOP-P80G2BV ; Initial Catalog = SMS_NEW ; " +
                "Trusted_Connection = True;";
            string query = "select * from [dbo].[Department]\r\nwhere [DepartmentId] in (5,9,17,19,20,21,24,35,37,41)";
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
