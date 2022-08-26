using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace MyNewProject1.Serialization
{
    [Serializable]
    public class Product3
    {
        int productid;
        string productname;
        int price;

        public int Productid { get => productid; set => productid = value; }
        public string Productname { get => productname; set => productname = value; }
        public int Price { get => price; set => price = value; }
    }
    class JsonSerializationAssignment
    {
        static void JsonSerializationWrite(Product3 prod)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Product3>(fs, prod);

                Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Product3 prod = JsonSerializer.Deserialize<Product3>(fs);
                Console.WriteLine(prod.Productid);
                Console.WriteLine(prod.Productname);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Product3 prod = new Product3 { Productid = 4, Productname = "Scooter", Price = 40000 };
            JsonSerializationWrite(prod);
            JsonSerializationRead();
            Console.ReadLine();
        }
    }
}





