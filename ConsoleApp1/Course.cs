using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Course
    {
        public string cono { get; set; }
        public string Cotitle { get; set; }
        public int CrHr { get; set; }



        //public int TotalCrHrs()
        //{
        //    Console.WriteLine("Enter Your CreditHrs");
        //    int c1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter Your CreditHrs");
        //    int c2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter Your CreditHrs");
        //    int c3 = int.Parse(Console.ReadLine());

        //    int CT = c1 + c2 + c3;
        //    return CT;
        //}
        //public int AddCrHrs(int H1, int H2, int H3)
        //{
        //    int HT = H1 + H2 + H3;
        //    return HT;
        //}






        public string GetCourseInfo()
        {
            string sqlConstrg = " Data Source = DESKTOP-P80G2BV ; Initial Catalog = SMS_NEW ; " +
                "Trusted_Connection = True;";
            string query = "select * from [dbo].[Course]\r\nwhere [cono] in ('COURSE101','COURSE111','COURSE121','COURSE131','COURSE141','COURSE151','COURSE161','COURSE171')";

            SqlDataReader dataReader;
            string output = " ";
            using (SqlConnection sqkn = new SqlConnection(sqlConstrg))
            {
                SqlCommand sqcd = new SqlCommand(query, sqkn);
                sqcd.Connection.Open();
                dataReader = sqcd.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(1) + "\n";
                }
            }
            return output;
        }



    }
    
}