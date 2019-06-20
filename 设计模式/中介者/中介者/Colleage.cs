using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    public abstract class Colleage
    {
        private string _name;
        private string _context;
        public string Context
        {
            get
            {
                return _context;
            }

            set
            {
                _context = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public Colleage(string name) { Name = name; }
        public abstract void Talk();
    }
}
