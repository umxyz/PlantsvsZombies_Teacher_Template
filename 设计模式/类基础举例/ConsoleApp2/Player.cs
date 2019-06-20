using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Player
    {
        private int _health;
        private Weapon _weap;
         /// <summary>
         /// 
         /// </summary>
         /// <param name="i">1激光\2火枪\3</param>
        public void SwithWeap(int i)
        {
            switch (i)
            {
                case 1:
                    _weap = new LightWeap("激光1", 10);
                    break;
                case 2:
                    _weap = new FireWeap("火枪1", 5);
                    break;
                case 3:
                    _weap = new DqWeap("毒气1", 1);
                    break;
                default:
                    break;
            }
        }
       
        public void Attack(Enemy en)
        {
            _weap.PlayAnima();
            _weap.Attack(en);
        }
        
        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }
    }
}
