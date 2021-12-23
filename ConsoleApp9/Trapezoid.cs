using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Trapezoid:Figure,IPrintable
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double d { get; set; }
        Trapezoid(double a,double b,double c,double d)
        {
            this.a=a;
            this.b=b;
            this.c=c;
            this.d=d;
        }
        public override double Perimeter()
        {
            return a+b+c+d;
        }
        public override double Area()
        {
            return ((a+b)/2)*Math.Sqrt(c*c-(((b-a)*(b-a)+c*c-d*d)/(2*(b-a)))*(((b-a)*(b-a)+c*c-d*d)/(2*(b-a))));
        }
        public void Print()
        {
            Console.WriteLine($"Trapezoid:\nP={Perimeter()}\nS={Area()}");
        }
    }
}
