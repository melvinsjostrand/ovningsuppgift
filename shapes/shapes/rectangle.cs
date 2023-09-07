using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class rectangle : shape
    {

        public rectangle(float width, float height) : base(width, height)
        {
        }
        public override float Area()
        {
            float Area = width * height;
            return Area;
        }
        public override float Circumference()
        {
            float Circumference = (width + height) * 2;
            return Circumference;
        }

    }
}

