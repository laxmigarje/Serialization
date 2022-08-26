using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_Demo.LinkQ
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string CompanyName { get; set; }
        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Price} -> {CompanyName}";
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM4GB",Price=2799,CompanyName="Intel"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name=" USBMouse",Price=1299,CompanyName="Dell"},
            };

            var result1 = from p in product
                          select p;

            var result2 = from p in product
                          where p.Price < 2000
                          select p;

            var result3 = from p in product
                          where p.Price > 2000 && p.Price < 3000
                          select p;

            
            var result4 = from p in product
                          where p.CompanyName.StartsWith("D")
                          select p;

            foreach(Product item in result3 )
            {
                Console.WriteLine(item);
            }




        }
    }
}
