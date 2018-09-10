using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
        }

        public Lion(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override bool IsHungry()
        {
            return true;
        }
    }
}
