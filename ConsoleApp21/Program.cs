using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Employee
    {
      
        public string name { get; set; }
        public double salary { get; set; }

        public int id;
        public static int  count=0;

        public Employee()
        {
            count++;
            id = count;
        }
            

    }
    public class Department
    {
        public string dept { get; set; }
        public List<Employee> emp = new List<Employee>();
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            List<Department> Dept = new List<Department>()
           {
               new Department{dept="production",
                   emp =
                   {
                       new Employee{name="rahul dalwale",salary=25000},
                       new Employee{name="Mahesh deokar",salary=45000},
                       new Employee{name="Manish vaze",salary=49000},
                       new Employee{name="akash hazare",salary=47000},
                       new Employee{name="Omkar yenpure",salary=48000},

                   }
               },
               new Department{dept="HR",
                   emp =
                   {
                       new Employee{name="mahesh Jadhav",salary=25000},
                       new Employee{name="Mangesh Jadhav",salary=45000},
                       new Employee{name="Anil jadhav",salary=49000},
                       new Employee{name="Sid Cinke",salary=47000},
                       new Employee{name="Omkar Balkavde",salary=48000},
                   }
               }
           };

            foreach(Department de in Dept)
            {
                Console.WriteLine($"DEPT={de.dept}");
                foreach(Employee e in de.emp)
                {
                    Console.WriteLine($" Empid={e.id} Name={e.name} Ned paid={e.salary}");
                }
            }
        }
    }
}
