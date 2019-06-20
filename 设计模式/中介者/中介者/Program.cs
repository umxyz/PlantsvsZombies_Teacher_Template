using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor stuMonitor = new Monitor("王一");
            League stuLeague = new League("王二");
            StudentA stuA = new StudentA("小一");
            StudentB stuB = new StudentB("小二");
            QQAgency iAgency = new QQAgency();
            iAgency.AddColleage(stuMonitor);
            iAgency.AddColleage(stuLeague);
            iAgency.AddColleage(stuA);
            iAgency.AddColleage(stuB);
            stuMonitor.Context = "明天中午12点开会";
            stuLeague.Context = "知道了，同学们严格考勤";
            stuA.Context = "我不来，嘿嘿";
            stuB.Context = "我会准时到";
            iAgency.Notify(stuMonitor);
            stuA.Context="开完会来打球？";
            stuB.Context = "行！";
            iAgency.Chart(stuA, stuB);
            Console.ReadKey();
        }
    }
}
