using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    abstract class Handler
    {
        protected Handler handler;
        public abstract bool Approve(double day);
        public Handler getHandler()
        {
            return handler;
        }
        public void setHandler(Handler handler)
        {
            this.handler = handler;
        }
    }
}
