﻿namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] new_array = new string[numbers.Length];
            Array.Copy(numbers, new_array, numbers.Length);

            int intNumber;
            double doubleNumber;

            for (int i = 0; i < new_array.Length; i++)
            {
                if (int.TryParse(new_array[i], out intNumber))
                {
                    if (intNumber > 0)
                        new_array[i] = Factorial(intNumber);
                }
                else if (double.TryParse(new_array[i], out doubleNumber))
                {

                }
            }
        }

        static string Factorial(int n)
        {
            int fact = 1;

            for (int i = 2; i <= n; i++)
                fact *= i;

            return Convert.ToString(fact);
        }
    }
}