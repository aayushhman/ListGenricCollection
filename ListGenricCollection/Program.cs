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
                Names = "aayush",
                Age = 15,
                Designation = "Manager"
            };

            Employee emp2 = new Employee()
            {
                Names = "Kumar",
                Age = 22,
                Designation = "Assitent"
            };

            Employee emp3 = new Employee()
            {
                Names = "Mandal",
                Age = 21,
                Designation = "operator"
            };

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp1);
            emplist.Add(emp2);
            emplist.Add(emp3);





            Employee[] emps = emplist.ToArray();
            foreach (Employee emp in emps)
            {
                   Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);                                                         

            }
            List<Employee> myemps = emps.ToList();
            Console.WriteLine("----------------------------------");
            foreach (Employee emp in myemps)
            {
                    Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);

            }
            //  Console.WriteLine(emplist.FindLastIndex(emp => emp.Age > 20));
            //List<Employee> emps = emplist.FindAll(e => e.Age > 20);
            //foreach (Employee emp in emps)
            //{
            //    Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);

            //}

            //Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);                                                                                

            //Console.WriteLine(emplist.Exists(emp => emp.Names.StartsWith("a")));




            //Employee emp = emplist.Find(e => e.Age > 20);
            //    Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);                                                                                

            //foreach (Employee emp in emplist)
            //{
            //    Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);
            //}
            //emplist.RemoveAll(emp => emp.Age>20);
            //Console.WriteLine("----------------------------------------");
            //foreach (Employee emp in emplist)
            //{
            //    Console.WriteLine("Employee name is:{0} age is :{1} designation is:{2}", emp.Names, emp.Age, emp.Designation);
            //}

            //List<int> mynumbers = new List<int>();
            //mynumbers.Add(55);//0
            //mynumbers.Add(11);//1
            //mynumbers.Add(44);//2
            //mynumbers.Add(33);//3
            //mynumbers.Add(22);//4
            //mynumbers.Add(33);//5


            //Console.WriteLine(mynumbers.IndexOf(33,4));
            //Console.WriteLine(mynumbers.Contains(44));
            //// Console.WriteLine(mynumbers.Count);
            //foreach (int item in mynumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //  mynumbers.Sort();
            //mynumbers.AddRange(mynumbers);
            // mynumbers.Insert(1, 10);
            // mynumbers.InsertRange(3, mynumbers);
            //mynumbers.Remove(33);
            // mynumbers.RemoveAt(3);
            //mynumbers.RemoveRange(2, 2);

            //mynumbers.Reverse();
            //Console.WriteLine("---------------------------");

            //foreach (int item in mynumbers)
            //{
            //    Console.WriteLine(item);
            //}
            // Console.WriteLine(mynumbers.Count);

            //List<string> names = new List<string>();
            //names.Add("aayush");
            //names.Add("kumar");
            //names.Add(null);
            //names.Add("Kumar");
            //names.Add("mandal");
            //foreach(string a in names)
            //{
            //    Console.WriteLine(a);
            //}


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
