using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(string type, string color,double radius) : base (type,color)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            double area = Math.PI * this.radius * this.radius;
            return Math.Round(area,2);

            //return Math.Round(Math.PI * this.radius * this.radius, 2); tämäkin toimisi
            //return 
        }


        public override string GetInfo()
        {
            return "Shape " + base.type + ", Color " + base.color + ", Radius " + this.radius + ", Area: " + this.GetArea();
        }
    }
}
