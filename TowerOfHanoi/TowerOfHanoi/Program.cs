using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    { 
        public static double towerHanoi(int num)
        {
            return Math.Pow(2, num) - 1;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                int number;
                if (Int32.TryParse(input, out number))
                {
                    Console.WriteLine(String.Format("Number of steps: {0} \r\n",towerHanoi(number)));
                }
            }
        }
    }

}
