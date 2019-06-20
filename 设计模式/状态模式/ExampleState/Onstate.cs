using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleState
{
    class OnState : ILightState
    {
        public void PressSwich(LightControl lightctrl)
        {
            Console.WriteLine("Turn off the light.");
            lightctrl.State = new CloseState();
        }
    }
}
