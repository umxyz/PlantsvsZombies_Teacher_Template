using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class MoneyInCommand:Command
    {
        private double amount;

        public MoneyInCommand(Account account, double amount)
            :base(account)
        {
            this.amount = amount;
        }

        public override void Execute()
        {
            base.account.MoneyIn(this.amount);
        }
    }
}
