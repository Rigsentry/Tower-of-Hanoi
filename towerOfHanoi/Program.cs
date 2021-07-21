using System;

namespace towerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test cases built in this array:
            int[] DiscArray = {3, 5, 0, 11, 2};


            //Loop through test cases to avoid unit testing for demo to team:
            for(int i = 0; i < DiscArray.Length ; i++)
            {
                System.Console.WriteLine($"For {DiscArray[i]} discs, the number of moves required is: {NumberOfMoves(DiscArray[i])}! ");
            }
           
        }
        static double NumberOfMoves(int discs)
        {
           return ((Math.Pow(2, discs))-1); //number of moves = (2^number of discs - 1). No exponent operator in c#, used Math.Pow
              
        }





        
    }
}
