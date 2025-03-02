using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Looping
    {
        static void Main(String[] args)
        {
            Console.WriteLine("For Looping");
            Console.Write("Enter the message : ");
            string message = Console.ReadLine();
            Console.Write("How many times to repeat it : ");
            int loop = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < loop; i++)
            {
                Console.WriteLine(message+" "+(i+1));
            }
            Console.WriteLine("While Looping");
            int number1;
            Console.Write("Enter number1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            int number2;
            Console.Write("Enter number2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            int actualValue = number1 * number2;
            int answer = 0;
            while(actualValue!=answer){
                Console.Write("Value of " + number1 + " X " + number2 + ":");
                answer = Convert.ToInt32(Console.ReadLine());
                if(actualValue!=answer)
                    Console.WriteLine("Close,but it's Wrong");

            }
            Console.WriteLine("You are correct");
            Console.WriteLine("Do While Looping");
            int j = -3;
            do
            {
                Console.Write("enter Postive number to stop the loop : ");
                j = Convert.ToInt32(Console.ReadLine());
            } while (j <= 0);
           Console.WriteLine("Looping stopped");
        }
    }
}
