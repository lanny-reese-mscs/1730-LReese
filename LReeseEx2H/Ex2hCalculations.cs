using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LReeseEx2H
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string stryear, string strmonth, string strday)
        {
           string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(stryear);
                int month = Int32.Parse(strmonth);
                int day = Int32.Parse(strday);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string d1,string d2)
        {
            string result = "Invalid input";
            DateTime StartDate;
            DateTime EndDate;
            TimeSpan Difference;

            try {
            StartDate = Convert.ToDateTime(d2);
            EndDate = Convert.ToDateTime(d1);

            Difference = EndDate.Subtract(StartDate);

            result = Convert.ToString(Difference.Days);
            }
            catch { }

            return result + " days";
        }
        public static string DateCalc10(string endDate, string strDate)
        {
            string result = "Invalid input";
            DateTime StartDate;
            DateTime EndDate;
            TimeSpan Difference;

            try
            {
                    StartDate = Convert.ToDateTime(strDate);
                    EndDate = Convert.ToDateTime(endDate);

                    Difference = EndDate.Subtract(StartDate);

                    result = Convert.ToString(Difference.Days) + " days past due";
             
                
            }
            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            String r;
            String u;
            try
            {
                s = s.Replace(" ", "");
                r = s.Remove(0, 1);
                u = "cr";
                string t = u.Insert(u.Length, r);
                result = t;
                
            }
            catch { }
            return result;
        }

        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            String r;
            String u;
            try
            {
                s = s.Replace(" ", "");
                r = s.Remove(1,1);
                u = "rit";
                string t = r.Insert(1, u);
                result = t;


            }
            catch { }
            return result;
        }

        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Replace(" ", "");
                string r = s.Substring(2, 4).ToUpper();

                result = r;
            }
            catch { }
            return result;
        }

        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Replace(" ", "");
                string r = s.PadLeft(10, '*');

                result = r;
            }
            catch { }
            return result;
        }

        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
               s = s.Replace("-", "");
                s = s.Replace(" ", "");

                result = s;
            }
            catch { }
            return result;
        }

        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Replace(" ", "");
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace("-", "");
                s = s.Replace(" ", "");
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");

                result = s;
            }
            catch { }
            return result;
        }

        public static string StringCalc07(string s)
        {
            string result = "Not found";
            try
            {
                s= s.ToLower();
                if (s.Contains("pioneer"))
                {
                    result = "Found";
                }
            }
            catch { }
            return result;
        }

        public static string StringCalc08(string s)
        {
            string result = "Invalid input";
            try
            {
                if (s.Contains(","))
                {
                    int index1 = s.IndexOf(",");
                    s = s.Remove(0, index1 + 1);
                    s = s.Replace(" ", "");
                    result = s;
                }
            }
            catch { }
            return result;
        }

        public static string StringCalc09(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                if (s.Contains(" "))
                {

                    int L = s.LastIndexOf(" ");
                    s = s.Remove(0, L + 1);

                    result = s;
                }
            }
            catch { }
            return result;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1 + ", " + s2 + ", " + s3);
            
            return  sb.ToString();
        }
    }
}