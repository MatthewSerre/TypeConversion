using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);

            try
            {
                var number = "1234";
                byte B = Convert.ToByte(number);
                Console.WriteLine(B);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                var str = "true";
                bool Bool = Convert.ToBoolean(str);
                Console.WriteLine(Bool);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
