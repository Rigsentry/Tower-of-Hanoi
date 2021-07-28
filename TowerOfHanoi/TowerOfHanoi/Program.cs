using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            towerHanoi(3);
            Console.ReadKey();
        }

        static int towerHanoi(int input)
        {
            Stack<int> tower1 = new Stack<int>();
            Stack<int> tower2 = new Stack<int>();
            Stack<int> tower3 = new Stack<int>();

            for (int i = input; i > 0; i--)
            {
                tower1.Push(i);
            }
            int count = 0;
            int result = Move(count, input, tower1, tower3, tower2);
            return count;
        }

        //static int move1(int count, Stack<int> tower1, Stack<int> tower2, Stack<int> tower3)
        //{
            
        //}

        static int Move(
            int count,
            int discs,
            Stack<int> firstTower,
            Stack<int> goalTower,
            Stack<int> middleTower)
        {
            if (discs == 0)
            {
                //Console.WriteLine()
                return count;
            }

            count = Move(count, discs - 1, firstTower, middleTower, goalTower); // Move the first disk to the middle tower

            count++;
            goalTower.Push(firstTower.Pop()); // Move the second disk to the goal tower
            Console.WriteLine("moved");

            count = Move(count, discs - 1, middleTower, goalTower, firstTower); // Move the first disk to the goal tower
            return count;
        }
    }
}
