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
        public float Area()
        {
            float RecArea = Width * Height;
            return RecArea;
        }
        public float Circumference()
        {
            float Circumference = (Width + Height) * 2;
            return Circumference;
        }

    }
}

