using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class BaseCommissionEmployee :commissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return ((Sales * (decimal)ConvertPercentage(CommissionPercentage))+ Base);
        }
        public override string ToString()
        {
            return $"{base.ToString()};" +
              $"\n\tSalary Base....{Base:C2}" +
              $"\n\t Value to pay...........{GetValueToPay():C2}";
        }
        #endregion
    }
}
