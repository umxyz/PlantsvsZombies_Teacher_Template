using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleState
{
    class Program
    {
        static void Main(string[] args)
        {
            LightControl ctrl = new LightControl(new OnState());
            ctrl.PressSwich();
            ctrl.PressSwich();
            ctrl.PressSwich();
            ctrl.PressSwich();
            Console.ReadKey();
        }
    }
}
