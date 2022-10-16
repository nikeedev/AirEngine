using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace AirEngine.AirEngine
{
    public class Shape2D
    {
        public Vector2 position = null;
        public ObjectSize scale = null;
        public string tag = "";
        public Color color = Color.White;

        public Shape2D(Vector2 position, ObjectSize scale, string tag)
        {
            this.position = position;
            this.scale = scale;
            this.tag = tag;

            Log.Info($"[SHAPE 2D]({tag}) - Has been registred");
  
            AirEngine.RegisterShape(this);
        }

        public void DestroySelf()
        {
            Log.Info($"[SHAPE 2D]({tag}) - Has been destroyed.");
            AirEngine.UnregisterShape(this);
        }
    }
}
