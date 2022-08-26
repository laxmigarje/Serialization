using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_Demo.Lambda_Expression
{
    public class Program2
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



            // Lambda expression
            var res = products.Where(p => p.Price < 2000).ToList();
    var res2 = products.Where(p => p.Price > 2000).OrderBy(x => x.Name).ToList();
    // retrive single record
    var res4 = products.Where(x => x.Id == 1).SingleOrDefault();
    var res3 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Take(3);

    var res3 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Skip(3);


}
