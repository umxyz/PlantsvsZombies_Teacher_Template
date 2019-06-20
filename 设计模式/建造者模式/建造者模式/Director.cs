using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildHead();
            builder.BuildBody();
            builder.BuildHand();
            builder.BuildFeet();
        }
    }
}
