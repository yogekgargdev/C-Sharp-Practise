using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDBParmasDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int eid = 0;
            string ename = "Shaishvi";
            string gender = "Female";
            string address = "Bangalore";
            float salary = 45000.0f;

            string strCon = "server=.;database=SoleraEmployees;user id=sa;pwd=sa";
            SqlConnection con = new SqlConnection(strCon);
            string insStr = "insert into Employee values(@eid,@ename,@egender,@eaddress,@emobile)";
            SqlCommand cmd = new SqlCommand(insStr, con);

            SqlParameter[] param = new SqlParameter[5];
            param[0] =new SqlParameter("@eid", eid);
            param[1] = new SqlParameter("@ename", ename);
            param[2] = new SqlParameter("@egender", gender);
            param[3] = new SqlParameter("@eaddress", address);
            param[4] = new SqlParameter("@emobile", salary);

            cmd.Parameters.Add(param[0]);
            cmd.Parameters.Add(param[1]);
            cmd.Parameters.Add(param[2]);
            cmd.Parameters.Add(param[3]);
            cmd.Parameters.Add(param[4]);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();   // return the no of rows executed - works for insert,update, delete,create 
                Console.WriteLine("Data Insertion Success");

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




        }
    }
}
