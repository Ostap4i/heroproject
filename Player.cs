using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_project
{
    internal class Player
    {

        public void ChooseHero()
        {
            Console.WriteLine("Choose your hero:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Archer");

            int choice = Convert.ToInt32(Console.ReadLine());


        }

        internal void Attack(Player player1)
        {
            throw new NotImplementedException();
        }

        internal object GetName()
        {
            throw new NotImplementedException();
        }

        internal bool IsAlive()
        {
            throw new NotImplementedException();
        }
    }
}
