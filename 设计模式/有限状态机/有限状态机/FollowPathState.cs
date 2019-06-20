using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 有限状态机
{
    class FollowPathState:FSMState
    {
        private FSMSystem sys; 
        public FollowPathState(FSMSystem sys)
        {
            stateID = StateID.FollowingPath;
            this.sys = sys;
        }

        public override void Reason(int meter)
        {
            // If the Player passes less than 15 meters away in front of the NPC
            if (meter < 15)
            {
                sys.PerformTransition(Transition.SawPlayer);
                Console.WriteLine("巡航状态锁定目标，进入追击状态");
            }
            else
            {
                Console.WriteLine("巡逻状态中，没有发现敌人");
            }
        }

        public override void Act()
        {
            
        }
    }
}
