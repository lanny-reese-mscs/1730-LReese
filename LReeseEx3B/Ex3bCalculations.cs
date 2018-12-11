using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LReeseEx3B
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }


            return futureValue;
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            double Celsius = 0.0;

            Celsius = (Fahrenheit - 32) * 5 / 9;

            return Celsius;
        }

        public static void CelsiusToFahrenheit(double Celsius, out double fahrenheit)
        {
            fahrenheit = (Celsius * 9 / 5) + 32;
        }

    public static decimal GrossPay(decimal Hours, decimal Rate)
        {
            decimal Pay = 0m;

            if (Hours <= 40m)
                Pay = Hours * Rate;
            if (Hours > 40m)
                Pay = (40m * Rate) + ((Hours - 40m) * 15m);

            return Pay;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            return total;
        }

        public static decimal GrossPay(string strNumbers, decimal Rate)
        {
            decimal totalHours = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                totalHours += number;
                startIndex = endIndex + 1;
            }

            decimal Pay = 0m;

            if (totalHours <= 40m)
                Pay = totalHours * Rate;
            if (totalHours > 40m)
                Pay = (40m * Rate) + ((totalHours - 40m) * 15m);

            return Pay;
        }
    }
}
