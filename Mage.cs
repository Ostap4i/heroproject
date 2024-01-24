using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_project
{
    internal class Mage : Hero
    {
        

        public new int SpecialAttackCooldown { get; set; }
        public int SpellDamage { get; set; }

        public Mage(string name, int health, int damage, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, int v, string attacktype) : base(name, health, damage, resistanceToPhysical, resistanceToMagical, criticalChance, dodgeChance, attacktype)
        {
            SpellDamage = SpellDamage;

            int totalDamage = damage + SpellDamage;

            totalDamage += 5;
        }

      

        public override void ChooseStrategy() {
            base.ChooseStrategy();
            Console.WriteLine("3. Cast a protective spell");
        }
        


        public override void ApplyBonus()
        {
            base.ApplyBonus();


            if (SpecialAttackCooldown == 0)
            {
                Console.WriteLine($"{Name} casts a protective spell!");
                Health += 15;
                SpecialAttackCooldown = 4;

            
            }
        }
    }


}
    

