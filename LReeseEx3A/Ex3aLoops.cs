using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LReeseEx3A
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int Months = Int32.Parse(strMonths);
                double MonthlyPayment = Double.Parse(strMonthlyPayment);
                double MonthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= Months)
                {
                    futureValue = (futureValue + MonthlyPayment) * (1 + MonthlyInterestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }


            return futureValue.ToString("n2");
        }

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int Months = Int32.Parse(strMonths);
                double MonthlyPayment = Double.Parse(strMonthlyPayment);
                double MonthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + MonthlyPayment) * (1 + MonthlyInterestRate);
                    i++;
                }
                while (i <= Months);
            }
            catch
            {
                return "Invalid input";
            }


            return futureValue.ToString("n2");
        }
        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int Months = Int32.Parse(strMonths);
                double MonthlyPayment = Double.Parse(strMonthlyPayment);
                double MonthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                for(int i =1; i <= Months; i++)
                {
                    futureValue = (futureValue + MonthlyPayment) * (1 + MonthlyInterestRate);
                }
            }
            catch
            {
                return "Invalid input";
            }


            return futureValue.ToString("n2");
        }
        
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                if (Increment <= 0) throw new Exception();
        
                    int i = Start;
                    while (i < End)
                    {
                        result += i + " ";
                        i += Increment;
                    }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }
public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                if (Increment <= 0) throw new Exception();

                int i = Start;
                do
                {
                     result += i + " ";
                     i += Increment;
                }
                while (i < End);
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
            
        }
        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                if (Increment <= 0) throw new Exception();

                for(int i = Start; i <=End; i +=Increment)
                {
                    result += i + " ";
                } 
            }
            catch
            {
                result = "Invalid input";
            }
            return result;

        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;

            try
            {
                int Count = Int32.Parse(strCount), sum = 0;
                int i = 1;
                while (i <= Count)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);

                    startIndex = endIndex + 1;
                    sum += number;
                    i+=1;
                }
               
                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;

            try
            {
                int Count = Int32.Parse(strCount), sum = 0;
                int i = 1;
                do
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);

                    startIndex = endIndex + 1;
                    sum += number;
                    i += 1;
                }
                while (i <= Count);
                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;

            try
            {
                int Count = Int32.Parse(strCount), sum = 0;
                for (int i = 1; i <= Count; i += 1)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);

                    startIndex = endIndex + 1;
                    sum += number;
                }

                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }
    }
}
