using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEngine.AirEngine
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Vector2(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
