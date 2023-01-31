using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Faculty
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }

        public string GetFacultyInfo()
        {
            string sqlConstrg = " Data Source = DESKTOP-P80G2BV ; Initial Catalog = SMS_NEW ; " +
                "Trusted_Connection = True;";
            string query = "select * from [dbo].[Faculty]\r\nwhere [FacultyId] in (1,2,5,6,9,10,12,13)";

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
