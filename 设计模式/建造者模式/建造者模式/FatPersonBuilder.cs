using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class FatPersonBuilder : IBuilder
    {
        private Product pro;
        public FatPersonBuilder() {
            pro = new Product();
        }
        public void BuildFeet()
        {
            pro.Add("胖人脚");//创建胖人的脚
        }
        public void BuildBody()
        {
            pro.Add("胖人身体");//创建胖人的身体
        }

       

        public void BuildHand()
        {
            pro.Add("胖人手");//创建胖人的手
        }

        public void BuildHead()
        {
            pro.Add("胖人头");//创建胖人的头
        }

        public Product GetResult()
        {
            return pro;
        }
    }
}
