using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingInputFromUser
{
    class UserInput
    {
        static void Main(String[] args)
        {
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of the Person : "+age);
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Name of the Person : "+name);
        }
    }
}
