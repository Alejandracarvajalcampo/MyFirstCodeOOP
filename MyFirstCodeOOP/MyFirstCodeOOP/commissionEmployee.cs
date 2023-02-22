using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class commissionEmployee : Employee
    {
        #region Properties

        public float CommissionPorcentage { get; set; } 
        public decimal Sales { get; set; }  

        #endregion

        #region Mtehosd
        public override decimal GetValueToPay()
        {
            return Sales * (decimal) CommissionPorcentage;  
        }

        public override string ToString()
        {
            return $"{base.ToString()};\n\tCommssion Percentage....{CommissionPorcentage}:P2
        }
    }
    #endregion
}

