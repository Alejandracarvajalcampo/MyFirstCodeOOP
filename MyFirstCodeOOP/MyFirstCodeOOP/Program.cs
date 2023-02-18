using MyFirstCodeOOP;
using System;
using System.Linq.Expressions;

namespace MyFirtsCodeOPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please put your year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Please put your month:");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Please put your day: ");
                int day = int.Parse(Console.ReadLine());

                var dateObject = new Date(year, month, day);
                Console.WriteLine(dateObject);


                Console.WriteLine("******Testing latest implementation******");

                Employee salaryEmployee = new SalaryEmployee()

                {
                    Id = 1000,
                    FirstName = "Maria",
                    LastName = "Posada",
                    BirthDate = new Date( 19950,2,5),
                    HiringDate = new Date (2022,12,31),
                    IsActive = true,
                    Salary = 200000.34M
                };
                Console.WriteLine(salaryEmployee);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
