using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, thirdNumber = 0;

            

            Console.Write("0, 1,");

            for (int i = 2; i < 100; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write(" {0},", thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }
    }
}
