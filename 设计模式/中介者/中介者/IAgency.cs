using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者
{
    abstract class IAgency
    {
        private ArrayList _list;

        public ArrayList List
        {
            get
            {
                return _list;
            }

            set
            {
                _list = value;
            }
        }
        public IAgency()
        {
            _list = new ArrayList();
        }
        public void AddColleage(Colleage student)
        {
            List.Add(student);
        }
        public abstract void Notify(Colleage stu);
        public abstract void Chart(Colleage stu1, Colleage stu2);
    }
}
