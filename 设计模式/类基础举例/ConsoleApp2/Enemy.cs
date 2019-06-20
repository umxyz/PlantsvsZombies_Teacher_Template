using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Enemy
    {
        private int health;
        private string name;
        private int speed;
        public int Health
        {get { return health; }set { health = value; }}
        public int Speed
        {get { return speed; }set { speed = value; }}
        public string Name
        { get { return name; }set { name = value; }}
        public Enemy(int h, int s, string n)
        {
            this.Health = h;
            Speed = s;
            Name = n;
        }
        public Enemy(string n) : this(100, 5, n)
        {

        }
        public Enemy(int h, string n) : this(h, 5, n)
        {

        }
        public void TakeDamage(int amount)
        {
            health = health - amount;
            Console.WriteLine("受到" + amount + "点伤害");
        }
        public void Show()
        {
            Console.WriteLine(Name + "的生命还剩下:" + Health);
        }

    }
}
