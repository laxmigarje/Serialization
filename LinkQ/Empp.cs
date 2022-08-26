using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_Demo.LinkQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {City} ";
        }
        static void Main(string[] args)
        {

            List<Employee> lst = new List<Employee>()
            {
                new Employee{Id=1,Name="Manisha",Salary=15799,City="Pune"},
                new Employee{Id=2,Name="Abhijit",Salary=10699,City="Mumbai"},
                new Employee{Id=3,Name="Ashwini",Salary=34799,City="Delhi"},
                new Employee{Id=4,Name="Seema",Salary=45799,City="Satara"},
                new Employee{Id=5,Name="Neha",Salary=38799,City="Nashik"},
    };


            var output1 = from e in lst
                          select e;

            var output2 = from e in lst
                          orderby e.Name ascending
                          select e;

            var output3 = from e in lst
                          where e.Salary > 25000 
                          select e;


            var output4 = from e in lst
                          where e.City=="Pune"
                          select e;

            var output5 = from e in lst
                          orderby e. Salary descending
                          select e;
            var output6 = from e in lst
                          where e.Name.StartsWith("M")
                          select e;
            var output7 = from e in lst
                          where e.Salary>25000 &&  e.City.Contains ("Mumbai")
                          select e;

            foreach(Employee item in output6)
            {
                Console.WriteLine(item);
            }





            //Lambda Expression
          
          var res = lst.OrderBy(e => e.Name).ToList();
             var res1 = lst.Where(e => e.Salary > 25000).ToList();
            var res2 = lst.Where(e => e.City == "Pune").ToList();
            var res3 = lst.OrderBy(e => e.Salary).ToList();
             var res4 = lst.Where(e => e.City.StartsWith("P")).ToList();

            var res5 = lst.Where(e => e.Salary > 25000 && e.City == ("Mumbai")).ToList();




        }
    }
}