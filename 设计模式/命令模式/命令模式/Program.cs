using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Command commandIn = new MoneyInCommand(account, 500);
            Invoker invoker = new Invoker();
            invoker.SetCommand(commandIn);
            invoker.ExecuteCommand();
            Console.WriteLine("The current amount is " + account.GetTotalAmout());

            Command commandOut = new MoneyOutCommand(account, 300);
            invoker.SetCommand(commandOut);
            invoker.ExecuteCommand();
            Console.WriteLine("The current amount is " + account.GetTotalAmout());

            Console.ReadKey();
        }
    }
}
