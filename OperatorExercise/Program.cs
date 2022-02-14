using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            AreaOfCircle();
            




            if (a == 17 && b == 4)            
            {
               //Exercise one
                Console.WriteLine($"{a}/{b} is {quotient} remainder  {remainder}");
            }

        }
   
            static void AreaOfCircle()
            {
                Console.WriteLine("What is the radius of your circle");
                var radius = double.Parse(Console.ReadLine());
                double pi = 3.14;
                var formula = pi * radius * radius;
                Console.WriteLine($"The area of a circle with a radius of {radius} is {formula}");
            }
        
         
        
        
    }

}
