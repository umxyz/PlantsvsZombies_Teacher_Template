using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    class StudentA : Colleage
    {
        public StudentA(string n) : base(n)
        {

        }
        public override void Talk()
        {
            Console.WriteLine("同学A大声说：" + this.Context);
        }
    }
}
