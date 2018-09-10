using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Elephant : Animal
    {

        int hungerCounter = 0;

        public Elephant(string name) : base(name)
        {
        }

        public Elephant(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override bool IsHungry()
        {
            hungerCounter++;
            if (hungerCounter % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
