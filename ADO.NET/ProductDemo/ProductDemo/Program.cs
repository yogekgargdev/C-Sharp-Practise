using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDBManager pd = new ProductDBManager();
            bool sts = true;
            while (sts)
            {
                int ch = pd.Menu();
                switch (ch)
                {
                    case 1:
                        pd.AddProduct();
                        break;
                    case 2:
                        pd.EditProduct();
                        break ;
                    case 3:
                        pd.RemoveProduct();
                        break;
                    case 4:
                        pd.FindProduct();
                        break;
                    case 5:
                        pd.ProductSummary();
                        break;
                    case 6:
                        sts = false;
                        break;
                        default:Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
