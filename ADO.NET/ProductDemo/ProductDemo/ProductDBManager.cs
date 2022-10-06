using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo
{
    public class ProductDBManager
    {
        DemoComp dc = null;
        public ProductDBManager()
        {
            dc = new DemoComp();

            dc.sqlDataAdapter1.Fill(dc.stockDataset1);
        }

        public int Menu()
        {
            Console.WriteLine("1.New Product");
            Console.WriteLine("2.Edit Product");
            Console.WriteLine("3.Delete Product");
            Console.WriteLine("4.Find Product");
            Console.WriteLine("5.List Product");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Plase enter your choice");

            int ch = int.Parse(Console.ReadLine());
            return ch;

        }

        public void AddProduct()
        {
            int pid;
            string pname;
            float price;
            int qty;

            Console.WriteLine("Enter Product id\t:\t");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name\t:\t");
            pname = Console.ReadLine();
            Console.WriteLine("Enter product price\t:\t");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Quantity\t:\t");
            qty = int.Parse(Console.ReadLine());

            DataRow dr = dc.stockDataset1.Tables[0].NewRow();
            dr[0] = pid;
            dr[1] = pname;
            dr[2] = price;
            dr[3] = qty;
            dc.stockDataset1.Tables[0].Rows.Add(dr);
            dc.sqlDataAdapter1.Update(dc.stockDataset1);
            Console.WriteLine("Record Inserted Successfully");
        }
        public void EditProduct()
        {
            int pid;
            string pname;
            float price;
            int qty;

            Console.WriteLine("Enter Product id\t:\t");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name\t:\t");
            pname = Console.ReadLine();
            Console.WriteLine("Enter product price\t:\t");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Quantity\t:\t");
            qty = int.Parse(Console.ReadLine());

            DataRow dr = dc.stockDataset1.Tables[0].Rows.Find(pid);
            if (dr != null)
            {
                dr[1] = pname;
                dr[2] = price;
                dr[3] = qty;

                dc.sqlDataAdapter1.Update(dc.stockDataset1);
                Console.WriteLine("Record Updated Successfully");
            }
            else
            {
                Console.WriteLine("Record not found to Update");
            }
        }
        public void RemoveProduct()
        {
            int pid;
           

            Console.WriteLine("Enter Product id\t:\t");
            pid = int.Parse(Console.ReadLine());
            

            DataRow dr = dc.stockDataset1.Tables[0].Rows.Find(pid);
            if (dr != null)
            {

                dr.Delete();
                dc.sqlDataAdapter1.Update(dc.stockDataset1);
                Console.WriteLine("Record Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
        public void FindProduct()
        {
            int pid;


            Console.WriteLine("Enter Product id\t:\t");
            pid = int.Parse(Console.ReadLine());
            

            DataRow dr = dc.stockDataset1.Tables[0].Rows.Find(pid);
            if (dr != null)
            {
                Console.WriteLine("ID\tName\tPrice\tQuantity");
                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                Console.WriteLine("_______________________________________________________________________");

                Console.WriteLine("Record  Found Successfully");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
        }
        public void ProductSummary()
        {
          
            if (dc.stockDataset1.Tables[0].Rows.Count>0)
            {
                Console.WriteLine("ID\tName\tPrice\tQuantity");
                Console.WriteLine("______________________________________________________________________");
                foreach(DataRow dr in dc.stockDataset1.Tables[0].Rows)
                {
                    Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                }
                Console.WriteLine("_______________________________________________________________________");

                Console.WriteLine("Record  Found Successfully");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
        }
    }
}
