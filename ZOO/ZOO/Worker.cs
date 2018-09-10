using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Worker
    {
        private string name;
        private List<Animal> animalsToLookAfter = new List<Animal>();

        public Worker(string name)
        {
            this.name = name;
        }

        public Worker(string name, List<Animal> animalsToLookAfter)
        {
            this.name = name;
            this.animalsToLookAfter = animalsToLookAfter;
        }

        internal void SetAnimalsToLookAfter(List<Animal>animals)
        {
            foreach (Animal animal in animals)
            {
                animalsToLookAfter.Add(animal);
            }
        }

        public void DoDailyRoutine()
        {
            foreach (Animal animal in animalsToLookAfter)
            {
                if (animal.IsHungry() == true)
                {
                    animal.Eat(); 
                }
            }
        }
    }
}
