using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    class QQAgency : IAgency
    {
        public override void Chart(Colleage stu1, Colleage stu2)
        {
            stu1.Talk();
            stu2.Talk();
        }

        public override void Notify(Colleage stu)
        {
            stu.Talk();
            foreach (var item in this.List)
            {
                Colleage it = (Colleage)item;
                if (item != stu)
                {
                    it.Talk();
                }
            }
        }
    }
}
