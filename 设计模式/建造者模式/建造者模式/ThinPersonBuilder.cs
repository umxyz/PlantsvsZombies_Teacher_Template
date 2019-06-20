using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class ThinPersonBuilder:IBuilder
    {
        private Product pro;
        public ThinPersonBuilder()
        {
            pro = new Product();
        }
        public void BuildBody()
        {
            pro.Add("瘦人身体");//创建瘦人的身体
        }

        public void BuildFeet()
        {
            pro.Add("瘦人脚");//创建瘦人的脚
        }

        public void BuildHand()
        {
            pro.Add("瘦人手");//创建瘦人的手
        }

        public void BuildHead()
        {
            pro.Add("瘦人头");//创建瘦人的头
        }

        public Product GetResult()
        {
            return pro;
        }
    }
}
