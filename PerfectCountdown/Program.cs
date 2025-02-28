using System;
using System.Net;

namespace PerfectCountdown
{
     public class Program
    {
        private static void Main(string[] args)
        {
            while (true){
            
                 Console.Write("Start Number: ");
                 int.TryParse(Console.ReadLine(), out int start);
                 Console.Write("Step Number: ");
                 int.TryParse(Console.ReadLine(), out int step)

                 if (start <= 1){
                     Console.WriteLine("Out-of-range start ou step. Try again");
                     continue;
                 }
                 else if (step >= start){
                    Console.WriteLine("Start must be higher than step. Try again");
                    continue;
                 }
                 else if (start % step != 0){
                    Console.WriteLine("Start not divisible by step. Try again");
                    continue;
                 }
                 while (start != 0){
                    Console.WriteLine(start);
                    break;
                 }
            }
        } 
    }
}
