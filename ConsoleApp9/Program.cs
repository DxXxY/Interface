using System;


namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 6);
            Romb romb = new Romb(2, 2);
            Squre squre = new Squre(4);
            TeamSolyanka ts = new TeamSolyanka();
            ts.Add(romb);
            ts.Add(rectangle);
            ts.Add(squre);
            Console.WriteLine(ts.GiveArea());
            IDrawable obj = new Circle(10);
            obj.Draw();
            IDrawable obj2 = new Rectangle(10,10);
            obj2.Draw();
            IDrawable obj3 = new Squre(10);
            obj3.Draw();
            IPrintable obj1 = romb;
            obj1.Print();

        }
    }
}
