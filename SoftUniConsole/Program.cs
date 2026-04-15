using Microsoft.EntityFrameworkCore;
using SoftUniConsole.Data.Models;

namespace SoftUniConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<SoftUniContext>()
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SoftUni;TrustServerCertificate=False;Integrated Security=True;")
                .Options;

           using var db = new SoftUniContext(options);



            var employees = db.Employees.Take(10).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Salary}");
            }


        }
    }
}
