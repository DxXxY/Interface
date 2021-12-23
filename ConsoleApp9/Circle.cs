using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Circle:Figure,IDrawable
    {
        private double R { get; set; }
        public Circle(double R)
        {
            this.R=R;
        }
        public override double Perimeter()
        {
            return Math.PI*2*R;
        }
        public override double Area()
        {
            return Math.PI*R*R;
        }

        public void Draw()
        {
            double radius=R;
            double thickness = 0.4;
            ConsoleColor BorderColor = ConsoleColor.Yellow;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';

           

            Console.WriteLine();
            double rIn = radius- thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
           BorderColor = ConsoleColor.White;
            Console.ForegroundColor = BorderColor;
        }
    }
}
