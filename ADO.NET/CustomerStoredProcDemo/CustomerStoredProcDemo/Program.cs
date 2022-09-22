using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerStoredProcDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cname = "Somesh";
            string gender = "Male";
            string address = "Mysore";
            string mobile = "7894561231";
            string conStr = "server=.;database=SoleraEmployees;user id=sa;pwd=sa";
            SqlConnection con =new SqlConnection(conStr);
            SqlCommand cmd =  new SqlCommand("AddCustomer",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cname", cname));
            cmd.Parameters.Add(new SqlParameter("@gender", gender));
            cmd.Parameters.Add(new SqlParameter("@address", address));
            cmd.Parameters.Add(new SqlParameter("@mobile", mobile));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();   // return the no of rows executed - works for insert,update, delete,create 



            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

            Console.Read();

        }
    }
}
