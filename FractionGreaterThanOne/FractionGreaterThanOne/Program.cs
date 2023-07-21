using System.IO;

namespace FractionGreaterThanOne
{
    public class program
    {
        public static void Main(string[] args)
        {
                     
            Console.WriteLine("enter the fraction");
            string fraction1 = Console.ReadLine();
            IsFractionGreaterThanOne(fraction1);
            Console.WriteLine(IsFractionGreaterThanOne(fraction1) + "\n");

            Console.WriteLine("enter the fraction");
            string fraction2 = Console.ReadLine();
            IsFractionGreaterThanOne(fraction2);
            Console.WriteLine(IsFractionGreaterThanOne(fraction2) + "\n");

            Console.WriteLine("enter the fraction");
            string fraction3 = Console.ReadLine();
            IsFractionGreaterThanOne(fraction3);
            Console.WriteLine(IsFractionGreaterThanOne(fraction3) + "\n");
        }
        public static bool IsFractionGreaterThanOne(string fraction)
        {
            int numerator = 0;
            int denominator = 0;
            bool Numerator = true;

            for (int i = 0; i < fraction.Length; i++)
            {
                char c = fraction[i];

                if (c == '/')
                {
                    Numerator = false;
                    continue;
                }

                if (Numerator)
                {
                    numerator = numerator * 10 + (c - '0');
                }
                else
                {
                    denominator = denominator * 10 + (c - '0');
                }
            }

            if (denominator == 0)
            {
              
                return false;
            }
            return (double)numerator / denominator > 1;
        }
    }
}
