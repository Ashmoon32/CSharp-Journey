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
            int PlayerCounterAttackPerHit = 5;
            int NormalMonsterHealth = 50;
            int NormalMonsterPowerPerHit = 5;
            int MagicMonsterHealth = 30;
            int MagicMonsterPowerPerHit = 10;
            int BossMonsterHealth = 200;
            int BossMonsterPowerPerHit = 20;
            int BossMonsterSpecialPower = 50;
            bool isPlayerAlive = true;
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

            Console.WriteLine("=========================================");
            Console.WriteLine("Important Note : You have 10  attempts ( 5 attempts is your action and the other 5 attempts is your response for monster attacks) to defeat the monster. And you can also choose when the monster attacks you back. If the monster doesn't die in 5 attempts, you lose the game.");
            Console.WriteLine("=========================================");
            Console.WriteLine("You see the normal monster! What is your action?");
            Console.WriteLine("=========================================");


            try
            {
                while (isPlayerAlive)
                {
                    // Logic for Normal Monster Case
                    // logic - monster will attack when monsterCounterAttack is divisible by 2, otherwise player attack
                    int monsterCounterAttack;

                    for (monsterCounterAttack = 1; monsterCounterAttack <= 10; monsterCounterAttack++)
                    {
                        if (monsterCounterAttack % 2 == 0 && NormalMonsterHealth > 0)
                        {
                            string counterChoice;
                            Console.WriteLine("Monster is attacking you! What is your counter actions? Choose your action");
                            Console.WriteLine("==================================");
                            Console.Write("1. Attack back, 2. Defend, 3. Run (Default is defend!): ");

                            counterChoice = Console.ReadLine();
                            int intCounterChoice = Convert.ToInt32(counterChoice);
                            if (intCounterChoice == 1 || intCounterChoice == 2 || intCounterChoice == 3)
                            {
                                switch (intCounterChoice)
                                {
                                    case 1:
                                        Console.WriteLine("You attack the counter attack while monster is attacking you! 5% of Monster's and 5% of you health also decreases.");
                                        NormalMonsterHealth -= PlayerCounterAttackPerHit;
                                        PlayerHealth -= NormalMonsterPowerPerHit;
                                        PlayerMana -= 10;
                                        break;

                                    case 2:
                                        Console.WriteLine("You defend the monster attack! The monster attack isn't effected to you.");
                                        PlayerMana -= 10;
                                        break;

                                    case 3:
                                        Console.WriteLine("You run and escape from monster attack! No monster attack hits for a while.");
                                        PlayerStamina -= 10;
                                        break;

                                    default:
                                        Console.WriteLine("You defend the monster attack! The monster attack isn't effected to you.");
                                        PlayerMana -= 10;
                                        break;
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid choice! Defaul action 'Defend' is selected.");
                                Console.WriteLine("You defend the monster attack! The monster attack isn't effected to you.");
                                PlayerMana -= 10;
                            }

                            Console.WriteLine($"Your Health: {PlayerHealth}%, Mana: {PlayerMana}%, Stamina: {PlayerStamina}%");
                            Console.WriteLine($"Monster Health: {NormalMonsterHealth}%");
                        }
                        else
                        {
                            while (monsterCounterAttack % 2 != 0 && NormalMonsterHealth > 0)
                            {
                                string choice;
                                Console.WriteLine("Choose your action");
                                Console.WriteLine("==================================");
                                Console.Write("1.Attack , 2.Run, 3.Defend, 4.Use Ultimate (Default is attack!): ");

                                choice = Console.ReadLine();
                                int intChoice = Convert.ToInt32(choice);

                                if (intChoice == 1 || intChoice == 2 || intChoice == 3 || intChoice == 4 || NormalMonsterHealth > 0)
                                {
                                    switch (intChoice)
                                    {
                                        case 1:
                                            Console.WriteLine("You attack the Monster! 10% of Monster's health decreases.");
                                            NormalMonsterHealth -= 10;
                                            PlayerMana -= 10;
                                            break;

                                        case 2:
                                            Console.WriteLine("You run and escape from monster attack! No Monster Attack hits.");
                                            PlayerStamina -= 10;
                                            break;

                                        case 3:
                                            Console.WriteLine("You defend the monster attack! The monster attack isn't effected to you.");
                                            PlayerMana -= 10;
                                            break;

                                        case 4:
                                            Console.WriteLine("Awesome Attack!! You use you ultimate power!! The monster health is decreased 50%.");
                                            NormalMonsterHealth -= 50;
                                            PlayerMana -= 30;
                                            break;

                                        default:
                                            Console.WriteLine("You attack the Monster! 10% of Monster's health is decreased.");
                                            NormalMonsterHealth -= 10;
                                            PlayerMana -= 10;
                                            break;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice! Default action 'Attack' is selected.");
                                    Console.WriteLine("You attack the Monster! 10% of Monster's health is decreased.");
                                    NormalMonsterHealth -= 10;
                                    PlayerMana -= 10;
                                }

                                Console.WriteLine($"Your Health: {PlayerHealth}%, Mana: {PlayerMana}%, Stamina: {PlayerStamina}%");
                                Console.WriteLine($"Monster Health: {NormalMonsterHealth}%");
                                break;


                            }
                        }

                    }


                    if (PlayerHealth <= 0)
                    {
                        isPlayerAlive = false;

                    }
                }

                Console.WriteLine("Game Over! You have been defeated by the monster. See you next time, brave legend " + CharacterName + "...");

            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected Error Occurred! Please Try Again.");
            }
        }
    }
}