namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numone = 5;
            int numtwo = 6;
            Console.WriteLine(Add(numone, numtwo));

            double decone = 5.5;
            double dectwo = 7.5;
            Console.WriteLine(Add(decone, dectwo));

            int intone = 5;
            int inttwo = 6;
            bool boolone = true;
            Console.WriteLine(Add(intone, inttwo, boolone));
        }

        static int Add(int numone, int numtwo)
        {
            return numone + numtwo;
        }

        static double Add(double decone, double dectwo)
        {
            return decone + dectwo;
        }

        static string Add(int intone, int inttwo, bool boolone)
        {
            int sum = 0;
            if (boolone == true)
            {
                sum = intone + inttwo;
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return "Couldn't add two numbers";
            }
        }
    }
}
