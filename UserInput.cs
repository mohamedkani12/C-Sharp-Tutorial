using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GettingInputFromUser
{
    class UserInput
    {
        static void Main(String[] args)
        {
            int age;
            Console.Write("Enter age :");
            age = Convert.ToInt32(Console.ReadLine());
            string name;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Name of the Person : " + name);
            Console.WriteLine("Age of the Person : " + age);
            if(age>=18 && age <= 25)
            {
                Console.WriteLine("Your age is between 18 and 25");
            }
            else if (age > 25 && age < 150)
            {
                Console.WriteLine("your age is older than 25");
            }
            else if(age<0 || age>150){
                Console.WriteLine("Invalid age");
            }
        }
    }
}
