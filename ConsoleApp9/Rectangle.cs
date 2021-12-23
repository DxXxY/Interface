using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Rectangle : Figure,IDrawable
    {
        private double Width { get; set; }
        private double Lenght { get; set; }

        public Rectangle(double lenght,double width)
        {
            this.Width = width;
            this.Lenght = lenght;
        }
        public override double Perimeter()
        {
            return Width * 2 + Lenght * 2;
        }
        public override double Area()
        {
            return Width * Lenght;
        }

        public void Draw()
        {
            ConsoleColor BorderColor = ConsoleColor.Blue;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';
            for (double i = 0; i<Width; i++)
            {
                for (double j = 0; j<Lenght*1.85;j++)
                {
                    if(i==0 || i==Width-1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        if(j==0 || j==Math.Ceiling(Lenght*1.85-1))
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            BorderColor = ConsoleColor.White;
            Console.ForegroundColor = BorderColor;

        }
    }
}
