using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LightWeap:Weapon
    {
      
        public LightWeap(string n,int d):base(n,d)
        {
            
        }
        public override void PlayAnima()
        {
            Console.WriteLine("{0}武器正在播放攻击动画",this.Name);
        }
        public override void Attack(Enemy en)
        {
            en.TakeDamage(this.Damge);
        }
    }


}
