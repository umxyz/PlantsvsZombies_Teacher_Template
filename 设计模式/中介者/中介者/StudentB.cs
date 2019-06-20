using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    class StudentB : Colleage
    {
        public StudentB(string n) : base(n)
        {

        }
        public override void Talk()
        {
            Console.WriteLine("同学B大声说：" + this.Context);
        }
    }
}
