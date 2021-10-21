using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void Prime()
        {
            Console.WriteLine("Please Enter a Number");
            int Number = Console.Read();//user input number
            int prime = 0;
            for(int i=1;i<=Number;i++)
            {
                if (Number % i == 0)//will check if the number is completly divided by i or not.
                {
                    prime++;//since a prime number is divided by only 1 and itself.
                }
            }
            if(prime==2)//therefor the value of prime should only be 2
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is Not a Prime Number");
            }
        }
    }
}
