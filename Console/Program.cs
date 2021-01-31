using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                System.Console.WriteLine("ID: " + product.Id);
                System.Console.WriteLine("BrandID: " + product.BrandId);
                System.Console.WriteLine("ColorID: " + product.ColorId);
                System.Console.WriteLine("Model Year: " + product.ModelYear);
                System.Console.WriteLine("Daily Price: " + product.DailyPrice);
                System.Console.WriteLine("Description: " + product.Description);
                System.Console.WriteLine("-------------------------------------------");
            }

            
            System.Console.ReadLine();
        }

        static void List()
        {

        }
    }
}
