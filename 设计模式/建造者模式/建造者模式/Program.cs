using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder b1 = new FatPersonBuilder();
            IBuilder b2 = new ThinPersonBuilder();
            director.Construct(b1);
            director.Construct(b2);
            Product p1 = b1.GetResult();
            p1.Show();
            b2.GetResult().Show();
            Console.ReadKey();
        }
    }
}
