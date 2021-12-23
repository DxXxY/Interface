using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Parallelogram:Figure,IPrintable
    {
        private double a { get; set; }
        private double h1 { get; set; }
        private double h2 { get; set; }
        public Parallelogram(double a,double h1,double h2)
        {
            this.a=a;
            this.h1=h1;
            this.h2=h2;
        }
        public override double Perimeter()
        {
            return (Math.Sqrt(2*h1*h1+2*h2*h2-4*a*a)+a*2);
        }
        public override double Area()
        {
            return h1*a;
        }
        public void Print()
        {
            Console.WriteLine($"Parallelogram:\nP={Perimeter()}\nS={Area()}");
        }
    }
}
