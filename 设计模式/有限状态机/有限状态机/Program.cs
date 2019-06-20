using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 有限状态机
{
    public enum Transition
    {
        NullTransition = 0, // Use this transition to represent a non-existing transition in your system
        SawPlayer=1,
        LostPlayer
    }
    public enum StateID
    {
        NullStateID = 0, // Use this ID to represent a non-existing State in your system	
        FollowingPath=1,
        ChasingPlayer
    }
    class Program
    {
        static void Main(string[] args)
        {
            FSMSystem fsm = new FSMSystem();
            FollowPathState follow = new FollowPathState(fsm);
            follow.AddTransition(Transition.SawPlayer, StateID.ChasingPlayer);
            ChasePlayerState chase = new ChasePlayerState(fsm);
            chase.AddTransition(Transition.LostPlayer, StateID.FollowingPath);
            fsm.AddState(follow);
            fsm.AddState(chase);

            fsm.CurrentState.Reason(31);
            fsm.CurrentState.Act();

            fsm.CurrentState.Reason(14);
            fsm.CurrentState.Act();

            fsm.CurrentState.Reason(13);
            fsm.CurrentState.Act();

            fsm.CurrentState.Reason(32);
            fsm.CurrentState.Act();

            fsm.CurrentState.Reason(16);
            fsm.CurrentState.Act();
            Console.ReadKey();
        }
    }
}
