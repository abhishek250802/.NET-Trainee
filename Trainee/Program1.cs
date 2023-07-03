using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee
{
    public class Program1
    {
         public static void method1()
        {

            int x = 5;
            int y = 3;
            int z = 4;
            if (
                (x + y + z > 10) && (x ==y))
                    { 
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
        {
                Console.WriteLine("The answer in not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
        }
             int counter = 0;
             while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counteris {counter}");
                counter++;
            }
            }
    }

        
    

}

