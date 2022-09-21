using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeDbDemo
{
    public class Program
    {
        static void Main(string[] args)
        {


            int eid = 4;
            string ename = "Raghu";
            string gender = "Male";
            string address = "Hyedrabad";
            float salary = 35000.0f;

            
            SqlConnection conn = null; // this is a connection object
            //conn = new SqlConnection("datasource=.;database=SoleraEmployees;intergrated security=true");
            //conn = new SqlConnection("Server=.;database=SoleraEmployees;user=sa;password=sa"); // this thing is also valid
            conn = new SqlConnection("server=.;database=SoleraEmployees;user id=sa;pwd=sa");
            // we can give connection details via constructor or via the props of conn
            //conn.ConnectionString="datasource=.;database=SoleraEmployees;user id=sa;pwd=sa" // this thing is also valid

            string inStr = $"insert into Employee values({eid},'{ename}','{gender}','{address}',{salary})";

            SqlCommand cmd = new SqlCommand(inStr,conn);
            //cmd.CommandText = inStr;
            //cmd.Connection=conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();   // return the no of rows executed
                
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message); 
                Console.WriteLine(ex.StackTrace);   

            }
            finally
            {
                if(conn.State!=ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

            Console.Read();

        }
    }
}
