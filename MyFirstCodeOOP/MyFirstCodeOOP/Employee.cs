using MyFirtsCodeOPP;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public abstract class Employee
    {

        #region  Properties
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public Date BirthDate { get; set; }

        public Date HiringDate { get; set;}

        public Boolean IsActive { get; set;}

        #region Methods

        public abstract decimal GetValueToPay();


        public override string ToString()
        {
            return string.Format($"---EMPLOYEE---\n\t" +
                " Id:{0}\n\t" +
                " FirstName:{1} \n\t" +
                " LastName:{2} \n\t" +
                " BirthDate:{3} \n\t" +
                " HiringDate:{4} \n\t " +
                "IsActive:{5}",
                Id,
               FirstName,
               LastName,
               BirthDate,
               HiringDate,
               IsActive);
            
            


            //return $"---EMPLOYEE---\n\t" +
              //  $" ID:{Id}" +
                //$" \n\t FirstName:{FirstName} " +
                //$"\n\t LastName:{LastName} " +
                //$"\n\t BirthDate:{BirthDate} " +
                //$"\n\t HiringDate:{HiringDate}" +
                //$"\n\t IsActive:{IsActive}";


        }
        #endregion
        #endregion



    }
}
