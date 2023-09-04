using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public abstract class Shape 
    {
        protected float width;
        protected float height;


        public Shape(float width, float height)
        { 
            this.width = width;
            this.height = height;


        }
        public abstract float Area();
        public abstract float Circumference();
    }
}
