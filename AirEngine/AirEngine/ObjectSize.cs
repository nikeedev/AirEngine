using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEngine.AirEngine
{
    public class ObjectSize
    {
        
        public float Width { get; set; }
        public float Height { get; set; }

        public ObjectSize()
        {
            this.Width = 0;
            this.Height = 0;
        }
        public ObjectSize(float W, float H)
        {
            this.Width = W;
            this.Height = H;
        }
    }
}
