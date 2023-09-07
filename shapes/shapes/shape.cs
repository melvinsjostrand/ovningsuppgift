using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public abstract class shape
    {
        protected float width;
        protected float height;


        public shape(float width, float height)
        {
            this.width = width;
            this.height = height;


        }
        public abstract float Area();

        public abstract float Circumference();

    }
}
