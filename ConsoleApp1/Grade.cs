using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Grade
    {
        public string Cono { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }
        public int Mark { get; set; }

        public string GetHighestGradeInfo()
        {
            string sqlConstrg = " Data Source = DESKTOP-P80G2BV ; Initial Catalog = SMS_NEW ; " +
                "Trusted_Connection = True;";
            string query = "select StudentId,max(Mark)as highestMark from [dbo].[Grade]\r\nwhere StudentId in (1,2,3,4,5,6)\r\ngroup by StudentId\r\norder by studentid";

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
