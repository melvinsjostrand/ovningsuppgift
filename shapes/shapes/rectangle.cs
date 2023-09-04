using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
  internal class Rectangle : Shape
    {
            protected float Width;
            protected float Height;

        public Rectangle(float width, float height) : base(width, height)
        {
        }
        public override float Area()
        {
            float Area = Width * Height;
            return Area;
        }
        public override float Circumference()
        {
            float Circumference = (Width + Height) * 2;
            return Circumference;
        }

    }
}

