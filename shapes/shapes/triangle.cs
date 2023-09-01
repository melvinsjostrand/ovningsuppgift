using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class triangle : shape
    {
        public triangle(float width, float height) : base (width , height  )
        {   
        }

        public float Circumference()
        {
            float Circumference = (width + height + (float)Math.Sqrt((double)(width * width) + (double)(height * height)));
            return Circumference;
        }

        public float Area()
        {
            float area = (width * height) / 2;
            return area;
        }
    }
}


