using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Reverse
    {
        public static void reverse()
        {
            Console.WriteLine("Please enter a Number");
            int Number = Console.Read();
            int Remainder = 0, ReverseNumber = 0;
            while(Number!=0)//Till the number becomes 0.
            {
                Remainder = Number % 10;//Integer data type will leave the decimal part of the number.
                ReverseNumber = ReverseNumber * 10 + Remainder;//Multilpy the variable by 10 and add remainder to it.
                Number = Number / 10;//will finaly reverse the number.
            }
            Console.WriteLine("Reverse of the Number = " + ReverseNumber);
        }
    }
}
