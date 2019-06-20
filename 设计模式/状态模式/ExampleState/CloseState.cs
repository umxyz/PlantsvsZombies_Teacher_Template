using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleState
{
    class CloseState : ILightState
    {
        public void PressSwich(LightControl lightctrl)
        {
            
            Console.WriteLine("Turn on the light.");
            lightctrl.State = new OnState();
            
        }
    }
}
