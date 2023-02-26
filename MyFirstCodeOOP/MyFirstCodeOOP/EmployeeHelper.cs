using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP.Helper
{
    public class EmployeeHelper
    {
        #region Fields

        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _contractorEmployee;
        private Employee _basecommissionEmployee;

        #endregion

        #region Methods
        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee, Employee ContractorEmployee, Employee BaseCommissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _contractorEmployee = ContractorEmployee;
            _basecommissionEmployee = BaseCommissionEmployee;
        }
        public decimal GetPayrollFromActiveEmployees()
        {
            ICollection<Employee> employes = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _contractorEmployee,
                    _basecommissionEmployee,
                };

            decimal payrrol = 0;

            foreach (Employee employee in employes)
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine("");
                    payrrol += employee.GetValueToPay();
                }
            }
            return payrrol;
            #endregion
        }
    }
}

