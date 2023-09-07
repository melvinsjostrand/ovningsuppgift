using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Triangle : Shape
    {


        public Triangle(float width, float height) : base(width, height)
        {
        }


        public override float Circumference()
        {
            float Circumference = (width + height + (float)Math.Sqrt((double)(width * width) + (double)(height * height)));
            return Circumference;
        }

        public override float Area()
        {
            float Area = (width * height) / 2;
            return Area;
        }
    }
}


