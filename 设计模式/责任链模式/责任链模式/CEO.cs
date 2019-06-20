using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    class CEO : Handler
    {
        public override bool Approve(double day)
        {
                Console.WriteLine("总经理审批通过了");
                return true;
        }
    }
}
