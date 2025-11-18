using System;
public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string Welcome = "===== Welcome, [NOM] the [TÍTOL] with level [NIVELL] =====";
        const string TrainYourWizard = "1. Train your wizard";
        const string IncreaseLvl = "2. Increase LVL";
        const string LootTheMine = "3. Loot the mine";
        const string ShowInventory = "4. Show inventory";
        const string BuyItems = "5. Buy items";
        const string ShowAttacks = "6. Show attacks by LVL";
        const string DecodeAncient = "7. Decode ancient Scroll";
        const string Exit = "0. Exit Game";

        const string ChooseOption = "Choose an option (1-3) - (0) to exit: ";
        const string ChooseOptionError = "Invalid input. Please enter a number between 0 and 3.";

        const string NameWizard = "Introduce the name of your wizard";
        const string daysMSG = "Day --> {0}, {1}  you have meditated for {2} hours and your power is {3} points";
        const string MessageOneLevel = "You repeat in the 2nd call";
        const string MessageTwoLevel = "You still confuse the rod with a spoon";
        const string MessageThreeLevel = "You are a Summoner of Magical Breezes";
        const string MessageFourLevel = "Wow! You can summon dragons without burning down the lab!";
        const string MessageFiveLevel = "You have reached the rank of Arcane Master!";


        int op = 0, inicial_level = 1, days = 5, hours_level = 0;
        string name = "", levelText = "";
        bool validInput;
        var random = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(Welcome);
            Console.WriteLine(TrainYourWizard);
            Console.WriteLine(IncreaseLvl);
            Console.WriteLine(LootTheMine);
            Console.WriteLine(ShowInventory);
            Console.WriteLine(BuyItems);
            Console.WriteLine(ShowAttacks);
            Console.WriteLine(DecodeAncient);
            Console.WriteLine(Exit);
            Console.WriteLine(ChooseOption);
            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(ChooseOptionError);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(ChooseOptionError);
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine(op);
            }

            switch (op)
            {
                case 0:
                    Console.WriteLine("Exit the game");
                    break;
                case 1:
                    Console.WriteLine(NameWizard);
                    name = Console.ReadLine();

                    for (int i = 1; i <= days; i++)
                    {
                        int pointsDays = random.Next(1, 11);
                        inicial_level += pointsDays;
                        int hoursdays = random.Next(1, 25);
                        hours_level += hoursdays;
                        Console.WriteLine(daysMSG, i, name, hours_level, inicial_level);
                    }
                    switch (inicial_level)
                    {
                        case < 20:
                            Console.WriteLine(MessageOneLevel);
                            levelText = "Raoden el Elantri";
                            break;
                        case > 20 and < 30:
                            Console.WriteLine(MessageTwoLevel);
                            levelText = "Zyn el Buguejat";
                            break;
                        case > 30 and < 35:
                            Console.WriteLine(MessageThreeLevel);
                            levelText = "Arka Nullpointer";
                            break;
                        case > 35 and < 40:
                            Console.WriteLine(MessageFourLevel);
                            levelText = "Elarion de les Brases";
                            break;
                        case > 40:
                            Console.WriteLine(MessageFiveLevel);
                            levelText = "ITB-Wizard el Gris";
                            break;
                    }
                    break;
            }
        }
        while (op != 0);
    }
}