using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_increase_decreaseproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // player information
            string PlayerName = "Max Death";
            int Health = 100;
            int stamina = 50;
            int shield = 25;
            int coins = 10;

            // iteams
            int SwordDamnage = 5;
            int Arrow = 3;
            int HealthPostion = 25;


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0,0}{1,15}{2,15}{3,15}","Name: " + PlayerName, " Health: " + Health, " stamina: " + stamina, " shield: " + shield);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("coins: " + coins);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();

            shield = shield - SwordDamnage * 5;
            Health = Health - SwordDamnage * 10;
            stamina = stamina - 10;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0,0}{1,15}{2,15}{3,15}", "Name: " + PlayerName, " Health: " + Health, " stamina: " + stamina, " shield: " + shield);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("coins: " + coins);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You were attack by a few bandits and lost your shield and ran.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();


            coins = coins - 7;
            shield = shield + 15;
            Health = Health + HealthPostion;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0,0}{1,15}{2,15}{3,15}", "Name: " + PlayerName, " Health: " + Health, " stamina: " + stamina, " shield: " + shield);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("coins: " + coins);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You find yourself low on coins after buying a new sheild and health poeition,");
            Console.WriteLine("so you look for jobs for money.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();


            shield = shield - SwordDamnage;
            stamina = stamina - 15;
            coins = coins + 10;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0,0}{1,15}{2,15}{3,15}", "Name: " + PlayerName, " Health: " + Health, " stamina: " + stamina, " shield: " + shield);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("coins: " + coins);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You gain ten coins from your adventure and your sheild is a bit damnged.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();


            shield = shield - SwordDamnage * 2;
            Health = Health - SwordDamnage - Arrow * 20;
            stamina = stamina - 25
            ;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0,0}{1,15}{2,15}{3,15}", "Name: " + PlayerName, " Health: " + Health, " stamina: " + stamina, " shield: " + shield);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("coins: " + coins);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You incounter a swarm of goblins with bows and swords and you run for your life of what, you have so little of.");
            Console.WriteLine("Press any button to continue story.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
