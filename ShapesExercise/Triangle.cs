using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal class Triangle : Shape
    {
        private double length;
        private double width;

        public Triangle()
        {
            length = 0;
            width = 0;
        }

        public Triangle(string type, string color,double lenght, double width) : base (type,color)
        {
            this.length = lenght;
            this.width = width;
        }

        public override double GetArea()
        {
            double area = this.length * this.width / 2;
            return Math.Round(area,2);
        }


        public override string GetInfo()
        {
            return base.type + ", " + base.color + ", " + this.length + ", " + this.width + ", pinta-ala: " + this.GetArea();
        }
    }
}
