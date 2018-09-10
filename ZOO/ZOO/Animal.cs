using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        private int fedtimes;

        public Animal(string name)
        {
            this.name = name;
        }

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Eat()
        {
            fedtimes++;
        }

        public abstract bool IsHungry();
                 
        public override string ToString()
        {
            return string.Format($"{name} is a {age} years old {gender} animal was fed {fedtimes} times");
        }
    }
}
