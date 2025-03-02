using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    class Numberformat
    {
        static void Main(String[] args)
        {
            double value = 1000 / 12.34D;
            Console.WriteLine("Value of 1000/12.34 : " + value);
            Console.WriteLine(string.Format("{0} {1}", value, 1000));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:C}", value)); //currency
            Console.WriteLine(string.Format("{0:P}", value)); //percentage
            Console.WriteLine(string.Format("{0:F2}", value)); //2-decimal points

            double money = 10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(string.Format(" ${0:0.00} ", money));
            string moneyString = Convert.ToString(money);
            Console.WriteLine(money.GetType()); //Double
            Console.WriteLine(moneyString.GetType());
            Console.WriteLine(money.ToString());
        }
    }
}
