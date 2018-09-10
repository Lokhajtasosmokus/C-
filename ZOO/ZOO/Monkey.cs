using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {
        }

        public Monkey(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override bool IsHungry()
        {
            Random rnd = new Random();
            int r = rnd.Next(0,20);

            if (r == 0)
            {
                return true;
            }
            return false;

        }
    }
}
