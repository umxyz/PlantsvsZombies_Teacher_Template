using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    class League : Colleage
    {
        public League(string n) : base(n)
        {

        }
        public override void Talk()
        {
            Console.WriteLine("团支书大声说：" + this.Context);
        }
    }
}
