using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal abstract class Shape : IComparable<Shape>
    {
        protected string type;
        protected string color;

        protected Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        protected Shape()
        {
            this.type = string.Empty;
            this.color = string.Empty;
        }

        public abstract double GetArea();


        public abstract string GetInfo();

       
        public string GetColor()
        {
            return this.color;
        }
        
        public int CompareTo(Shape? other)
        {
            return this.GetArea().CompareTo(other.GetArea());
        }
        /* Tämä lajittelee listan värin mukaan
        public int CompareTo(Shape? other)
        {
            string color = this.GetColor();
            string color2 = other.GetColor();
            return color.CompareTo(color2);
        }*/
    }
}
