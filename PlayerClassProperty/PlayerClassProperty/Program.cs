using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Lives = 100;

            Console.WriteLine(player.Lives);


            Hero hero = new Hero();
            hero.Lives = 1000;

            Console.WriteLine(hero.Lives);
            
            Console.ReadLine();
        }
    }
}
