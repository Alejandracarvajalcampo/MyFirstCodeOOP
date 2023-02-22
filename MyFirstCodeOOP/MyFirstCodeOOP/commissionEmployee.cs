using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class commissionEmployee : Employee
    {
        #region Properties

        public float CommissionPercentage { get; set; } 
        public decimal Sales { get; set; }  

        #endregion

        #region Mtehosd
        public override decimal GetValueToPay()
        {
            return Sales * (decimal) ConvertPercentage(CommissionPercentage) ;  
        }

        public override string ToString()
        {
            return $"{base.ToString()};" +
                $"\n\tCommssion Percentage....{ConvertPercentage(CommissionPercentage):P2}" +
                $"\n\t Sales..................{Sales:C2}" +
                $"\n\t Value to pay...........{GetValueToPay():C2}";
        }
        public float ConvertPercentage(float commissionPercenatge)
        {
            return (commissionPercenatge / 100);                
        }

        #endregion
    }
}
    


