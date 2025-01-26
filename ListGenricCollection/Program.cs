using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenricCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee()
            {
                Names="aayush",
                Age=15,
                Designation="Manager"
            };

            Employee emp2 = new Employee()
            {
                Names = "Kumar",
                Age = 11,
                Designation = "Assitent"
            };

            Employee emp3 = new Employee()
            {
                Names = "Mandal",
                Age = 20,
                Designation = "operator"
            };

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp1);
            emplist.Add(emp1);
            emplist.Add(emp3);

            foreach (Employee emp in emplist)
            {
                Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);
            }

         //   List<int> mynumbers = new List<int>();
         //   mynumbers.Add(11);
         //   mynumbers.Add(22);
         //   mynumbers.Add(33);
         //   mynumbers.Add(44);
         //   mynumbers.Add(55);
         //   mynumbers.Add(66);
         //   mynumbers.Add(77);
         //   mynumbers.Add(88);
         //   //foreach (int item in mynumbers)
         //   //{
         //   //    Console.WriteLine(item);
         //   //}
         ////  Console.WriteLine("---------------------------");
         //   List<string> names = new List<string>();
         //   names.Add("Aayush");
         //   names.Add("Kumar");
         //   names.Add("Mandal");
         //   //foreach(string a in names)
         //   //{
         //   //    Console.WriteLine(a);
         //   //}
    











            //mynumbers.Add(99);
            //mynumbers.Add(100);
            //mynumbers.Add(200);
            //mynumbers.Add(300);
            //Console.WriteLine(mynumbers.Capacity);
            //mynumbers.Add(11000);
            //mynumbers.Add(300);

            //Console.WriteLine(mynumbers.Capacity);



            Console.ReadLine();


        }
    }
}
