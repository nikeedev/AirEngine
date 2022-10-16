using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace AirEngine.AirEngine
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }
    
    public abstract class AirEngine
    {
        private ObjectSize ScreenSize = new ObjectSize(512, 512);
        private string Title = "New Game";
        private Canvas Window = null;
        private Thread GameLoopThread = null;


        private static List<Shape2D> AllShapes = new List<Shape2D>();
        private static List<Sprite2D> AllSprites = new List<Sprite2D>(); 


        public Color BackgroundColor;

        public AirEngine(ObjectSize ScreenSize, string Title) 
        {
            Log.Info("Game is starting...");    
            this.ScreenSize = ScreenSize;
            this.Title = Title;
         
            Window = new Canvas();
            Window.Size = new Size((int)this.ScreenSize.Width, (int)this.ScreenSize.Height);
            Window.Text = this.Title;
            Window.Paint += Renderer;


            

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();


            Application.Run(Window);
        }

        public static void RegisterShape(Shape2D shape)
        {
            AllShapes.Add(shape);
        }
        public static void UnregisterShape(Shape2D shape)
        {
            AllShapes.Remove(shape);
        }

        public static void RegisterSprite(Sprite2D sprite)
        {
            AllSprites.Add(sprite);
        }
        public static void UnregisterSprite(Sprite2D sprite)
        {
            AllSprites.Remove(sprite);
        }


        void GameLoop()
        {
            OnLoad();
            while (GameLoopThread.IsAlive)
            {
                try
                {
                    OnDraw();
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    OnUpdate();
                    Thread.Sleep(1);
                }
                catch 
                { 
                    Log.Error("Game has not been found...");
                }
            }
        }


        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(BackgroundColor);

            foreach(Shape2D shape in AllShapes)
            {
                g.FillRectangle(new SolidBrush(Color.Gold), shape.position.X, shape.position.Y, shape.scale.Width, shape.scale.Height);
            }
            foreach (Sprite2D sprite in AllSprites)
            {
                g.DrawImage(sprite.Sprite, sprite.position.X, sprite.position.Y, sprite.scale.Width, sprite.scale.Height);
            }

        }

        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnDraw();



    }

}
