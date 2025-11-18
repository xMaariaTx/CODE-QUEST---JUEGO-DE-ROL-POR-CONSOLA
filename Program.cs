using System;
public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string Welcome = "===== Welcome, {0} the {1} with level {2} =====";
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
        const string DaysMSG = "Day --> {0}, {1}  you have meditated for {2} hours and your power is {3} points";
        const string MessageOneLevel = "You repeat in the 2nd call";
        const string MessageTwoLevel = "You still confuse the rod with a spoon";
        const string MessageThreeLevel = "You are a Summoner of Magical Breezes";
        const string MessageFourLevel = "Wow! You can summon dragons without burning down the lab!";
        const string MessageFiveLevel = "You have reached the rank of Arcane Master!";

        const string RaodenElantri = "Raoden el Elantri";
        const string ZynBuguejat = "Zyn el Buguejat";
        const string ArkaNullPointer = "Arka Nullpointer";
        const string ElarionLesBrases = "Elarion de les Brases";
        const string ItbWizard = "ITB-Wizard el Gris";

        const string FinalMessage = "Training complete! {0} has achieved a total power of {1} points and earned the title {2}";

        int op = 0, inicial_level = 1, days = 5, hours_level = 0, levelWizard = 0;
        string name = "", tempName = "", levelText = "";
        bool validInput, pass = false;
        var random = new Random();

        do
        {
            Console.WriteLine(MenuTitle);

            if (pass)
            {
                Console.WriteLine(Welcome, name, levelText, levelWizard);
            }

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
                    tempName = Console.ReadLine();

                    tempName = tempName.ToLower();
                    string firstLetter = tempName.Substring(0, 1).ToUpper();
                    string wizard = tempName.Substring(1, tempName.Length - 1);

                    name = firstLetter + wizard;

                    for (int i = 1; i <= days; i++)
                    {
                        int pointsDays = random.Next(1, 11);
                        inicial_level += pointsDays;
                        int hoursdays = random.Next(1, 25);
                        hours_level += hoursdays;
                        Console.WriteLine(DaysMSG, i, name, hours_level, inicial_level);
                    }
                    switch (inicial_level)
                    {
                        case < 20:
                            Console.WriteLine(MessageOneLevel);
                            levelText = RaodenElantri;
                            break;
                        case > 20 and < 30:
                            Console.WriteLine(MessageTwoLevel);
                            levelText = ZynBuguejat;
                            break;
                        case > 30 and < 35:
                            Console.WriteLine(MessageThreeLevel);
                            levelText = ArkaNullPointer;
                            break;
                        case > 35 and < 40:
                            Console.WriteLine(MessageFourLevel);
                            levelText = ElarionLesBrases;
                            break;
                        case > 40:
                            Console.WriteLine(MessageFiveLevel);
                            levelText = ItbWizard;
                            break;
                    }
                    Console.WriteLine(FinalMessage, name, inicial_level, levelText);
                    pass = true;
                    break;
                case 2:

                    break;

            }
        }
        while (op != 0);
    }
}