using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class HelperUtility
    {
        internal static double CalculateYearlywage(int ratePerHour, int numberOfHoursWorked)
        {
            double currentMonthWage = ratePerHour * numberOfHoursWorked;
            double currentYearWage = currentMonthWage * 12;
            return currentYearWage;
        }

        /// <summary>
        /// Expression bodied method
        /// </summary>
        /// <param name="ratePerHour"></param>
        /// <param name="numberOfHoursWorked"></param>
        /// <returns></returns>
        internal static double CalculateYearlywagewithExpressionBodiedMethod(int ratePerHour, int numberOfHoursWorked) 
            => ratePerHour * numberOfHoursWorked * 12;


        /// <summary>
        /// same name method with additional parameter
        /// </summary>
        /// <param name="ratePerHour"></param>
        /// <param name="numberOfHoursWorked"></param>
        /// <param name="bouns"></param>
        /// <returns></returns>
        internal static double CalculateYearlywage(int ratePerHour, int numberOfHoursWorked, int bouns)
        {
            return CalculateYearlywage(ratePerHour, numberOfHoursWorked) + bouns;
        }

        /// <summary>
        /// same name method with different parameters types
        /// </summary>
        /// <param name="ratePerHour"></param>
        /// <param name="numberOfHoursWorked"></param>
        /// <param name="bouns"></param>
        /// <returns></returns>
        internal static double CalculateYearlywage(int ratePerHour, int numberOfHoursWorked, double bouns)
        {
            return CalculateYearlywage(ratePerHour, numberOfHoursWorked) + bouns;
        }
    }
}
