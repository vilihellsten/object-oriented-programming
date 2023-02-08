using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(string type, string color,double length, double width) : base (type,color)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            double area = this.length * this.width;
            return Math.Round(area, 2);
        }


        public override string GetInfo()
        {
            return base.type + ", " + base.color + ", " + this.length + ", " + this.width + ", pinta-ala: " + this.GetArea();
        }
    }
}
