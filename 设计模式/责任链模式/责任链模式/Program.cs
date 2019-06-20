using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupLeader gl = new GroupLeader();
            ProjectManager pm = new ProjectManager();
            DepartmentManager dm = new DepartmentManager();
            CEO ceo = new CEO();

            gl.setHandler(pm);
            pm.setHandler(dm);
            dm.setHandler(ceo);

            gl.Approve(4.0);
            Console.ReadKey();
        }
    }
}
