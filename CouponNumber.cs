using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void couponNumber()
        {
            Console.WriteLine("Please Enter the how many distict coupon coupon numbers you want to Generate");
            int Number = Console.Read();//User Will Enter the Length of Number.
            int[] Distict=new int[Number];//An array whose length will be equal to the Number entered by the User.
            Random random = new Random();//Generation of random numbers.
            Console.WriteLine("Please Enter the Numbers");
            for(int i=0;i<Number;i++)//a loop which will go from the 0 index position of the array to the length entered by the user.
            {
                Distict[i] = Convert.ToInt32(Console.ReadLine());//every time when the value of i will increase it will be entered in the position of i
            }
            Console.WriteLine("Coupon Number = " + random.Next(0, Distict[Number]));//distict Coupon Number will be generated.
        }
    }
}