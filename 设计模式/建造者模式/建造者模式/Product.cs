using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Product
    {
        private List<string> parts ;
        public Product()
        {
            parts = new List<string>();
        }
        
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
