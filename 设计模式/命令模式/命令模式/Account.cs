using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class Account
    {
        private double TotalAmount { get; set; }

        public void MoneyIn(double amount)
        {
            this.TotalAmount = this.TotalAmount + amount;
        }
        public void MoneyOut(double amount)
        {
            this.TotalAmount = this.TotalAmount - amount;
        }
        public double GetTotalAmout()
        {
            return this.TotalAmount;
        }
    }
}
