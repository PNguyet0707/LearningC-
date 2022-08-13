using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacticInCSharp
{
    class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = NextId;
            NextId++;
        }
        public static int NextId;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";
    }
    class Program
    {
        static void Main(string[] args)    
        {
            Employee.NextId = 0;
            Employee employee1 = new Employee("Inigo", "Montoya");
            Employee employee2 = new Employee("Princess", "Buttercup");
            Console.WriteLine("{0} {1} ({2})", employee1.FirstName, employee1.LastName, employee1.Id);
            Console.WriteLine("{0} {1} ({2})", employee2.FirstName, employee2.LastName, employee2.Id);
            Console.WriteLine($"NextId = {Employee.NextId}");
            Console.ReadKey();
        }
        // ... khai báo của lớp Employee nằm đây, bỏ qua cho gọn code
    }
}
