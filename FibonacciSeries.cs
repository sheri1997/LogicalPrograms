using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static void Fibonacci()
        {
            Console.WriteLine("Please Enter the number of terms to be printed");
            int Terms = Console.Read();//User will input the number of terms till which the fibonacci series will be printed.
            int First = 0, Second = 1, Series = 0;
            Console.WriteLine(First + Second);//first and second term will always be 0 and 1.
            for (int i = 2; i <= Terms; ++i)//because first and second is already printed
            {
                Series = First + Second;//Next Term will be the sum of previous two terms.
                Console.WriteLine(Series + "\n");
                First = Second;//since loop is increasing.
                Second = Series;//the previous two terms will also increase.
            }
        }
    }
}
