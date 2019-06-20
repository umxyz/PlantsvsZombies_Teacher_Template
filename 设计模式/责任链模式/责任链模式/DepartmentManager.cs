using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    class DepartmentManager : Handler
    {
        public override bool Approve(double day)
        {
            if (day < 5)
            {
                Console.WriteLine("部门经理审批通过了");
                return true;
            }
            else
            {
                Console.WriteLine("部门经理传递给了它的上级审批");
                return getHandler().Approve(day);
            }
        }
    }
}
