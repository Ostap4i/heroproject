using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_project
{
    internal class Archer : Hero
    {
       
        public int BowDamage { get; set; }
        public new int SpecialAttackCooldown { get; set; }
        public Archer(string name, int health, int damage, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, string attacktype) : base(name, health, damage, resistanceToPhysical, resistanceToMagical, criticalChance, dodgeChance, attacktype)
        {
            BowDamage  = BowDamage;

            int totalDamage = damage  + BowDamage;

            totalDamage += 8;

        }

        

        public override void ChooseStrategy()
        {
            base.ChooseStrategy();
            Console.WriteLine("3. Perform a triple shot");
        }

  
        public override void ApplyBonus()
        {
            base.ApplyBonus();

        
            if (SpecialAttackCooldown == 0)
            {
                Console.WriteLine($"{Name} performs a triple shot!");
                SpecialAttackCooldown = 2;
            }
        }
    }



}

