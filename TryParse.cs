﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTryParse
{
    class TryParse
    {
        static void Main(String[] args)
        {
            bool success = true;
            while (success)
            {
                Console.Write("Enter a number :  ");
                string input = Console.ReadLine();
                if(int.TryParse(input,out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    const string message = "Invalid input, please enter a number";
                    Console.WriteLine(message);
                }
            }

            //table 
            int number;
            Console.Write("Enter a number for table : "); 
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",i,number,i*number);
            }
        }
    }
}
