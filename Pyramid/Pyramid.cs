using System;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
            if (height < 1)
            {
                Console.WriteLine("A beautiful pyramid has to have at least one layer.");
                return;
            }
                
            for (int layer = 0; layer < height; layer++)
            {
                string spaces = new string(' ', height - layer - 1);
                string asterisks = new string('*', 2 * layer + 1);
                Console.WriteLine($"{spaces}{asterisks}");
            }
        }
        
        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}