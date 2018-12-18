using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LReeseEx3C
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            if (index >= 1 && index <= 7)
            {
               
                string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                index = index - 1;
                string day = days[index];

                return day;
            }
            return "Invalid index";
        }

        public static string Calc1(string search)
        {
                search = search.Trim();
                search = search.ToUpper();
                string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
                string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
                int index = Array.IndexOf(days, search);
                
            if (index >= 0)
            {
                string open = hours[index];
                return open;
            }
            else
                return "Invalid input";
           
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
                sum += total;
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            for (int i = 0; i < count; i++)
                sum += numbers[i];
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.0;
            int length = numbers.GetLength(0);
            sum = Calc3(numbers, length);
            sum = sum / length;
            return sum;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);

                foreach (int number in numbers)
                {
                    if (number >= avg)
                        aboveAvgList.Add(number);
                }
            }
                return aboveAvgList.ToArray();
        }
    }
}
