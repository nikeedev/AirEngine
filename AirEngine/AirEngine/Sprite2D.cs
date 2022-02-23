using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AirEngine.AirEngine
{
    internal class Sprite2D
    {

        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Directory = "";
        public string Tag = "";
        public Image Sprite = null;


        public Sprite2D(Vector2 Position, Vector2 Scale, string Directory, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Directory = Directory;
            this.Tag = Tag;


            Bitmap sprite = Image.FromFile($"Assets/{Directory}") as Bitmap;

            Log.Info($"[SPRITE 2D]({Tag}) - Has been registred");
            AirEngine.RegisterSprite(this);
        }
        public void DestroySelf()
        {
            AirEngine.UnregisterSprite(this);
        }
    }
}
