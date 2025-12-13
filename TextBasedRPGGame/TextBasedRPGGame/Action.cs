using System;
using System.Text.RegularExpressions;

namespace TextBasedRPGGame
{
    public class Action
    {
        public void Start()
        {
            int PlayerHealth = 100;
            int PlayerMana = 100;
            int PlayerStamina = 50;
            int NormalMonsterHealth = 50;
            int NormalMonsterPowerPerHit = 5;
            int MagicMonsterHealth = 30;
            int MagicMonsterPowerPerHit = 10;
            int BossMonsterHealth = 200;
            int BossMonsterPowerPerHit = 20;
            int BossMonsterSpecialPower = 50;
            string CharacterName;

            // To check user only enter alphabetical characters
            var namePattern = new Regex(@"^[a-zA-Z\s]+$");


            // Loop until user enter valid character name
            while (true)
            {
                Console.Write("Hello Legend! Please Enter You Character Name: ");
                CharacterName = Console.ReadLine();

                if (string.IsNullOrEmpty(CharacterName))
                {
                    Console.WriteLine("Character name cannot be empty! Please try again.");
                }
                else if (namePattern.IsMatch(CharacterName))
                {
                    Console.WriteLine($"Welcome , {CharacterName}! Let's get started...");
                    break; // exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please use only alphabetical characters.");
                }
            }

            string choice;

            Console.WriteLine("Choose your action");
            Console.WriteLine("==================================");
            Console.Write("1.Attack , 2.Run, 3.Defend, 4.Use Ultimate (Default is attack!): ");

            choice = Console.ReadLine();
            int intChoice = Convert.ToInt32(choice);


            switch (intChoice)
            {
                case 1:
                    Console.WriteLine("You attack the Monster! 10% of Monster's health decreases.");
                    NormalMonsterHealth -= 10;
                    PlayerMana -= 10;
                    break;

                case 2:
                    Console.WriteLine("You run and escape from monster attack!");
                    PlayerStamina -= 10;
                    break;

                case 3:
                    Console.WriteLine("You defend the monster attack!");
                    PlayerMana -= 10;
                    break;

                case 4:
                    Console.WriteLine("Awesome Attack!! You use you ultimate power!! The monster health decreases 50%.");
                    NormalMonsterHealth -= 50;
                    PlayerMana -= 30;
                    break;

                default:
                    Console.WriteLine("You attack the Monster! 10% of Monster's health decreases.");
                    NormalMonsterHealth -= 10;
                    PlayerMana -= 10;
                    break;


            }
        }
    }
}