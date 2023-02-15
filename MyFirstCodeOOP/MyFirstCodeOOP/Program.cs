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
                Console.Write("Ingrese el año: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el mes: ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el día: ");
                int day = int.Parse(Console.ReadLine());

                var dateObject = new Date(year, month, day);
                Console.WriteLine(dateObject);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
