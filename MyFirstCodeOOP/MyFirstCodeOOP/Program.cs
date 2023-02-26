using MyFirstCodeOOP;
using MyFirstCodeOOP.Helper;
using System;
using System.Collections.Generic;

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
                String firstName = (Console.ReadLine());

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
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    Salary = salary
                };
                //Console.WriteLine(salaryEmployee);
                Console.WriteLine();


                Console.WriteLine("************************");
                Console.WriteLine("**** COMMISSION EMPLOYEE ****");
                Console.WriteLine("**************************");

                Console.WriteLine(" Type your Id");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Type your first name ");
                firstName = (Console.ReadLine());

                Console.WriteLine(" Type your last name ");
                lastName = (Console.ReadLine());

                Console.WriteLine(" Type your active");
                isActive = Convert.ToBoolean(Console.ReadLine());

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
                //Console.WriteLine(commissionEmploye);
                Console.WriteLine();

                Console.WriteLine("************************");
                Console.WriteLine("**** CONTRACTOR EMPLOYEE ****");
                Console.WriteLine("**************************");

                Console.WriteLine(" Type your Id");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Type your first name ");
                firstName = (Console.ReadLine());

                Console.WriteLine(" Type your last name ");
                lastName = (Console.ReadLine());

                Console.WriteLine(" Type your active");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine(" Enter your number of hours:");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine(" Enter your svalue per hour:");
                decimal hoursValue = Convert.ToDecimal(Console.ReadLine());

                Employee contractorEmployee = new ContractorEmployee()

                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hoursValue
                };
                //Console.WriteLine(contractorEmployee);
                Console.WriteLine();

                Console.WriteLine("*************************************");
                Console.WriteLine("**** BASE & COMMISSION EMPLOYEE ****");
                Console.WriteLine("**************************");

                Console.WriteLine(" Type your Id");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Type your first name ");
                firstName = (Console.ReadLine());

                Console.WriteLine(" Type your last name ");
                lastName = (Console.ReadLine());

                Console.WriteLine(" Type your active");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine(" Enter your commission percentage:");
                commisionpercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine(" Enter your sales:");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine(" Enter your svalue per hour:");
                decimal salaryBase = Convert.ToDecimal(Console.ReadLine());

                Employee baseCommissionEmploye = new BaseCommissionEmployee()

                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commisionpercentage,
                    Sales = sales,
                    Base = salaryBase,

                };
                //Console.WriteLine(baseCommissionEmploye);

                EmployeeHelper employeeHelper = new EmployeeHelper(salaryEmployee, commissionEmploye, contractorEmployee, baseCommissionEmploye);


                Console.WriteLine($"total payrrol:..........{employeeHelper.GetPayrollFromActiveEmployees():C2}");


                Console.WriteLine("*****************");
                Console.WriteLine("**** INVOICE ****");
                Console.WriteLine("******************");

                Invoice invoice = new Invoice()
                {
                    Id = 201205,
                    Description = "iphone 13",
                    Price = 4500000,
                    Quantity = 2,



                };

                Console.WriteLine(invoice);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
