﻿namespace Assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            if (point1.x == point2.x)
            {
                Console.WriteLine("Points are ib same axis");
            }
            else
            {
                Console.WriteLine("Points not on same axis");
            }
        }
        
        

    }
    public struct Point
    {
        double x;
        double y;

    }
}
    

