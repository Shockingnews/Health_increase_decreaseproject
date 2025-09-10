using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_increase_decreaseproject
{
    internal class Program
    {
        // player information
        static string PlayerName = "Max Death";
        static int Health = 100;
        static int stamina = 50;
        static int shield = 25;
        static int coins = 10;

        // Iteams
        static int HealthPostion = 25;
        static int Points = 0;
        static void Main(string[] args)
        {
            
            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();

            TakeShieldDamage(25);
            TakeDamage(50);
            stamina = stamina - 10;
            Totalpoints(-20);


            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You were attack by a few bandits and lost your shield and ran.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();


            coins = coins - 7;
            shield = shield + 15;
            Health = Health + HealthPostion;
            Totalpoints(35);

            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You find yourself low on coins after buying a new shield and health postion,");
            Console.WriteLine("so you look for jobs for money.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();


            TakeShieldDamage(5);
            stamina = stamina - 15;
            coins = coins + 10;
            Totalpoints(50);

            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You gain ten coins from your adventure and your shield is a bit damnged.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();


            TakeShieldDamage(10);
            TakeDamage(65);
            stamina = stamina - 25;
            Totalpoints(-100);

            ShowHUD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You incounter a swarm of goblins with bows and swords and you run for your life of what, you have so little of.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();
        }
        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0,0}{1,15}{2,15}{3,15}", "Name: " + PlayerName, " Health: " + Health, " stamina: " + stamina, " shield: " + shield);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("coins: " + coins);
            Console.WriteLine("Points: " + Points);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static int TakeDamage(int AmountDamage)
        {
            Health -= AmountDamage;
            return Health;
        }
        static int TakeShieldDamage(int AmountShieldDamage)
        {
            shield -= AmountShieldDamage;
            return shield;
        }
        static int Totalpoints(int AddPoints)
        {
            Points += AddPoints;
            return Points;
        }
    }
}
