using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void Perfect()
        {
            Console.WriteLine("Please enter a Positive Number");
            int Number = Console.Read();//user will input a number
            int divisor = 0;
            if(Number>0)//number should be positive
            {
                for(int i=1;i<Number;i++)
                {
                    if(Number%i==0)//if i is completly divided by the number.
                    {
                        divisor = divisor + i;//the value of will be added to it.
                    }
                }
                if(divisor==Number)//if the sum of its factors will be equal to the number.
                {
                    Console.WriteLine("It is a Perfect Number");
                }
                else//if the sum of the factors are not equal to the number.
                {
                    Console.WriteLine("Not a Perfect Number");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Positive Number");//If the user entered a negative Number or 0.
            }
        }
    }
}
