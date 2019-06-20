using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class TravelContext2:TravelContext
    {
        private string _way;
       public  TravelContext2(string start ,string end,string w) : base(start, end)
        {
            Way = w;
        }

        public string Way
        {
            get
            {
                return _way;
            }

            set
            {
                _way = value;
            }
        }
    }
}
