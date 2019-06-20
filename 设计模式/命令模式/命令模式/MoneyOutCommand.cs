using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class MoneyOutCommand : Command
    {
        private double amount;
        public MoneyOutCommand(Account account, double amount)
            :base(account)
        {
            this.amount = amount;
        }

        public override void Execute()
        {
            account.MoneyOut(amount);
        }
    }
}
