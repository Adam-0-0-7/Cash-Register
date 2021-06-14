using System;

namespace Ex_C_Ch_4_Cash_Register__Part_3_of_5_
{
    class Program
    {
        private static double payment;
        private static double purchase;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter purchase amount:");
                purchase = double.Parse(Console.ReadLine());
                while (purchase <= 0)
                {
                    Console.WriteLine("Please re-enter purchase amount:");
                    purchase = double.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please re-enter purchase amount:");
                purchase = double.Parse(Console.ReadLine());
            }
            try
            {
                Console.WriteLine("Please enter payment amount:");
                payment = double.Parse(Console.ReadLine());
                while (payment <= 0)
                {
                    Console.WriteLine("Please re-enter payment amount:");
                    payment = double.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter payment amount:");
                payment = double.Parse(Console.ReadLine());
            }
            double changeDue = payment - purchase;
            while (changeDue < 0)
            {
                Console.WriteLine("The payment amount is not enough to cover the purchase amount.");
                Console.WriteLine("Please enter purchase amount:");
                purchase = double.Parse(Console.ReadLine());
                while (purchase <= 0)
                {
                    Console.WriteLine("Please re-enter purchase amount:");
                    purchase = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Please enter payment amount:");
                payment = double.Parse(Console.ReadLine());
                while (payment <= 0)
                {
                    Console.WriteLine("Please re-enter payment amount:");
                    payment = double.Parse(Console.ReadLine());
                }
                changeDue = payment - purchase;
            }
            if (changeDue == 0)
            {
                Console.WriteLine("The payment amount is exactly correct.");
            }
            else if (changeDue > 0)
            {
                Console.WriteLine($"Change due:${changeDue}");

                int twenties = (int)(changeDue / 20);
                if (twenties == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$20 = " + twenties);
                }
                changeDue = Math.Round(changeDue % 20.0f, 2);
                int tens = (int)(changeDue / 10);
                if (tens == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$10 = " + tens);
                }
                changeDue = Math.Round(changeDue % 10.0f, 2);
                int fives = (int)(changeDue / 5);
                if (fives == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$5 = " + fives);
                }
                changeDue = Math.Round(changeDue % 5.0f, 2);
                int ones = (int)(changeDue / 1);
                if (ones == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$1 = " + ones);
                }
                changeDue = Math.Round(changeDue % 1.0f, 2);
                int quarters = (int)(changeDue / 0.25);
                if (quarters == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$0.25 = " + quarters);
                }
                changeDue = Math.Round(changeDue % 0.25f, 2);
                int dimes = (int)(changeDue / 0.10);
                if (dimes == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$0.10 = " + dimes);
                }
                changeDue = Math.Round(changeDue % 0.10f, 2);
                int nickels = (int)(changeDue / 0.05);
                if (nickels == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$0.05 = " + nickels);
                }
                changeDue = Math.Round(changeDue % 0.05f, 2);
                int pennies = (int)(changeDue / 0.01);
                if (pennies == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("$0.01 = " + pennies);
                }
            }
        }
    }
}
