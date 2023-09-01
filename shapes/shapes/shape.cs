using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class shape 
    {
        protected float width;
        protected float height;


        public shape(float width, float height)
        { 
            this.width = width;
            this.height = height;


        }
        public float Height { get { return height; } }
        public float Width { get { return width; } }
    }
}
