﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    interface IBuilder
    {
        void BuildHead();
        void BuildBody();
        void BuildHand();
        void BuildFeet();
        Product GetResult();
    }
}
