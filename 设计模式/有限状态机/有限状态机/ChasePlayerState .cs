using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 有限状态机
{
    class ChasePlayerState:FSMState
    {
        private FSMSystem sys;
        public ChasePlayerState(FSMSystem sys)
        {
            stateID = StateID.ChasingPlayer;
            this.sys = sys;
        }

        public override void Reason(int meter)
        {
            if (meter >= 30)
            {
                sys.PerformTransition(Transition.LostPlayer);
                Console.WriteLine("追击状态失去目标，进入巡航状态");
            }
            else
            {
                Console.WriteLine("追击状态，追击敌人");
            }
        }

        public override void Act()
        {
            // Follow the path of waypoints
            // Find the direction of the player 		
            
        }
    }
}
