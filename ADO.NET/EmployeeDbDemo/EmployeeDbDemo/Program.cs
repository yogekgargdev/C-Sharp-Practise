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
            string address = "Bangalore";
            float salary = 50000.0f;

            
            SqlConnection conn = null; // this is a connection object
            //conn = new SqlConnection("datasource=.;database=SoleraEmployees;intergrated security=true");
            //conn = new SqlConnection("Server=.;database=SoleraEmployees;user=sa;password=sa"); // this thing is also valid
            conn = new SqlConnection("server=.;database=SoleraEmployees;user id=sa;pwd=sa");
            // we can give connection details via constructor or via the props of conn
            //conn.ConnectionString="datasource=.;database=SoleraEmployees;user id=sa;pwd=sa" // this thing is also valid

            //string inStr = $"insert into Employee values({eid},'{ename}','{gender}','{address}',{salary})";

            //string updtStr = $"update Employee set ename='{ename}',gender='{gender}',eaddress='{address}',esalary='{salary}' where eid={eid}";

            //string delStr = $"delete from Employee where eid={eid}";
            //string sltSelect = "select * from Employee";
            string fltrsltSelect = "select * from Employee where eid=2";
            //SqlCommand cmd = new SqlCommand(inStr,conn);
            //SqlCommand cmd = new SqlCommand(updtStr, conn);
            //SqlCommand cmd = new SqlCommand(delStr, conn);
            //SqlCommand cmd = new SqlCommand(sltSelect, conn);
            SqlCommand cmd = new SqlCommand(fltrsltSelect, conn);
            //cmd.CommandText = inStr;
            //cmd.Connection=conn;

            SqlDataReader dr = null; 

            try
            {
                conn.Open();
                //cmd.ExecuteNonQuery();   // return the no of rows executed - works for insert,update, delete,create 
                //Console.WriteLine("Record Inserted Success!");
                //Console.WriteLine("Record Update Success!");
                //Console.WriteLine("Record Delete Success!");

                dr= cmd.ExecuteReader();    //-> dr acts as pointer
                Console.WriteLine("ID\tName\tGender\tAddress\t\tSalary");
                /*
                Console.WriteLine("------------------------------------------------------");
                while(dr.Read())
                {
                    //Console.WriteLine($"{dr.GetInt32(0)}\t{dr.GetString(1)}\t{dr.GetString(2)}\t{dr.GetString(3)}\t\t{dr.GetDouble(4)}"); 
                    //-> 0 stands for 0th Collumn, above thing is also valid
                    //Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}\t\t{dr[4]}"); // this is also valid
                    Console.WriteLine($"{dr["EID"]}\t{dr["EName"]}\t{dr["Gender"]}\t{dr["EAddress"]}\t\t{dr["ESalary"]}");
                }

                       Console.WriteLine("------------------------------------------------------");
                */

                if (dr.HasRows)
                {
                    //-> pointer is on 0 pointer, so increase to 1 otherwise data wont be acccessed
                    dr.Read();
                    Console.WriteLine($"{dr["EID"]}\t{dr["EName"]}\t{dr["Gender"]}\t{dr["EAddress"]}\t\t{dr["ESalary"]}\n");

                }

         
                Console.WriteLine("Data Retrieval Success");

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
