using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Demo
{    //Write a program to initialize 5 employees details using array & display using foreach loop
    class Employee
    {
        int id;
        string name;
        int age;
      

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] Emplist = new Employee[5]
            {
                  
                new Employee{Id=1,Name="Vaibhav",Age=22},
                new Employee{Id=2,Name="Ram",Age=23},
                new Employee{Id=3,Name="Ram",Age=25},
                new Employee{Id=4,Name="Akshya",Age=22},
                new Employee{Id=5,Name="Ajinkay",Age=21},
            };

            foreach(Employee aa in Emplist)
            {
                Console.WriteLine($"{aa.Id} {aa.Name} {aa.Age}");
            }


        }
    }
}
