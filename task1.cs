using System.Globalization;

namespace Lab5
{
    internal class task1
    {
        static void Main(string[] args)
        {
            int intNumber;
            float floatNumber;
            float oldFloatNumber = 0f;
            string value;

            do
            {
                value = Console.ReadLine();

                if (int.TryParse(value, out intNumber))
                {
                    Console.WriteLine((char)intNumber);
                }
                else if (float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out floatNumber))
                {
                    if (floatNumber == oldFloatNumber)
                        break;

                    oldFloatNumber = floatNumber;
                }
            } while (value != "q");
        }
    }
}