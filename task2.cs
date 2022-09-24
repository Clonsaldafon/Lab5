namespace Lab5
{
    internal class task2
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().Replace("-", "");

            if (CheckingNumber(number))
            {
                Console.WriteLine(Sum(number));
            }
            else
            {
                Console.WriteLine("Not a number!");
            }
        }

        static bool CheckingNumber(string n)
        {
            bool isNumber = true;

            foreach (char s in n)
            {
                if (!char.IsDigit(s))
                    return false;
            }

            return isNumber;
        }

        static double Sum(string n)
        {
            double sum = 0;

            foreach (char s in n)
                sum += char.GetNumericValue(s);

            return sum;
        }
    }
}