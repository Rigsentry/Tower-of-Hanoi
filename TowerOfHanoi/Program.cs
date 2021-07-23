using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter number of disks");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered {0} disks \n", n);
            int count = towerOfHanoi(n);
            Console.WriteLine("#1 Number of steps:{0} \n", count);

            int count2 = towerOfHanoi2(n);
            Console.WriteLine("\n#2 Number of steps:{0} \n", count2);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static int towerOfHanoi(int n)
        {
           // Console.WriteLine("\nMethod #1 outputs count of steps"); These statements consume lot of execution time, so commenting out. Compare results from Test Explorer
            return Convert.ToInt32(Math.Pow(2, n) - 1);
        }

        public static int towerOfHanoi2(int n)
        {
            char from_rod = 'A', to_rod = 'C', aux_rod = 'B';
            int count = 0;
            //Console.WriteLine("\nMethod #2 shows the steps involved along with count");
            count = Move(n, from_rod, aux_rod, to_rod, ref count);
            return count;
        }

        public static int Move(int n, char from_rod, char to_rod, char aux_rod, ref int count)
        {
            if (n == 0)
                return 0;
            if (n == 1)
            {
               // Console.WriteLine("Move disk 1 from rod " + from_rod + " to rod " + to_rod);
                count++;
                return count;
            }
            Move(n - 1, aux_rod, to_rod, from_rod, ref count);
            count = count + 1;
            //Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
            Move(n - 1, aux_rod, to_rod, from_rod, ref count);
            return count;
        }
    }
}