using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class Program
    {
        private static string[] colors = new string[]{ "Red", "Green", "Blue", "White", "Black" };
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle =(Circle)ShapeFactory.GetCircle(GetRandomColor());
                circle.X=GetRandomX();
                circle.Y=GetRandomY();
                circle.Radius= 100;
                circle.Draw();
            }
            Console.ReadKey();
        }
        private static string GetRandomColor()
        {
            return colors[(int)(new Random(Guid.NewGuid().GetHashCode()).Next(0, colors.Length) )];
        }
        private static int GetRandomX()
        {
            return (int)((new Random(Guid.NewGuid().GetHashCode()).Next(1, 100)));
        }
        private static int GetRandomY()
        {
            return (int)((new Random(Guid.NewGuid().GetHashCode()).Next(1, 100)));
        }
    }
}
