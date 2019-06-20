using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class Circle : IShape
    {
        private String color;
        private int x;
        private int y;
        private int radius;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public Circle(String color)
        {
            Color = color;
        }
        public void Draw()
        {
             Console.WriteLine ("Circle: Draw() [Color : " + color
         + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }
}
