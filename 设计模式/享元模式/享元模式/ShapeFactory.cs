using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 享元模式
{
    class ShapeFactory
    {
        private static Dictionary<String, IShape> circleMap = new Dictionary<String, IShape>();
        public static IShape GetCircle(String color)
        {
            Circle circle;
            if (circleMap.ContainsKey(color))
                circle = (Circle)circleMap[color];
            else
                circle = null;
            if (circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("创建新的对象 : " + color);
            }
            return circle;
        }

    }
}
