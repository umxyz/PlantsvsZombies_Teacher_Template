using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    abstract class Command
    {
        protected Account account;
        public Command(Account a) {
            this.account = a;
        }
        public abstract void Execute();
    }
}
