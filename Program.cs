
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hero_project
{

    class Hero
    {


        public delegate int Attackdelegate(int damage, double DamageType, double criticalChance, string attacktype);

        public enum DmageType
        {
            Physical, Megical

        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public double ResistanceToPhysical { get; set; }
        public double ResistanceToMagical { get; set; }
        public double CriticalChance { get; set; }
        public double DodgeChance { get; set; }
        public string attacktype { get; set; }
        public int SpecialAttackCooldown { get; private set; }
        public int HealthRegeneration { get; internal set; }

        public Hero(string name, int health, int damage, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, string attacktype)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.ResistanceToPhysical = resistanceToPhysical;
            this.ResistanceToMagical = resistanceToMagical;
            this.CriticalChance = criticalChance;
            this.DodgeChance = dodgeChance;
            this.attacktype = attacktype;


        }


        public virtual void ChooseStrategy()
        {
            Console.WriteLine($"{Name}, choose your strategy:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{Name} chooses to attack!");
                    break;
                case 2:
                    Console.WriteLine($"{Name} chooses to defend!");
                    break;
                default:
                    Console.WriteLine($"{Name} chooses to attack!");
                    break;
            }
        }

        public virtual void ApplyBonus()
        {
            if (Health < Health)
            {
                int healingAmount = 10;

                Console.WriteLine($"{Name} regains {healingAmount} health!");
            }

            if (SpecialAttackCooldown == 0)
            {
                Console.WriteLine($"{Name} can use a special attack!");
            }
            else
            {
                Console.WriteLine($"{Name} special attack cooldown: {SpecialAttackCooldown} turns.");
                SpecialAttackCooldown--;
            }
        }


        public bool Dodge(double dodgeChance)
        {
            return RandomChance(dodgeChance);
        }


        private bool RandomChance(double chance)
        {
            Random random = new Random();
            double randomValue = random.NextDouble();
            return randomValue < chance;
        }

        internal void ApplyBonuses()
        {
            throw new NotImplementedException();
        }

        internal int Attack(Func<object, object, object, object> value, int v1, string v2, double criticalChance)
        {
            throw new NotImplementedException();
        }

        internal bool Dodge(object dodge)
        {
            throw new NotImplementedException();
        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {
            BattlefieldModifiers modifiers = new BattlefieldModifiers
            {
                WeatherDamageBonus = 5,
                TerrainDamageReduction = 3
            };

            Player player = new Player();






            Console.WriteLine($@" __ __  ____ ____    _____ __  __ ____ _  _____", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine($@"/\ \/\ \/\  _`\ /\  _`\ /\  __`\/\ \/\ \/\  _`\ ");
            Console.WriteLine($@"\ \ \_\ \ \ \L\_\ \ \L\ \ \ \/\ \ \ \ \ \ \,\L\_\");
            Console.WriteLine($@"\ \  _  \ \  _\L\ \ ,  /\ \ \ \ \ \ \ \ \/ _\__ \");
            Console.WriteLine($@" \ \ \ \ \ \ \L\ \ \ \\ \\ \ \_\ \ \ \_\ \/\ \L\ \", Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.WriteLine($@"\ \_\ \_\ \____ /\ \_\ \_\ \_____\ \_____\ `\____\");
            Console.WriteLine($@"   \/ _ /\/ _ /\/ ___ /  \/ _ /\/ /\/ _____ /\/ _____ /\/ _____ /");


            Console.WriteLine("\tFIGHTERS:", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Choose your hero:", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\t     HEROS:", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("Виберіть бійця:");
            Console.WriteLine("1. Archer");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Warrior");


            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n");
            Console.ReadKey();


            int player1Choice = GetPlayerChoice();
            int player2Choice = GetPlayerChoice();

            Player player1 = CreatePlayer(player1Choice);
            Player player2 = CreatePlayer(player2Choice);

            Console.WriteLine($"Player 1 choise {player1.GetName()}.");
            Console.WriteLine($"Player 2 choise {player2.GetName()}.");

            // Бій між гравцями
            while (player1.IsAlive() && player2.IsAlive())
            {
                player1.Attack(player2);
                if (!player2.IsAlive()) break; // Перевірка чи гравець 2 вже мертвий після атаки гравця 1

                player2.Attack(player1);
            }


            // Визначення переможця
            if (player1.IsAlive())
            {
                Console.WriteLine("Pleyer 1 win");
            }
            else if (player2.IsAlive())
            {
                Console.WriteLine("Player 2 win ");
            }
            else
            {
                Console.WriteLine("Draw! ");
            }

            int GetPlayerChoice()
            {
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Please try again ");
                }
                return choice;
            }










        }

        private static Player CreatePlayer(int player1Choice)
        {
            throw new NotImplementedException();
        }
    }
}

    
    

