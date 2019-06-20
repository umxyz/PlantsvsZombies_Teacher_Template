using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class TravelContext
    {
        private string _start;
        private string _end;
        private TravelStrategy _strategy;

        public TravelContext(string s ,string e)
        {
            Start = s;
            End = e;
        }
        public string Start
        {
            get
            {
                return _start;
            }

            set
            {
                _start = value;
            }
        }
        public string End
        {
            get
            {
                return _end;
            }

            set
            {
                _end = value;
            }
        }
        public void SetStrategy(TravelStrategy t) {
            _strategy = t;
        }
        public void TravelFuction()
        {
            this._strategy.Travel(this);
        }

    }
}
