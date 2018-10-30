using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入两个数字存储在变量var1和var2，当两个数都大于10，用户重新输入
            bool numbersOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;
            while (!numbersOK)
            {
                Console.WriteLine("Please enter a number:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter another number:");
                var2 = Convert.ToDouble(Console.ReadLine());
                if  (var1 > 10 && var2 > 10)         //var1 var2都大于10，重新循环
                    {
                    Console.WriteLine("Please make sure that one number is less than 10 at least!");
                }
                                       
                else
                {
                    numbersOK = true;   //跳出循环
                }
                 
            }
            Console.WriteLine("The numbers you have write are {0} and {1}.", var1, var2);
            Console.ReadKey();





        }
    }
}
