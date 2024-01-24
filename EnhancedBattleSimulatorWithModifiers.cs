using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_project
{
    internal class EnhancedBattleSimulatorWithModifiers
    {
        public static void SimulateBattle(Hero hero1, Hero hero2, BattlefieldModifiers modifiers)
        {
            Console.WriteLine($"Battle Start: {hero1.Name} vs {hero2.Name}");

            while (hero1.Health > 0 && hero2.Health > 0)
            {
                hero1.ChooseStrategy();
                hero2.ChooseStrategy();

                int damageToHero2 = hero1.Attack((d, type, dodge) =>
                {
                    return hero2.Dodge(dodge) ? 0 : d;
                }, 20, "Slash", hero1.CriticalChance);

                Console.WriteLine($"{hero1.Name} attacked {hero2.Name} for {damageToHero2} damage.");

                hero2.Health -= damageToHero2;

                if (hero2.Health <= 0)
                {
                    Console.WriteLine($"{hero2.Name} has been defeated!");
                    break;
                }

                int damageToHero1 = hero2.Attack((d, type, dodge) =>
                {
              
                    return hero1.Dodge(dodge) ? 0 : d;
                }, 15, "Fireball", hero2.CriticalChance);

                Console.WriteLine($"{hero2.Name} attacked {hero1.Name} for {damageToHero1} damage.");

                hero1.Health -= damageToHero1;

                if (hero1.Health <= 0)
                {
                    Console.WriteLine($"{hero1.Name} has been defeated!");
                    break;
                }

                hero1.ApplyBonuses();
                hero2.ApplyBonuses();

                ApplyBattlefieldModifiers(hero1, modifiers, GetHealthRegeneration(hero1));
                ApplyBattlefieldModifiers(hero2, modifiers, GetHealthRegeneration(hero2));
            }

            Console.WriteLine("Battle End");
        }

        private static int GetHealthRegeneration(Hero hero)
        {
            return hero.HealthRegeneration;
        }

        private static void ApplyBattlefieldModifiers(Hero hero, BattlefieldModifiers modifiers, int healthRegeneration)
        {
            if (hero is Mage)
            {
                hero.Health -= modifiers.WeatherDamageBonus;
                Console.WriteLine($"{hero.Name} takes extra damage due to bad weather!");
            }
            else if (hero is Archer)
            {
             
                int reducedDamage = hero.HealthRegeneration - modifiers.TerrainDamageReduction;
                if (reducedDamage < 0)
                {
                    reducedDamage = 0;
                }

                healthRegeneration = reducedDamage;
                Console.WriteLine($"{hero.Name}'s health regeneration is reduced due to difficult terrain!");
            }
        }



    }
}
