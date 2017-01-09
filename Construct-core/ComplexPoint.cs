using System;

namespace Examples.Constructcore
{
    class ComplexPoint
    {
        public int X;
        public int Y;
        
        public ComplexPoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
             
        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
