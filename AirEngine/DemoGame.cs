using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AirEngine.AirEngine;


namespace AirEngine
{
    class DemoGame : AirEngine.AirEngine
    {
        Shape2D player;
        public DemoGame() : base(new Vector2(615, 515), "AirEngine Demo") { }

        public override void OnLoad()
        {
            BackgroundColor = Color.FromArgb(93, 115, 240);

            player = new Shape2D(new Vector2(10, 10), new Vector2(10, 10), "Test");
        }

        public override void OnDraw()
        {
            
        }


        public override void OnUpdate()
        {
            
        }
    }
}
