using MyFirstCodeOOP;
using System;


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


                Console.WriteLine("************************");
                Console.WriteLine("**** SALARY EMPLOYEE ****");
                Console.WriteLine("**************************");

                Console.WriteLine(" Type your Id");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Type your first name ");
                String firstName  = (Console.ReadLine());

                Console.WriteLine(" Type your last name ");
                String lastName = (Console.ReadLine());

                Console.WriteLine(" Type your active");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine(" Type your salary");
                decimal salary = Convert.ToDecimal(Console.ReadLine());


                Employee salaryEmployee = new SalaryEmployee()

                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year),Convert.ToInt32(month),Convert.ToInt32(day)),
                    HiringDate = new Date (2022,3,4),
                    IsActive = isActive,
                    Salary = salary
                };
                Console.WriteLine(salaryEmployee);
                Console.WriteLine();


                Console.WriteLine("************************");
                Console.WriteLine("**** SALARY EMPLOYEE ****");
                Console.WriteLine("**************************");

                Console.WriteLine(" Type your Id");
                 id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Type your first name ");
                 firstName = (Console.ReadLine());

                Console.WriteLine(" Type your last name ");
                 lastName = (Console.ReadLine());

                Console.WriteLine(" Enter your commission percentage:");
                 float commisionpercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine(" Enter your sales:");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmploye = new commissionEmployee()

                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commisionpercentage,
                    Sales = salary
                };
                Console.WriteLine(commissionEmploye);



            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
