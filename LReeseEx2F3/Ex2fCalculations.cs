using System;

namespace LReeseEx2F3
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            //#1 if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = Convert.ToDecimal(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
          return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2 if {block}
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = Convert.ToDecimal(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
           return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = Convert.ToDecimal(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = Convert.ToDecimal(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = Convert.ToDecimal(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = Convert.ToDecimal(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else      //Customertype isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal etherium = 0.0m;

            if (input!= "")
            {
                decimal dollars = Convert.ToDecimal(input);
                etherium = dollars * 200;
                return etherium.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0m;
            if (inputA != "" && inputB !="")
            {
                decimal dollars = Convert.ToDecimal(inputA);
                decimal amount = Convert.ToDecimal(inputB);
                total = (dollars * amount);
                if(total >= 50)
                {
                    return total.ToString("n2");
                    
                }
                return (total + 5m).ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal metter1;
            decimal metter2;
            decimal total = 0.0m;

            if (inputA != "" && inputB != "")
            {
                metter1 = Convert.ToDecimal(inputA);
                metter2 = Convert.ToDecimal(inputB);
                if (metter1 < metter2)
                {
                    total = (metter2 - metter1);
                    return (total * .10m).ToString("n2");
                }
                return "Invalid input";
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal number1;
            decimal number2;
            decimal total = 0.0m;

            if (inputA != "" && inputB != "")
            {
                number1 = Convert.ToDecimal(inputA);
                number2 = Convert.ToDecimal(inputB);
                if (number1 >0 && number2 >0)
                {
                    if (number1 >= number2)
                    {
                        total = number1 / number2;
                        return total.ToString("n2");
                    }
                    if(number1 <= number2)
                    {
                        total = number2 / number1;
                        return total.ToString("n2");
                    }
                    return "Invalid input";
                }
                return "Invalid input";
            }
            return "Invalid input";
        }
    }
}
