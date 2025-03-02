using System;
namespace ConvertDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age = 18;
            Console.WriteLine(age);
            long values = 900000000L;
            string bignumner = "900000000";
            long value1 = Convert.ToInt64(bignumner);
            Console.WriteLine(value1);
            Console.WriteLine(values);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            double negative = -52.362D;
            Console.WriteLine(negative);
            float fll = 5.000006F;
            string flo = "5.00006";
            float fl1 = Convert.ToSingle(flo);
            Console.WriteLine(fl1);
            Console.WriteLine(fll);
            string naee = "Mohamed";
            char initial = 'P';
            string textage = "23";
            int age1 = Convert.ToInt32(textage);
            Console.WriteLine(age1);
        }
    }
}
