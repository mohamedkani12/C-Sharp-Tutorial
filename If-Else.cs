using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IFElse
{
    class If_Else
    {
        static void Main(String[] args)
        {
            int number1;
            Console.Write("Enter number1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            int number2;
            Console.Write("Enter number2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Value of "+number1+" X "+ number2 + ":" );
            int userValue = Convert.ToInt32(Console.ReadLine());
            int actualValue = number1 * number2;
            if (userValue == actualValue)
            {
                Console.WriteLine("You are correct");
            }
            else
            {
                Console.WriteLine("You are wrong");
            }
        }
    }
}
