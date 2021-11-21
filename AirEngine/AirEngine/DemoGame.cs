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
        public DemoGame() : base(new Vector2(615, 515), "AirEngine Demo")
        {

        }

        public override void OnLoad()
        {
            BackgroundColor = Color.FromArgb(93, 115, 240);
        }

        public override void OnDraw()
        {
            
        }

        int frame = 0;
        public override void OnUpdate()
        {
            Console.WriteLine($"Frame: {frame}");
            frame++;
        }
    }
}
