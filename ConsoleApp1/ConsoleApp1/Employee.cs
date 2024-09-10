using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Role
    {
        Admin = 1,
        Accountant,
        Stock,
        Reception
    }
    public struct Employee
    {
        public string Name { get; set; }
        public int Salary {  get; set; }
        public List<Role> Roles { get; set; }

        public Employee(string name,int salary)
        {
            Name = name;
            Salary = salary;
            Roles = new List<Role>();
        }
        public void display()
        {
            Console.WriteLine($"name of {Name} and salary is {Salary}");
            
            foreach (var role in Roles)
            {
                Console.WriteLine($"{role}");
            }

        }
        public void AssignRole(Role role)
        {
            if (!Roles.Contains(role))
            {
                Roles.Add(role);
                Console.WriteLine($"{Name} has been assigned the role of {role}");
            }
            else
            {
                Console.WriteLine($"{Name} already assigned the role of {role}");
            }
        }
        public bool HasRole(Role role)
        {
            return Roles.Contains(role);
        }

        //Employee e = new Employee("ali", 5000);
        //e.AssignRole(Role.Admin);
        //    e.AssignRole(Role.Stock);
        //    e.AssignRole(Role.Admin);
        //    e.display();
        //    e.HasRole(Role.Admin);


    }
}
