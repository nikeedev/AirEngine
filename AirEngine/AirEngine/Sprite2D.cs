using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AirEngine.AirEngine
{
    public class Sprite2D
    {

        public Vector2 position = null;
        public ObjectSize scale = null;
        public string directory = "";
        public string tag = "";
        public Image Sprite = null;


        public Sprite2D(string directory, Vector2 position, ObjectSize scale, string tag)
        {
            this.directory = directory;
            this.position = position;
            this.scale = scale;
            this.tag = tag;

            Image tmp = Image.FromFile($@"{directory}");

            Bitmap sprite = new Bitmap(tmp);

            Sprite = sprite;

            Log.Info($"[SPRITE 2D]({tag}) - Has been registred");
            AirEngine.RegisterSprite(this);
        }
        public void DestroySelf()
        {
            AirEngine.UnregisterSprite(this);
        }
    }
}
