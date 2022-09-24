namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().Replace("-", "");

            if (CheckingNumber(number))
            {
                
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
    }
}