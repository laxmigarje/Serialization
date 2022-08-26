using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyNewProject1.Serialization
{
    [Serializable]
    class Product
    {
        int productid;
        string productname;
        int price;

        public int Productid { get => productid; set => productid = value; }
        public string Productname { get => productname; set => productname = value; }
        public int Price { get => price; set => price = value; }
    }
    class AssignmentSerialization
    {
        static void BinarySerializationwrite(Product prod)
        {
            try
            {

                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\BinaryFileAssignment.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, prod);
                Console.WriteLine("Binary data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"d:\Dotnetcore\FileFolder\BinaryFileAssignment.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Product prod = (Product)bf.Deserialize(fs);
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
            Product prod = new Product { Productid = 1, Productname = "Mobile", Price = 10000 };
            BinarySerializationwrite(prod);
            BinarySerializationRead();
            Console.ReadLine();

        }
    }
}



