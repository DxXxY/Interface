using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class TeamSolyanka
    {
        private List<Figure> figures;
        public TeamSolyanka() {
            figures=new List<Figure>(0);
        }
        public void Add(Figure f)
        {
            figures.Add(f);
        }
        public double GiveArea()
        {
            double temp=0;
            foreach(Figure elem in figures)
            {
                temp+=elem.Area();
            }
            return temp;
        }
    }
}
