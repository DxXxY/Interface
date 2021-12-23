using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Squre : Figure,IDrawable
    {
        private double Lenght { get; set; }

        public Squre(double lenght)
        {
            this.Lenght=lenght;
        }
        public override double Perimeter()
        {
            return Lenght * 4;
        }
        public override double Area()
        {
            return Lenght * Lenght;
        }

        public void Draw()
        {
            ConsoleColor BorderColor = ConsoleColor.Red;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';
            for (double i = 0; i<Lenght; i++)
            {
                for (double j = 0; j<Lenght*1.85; j++)
                {
                    if (i==0 || i==Lenght-1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        if (j==0 || j==Math.Ceiling(Lenght*1.85-1))
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
