using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hero_project
{
    internal class Warrrior : Hero
    {
        public int WeaponDamage { get; set; }
       public new int SpecialAttackCooldown { get; set; }

        public Warrrior(string name, int health, int damage, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, string attacktype) : base(name, health, damage, resistanceToPhysical, resistanceToMagical, criticalChance, dodgeChance, attacktype)
        {
            WeaponDamage = WeaponDamage;




            int totalDamage = damage + WeaponDamage;

            totalDamage += 10;


        }

        public override void ChooseStrategy()
        {
            base.ChooseStrategy();
            Console.WriteLine("3. Execute special attack");
        }

       
        public override void ApplyBonus()
        {
            base.ApplyBonus();


            if (SpecialAttackCooldown == 0)
            {
                Console.WriteLine($"{Name} executes a powerful special attack!");
                SpecialAttackCooldown = 3; 
            }
        }
    }

}





