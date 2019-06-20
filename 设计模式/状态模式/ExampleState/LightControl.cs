using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleState
{
    class LightControl
    {
        private ILightState _state;
        internal ILightState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public LightControl(ILightState state)
        {
            State = state;
        }
        public void PressSwich()
        {
            Console.ReadKey();
            State.PressSwich(this);
        }

    }
}
