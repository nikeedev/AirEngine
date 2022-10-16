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
        Shape2D playerShape;
        Sprite2D playerSprite;

        public DemoGame() : base(new ObjectSize(615, 515), "AirEngine Demo") {}


        public override void OnLoad()
        {
            BackgroundColor = Color.FromArgb(93, 115, 240);

            playerShape = new Shape2D(new Vector2(32, 10), new ObjectSize(64, 64), "Player")
            {
                color = Color.Gold
            };

            playerSprite = new Sprite2D("assets/Circle.png", new Vector2(120, 10), new ObjectSize(64, 64), "Player");


        }

        public override void OnDraw()
        {
            
        }


        public override void OnUpdate()
        {

            //playerShape.position.X += 1;
        }
    }
}
