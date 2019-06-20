using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Weapon
    {
        private int _damge;
        private string _name;
        private int _ranage;
        public int Damge
        {
            get
            {
                return _damge;
            }

            set
            {
                _damge = value;
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
        public int Ranage
        {
            get
            {
                return _ranage;
            }

            set
            {
                _ranage = value;
            }
        }
        public Weapon(string name,int d)
        {
            Damge = d;
            Name = name;
         }
        public Weapon() { }

        public virtual void Attack(Enemy en) {

        }
        public virtual void PlayAnima() {

        }
    }
    
}
