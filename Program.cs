using System;
public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

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

        const string MessageMonster = "A wild {0} appears! Rolling dice to determine the outcome of the battle...";
        const string MessageHp = "The {0} has {1} HP";
        const string MessageRoll = "You rolled a {0}";
        const string MessageDamage = "The monster takes damage!";
        const string MessageTotalHp = "The {0} has {1}";
        const string MessageKey = "Press any key to roll the dice again...";
        const string MessageDefeated = "The {0} has been defeated!";
        const string MessageLevelUp = "Level Up!";
        const string One = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n |   o   | /\r\n |       |/ \r\n '-------'\r\n";
        const string Two = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |       | /\r\n |     o |/ \r\n '-------'\r\n";
        const string Three = "  ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |   o   | /\r\n |     o |/ \r\n '-------'\r\n";
        const string Four = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |       | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string Five = " ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |   o   | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string Six = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n | o   o | /\r\n | o   o |/ \r\n '-------'\r\n";

        const string MessageAttemps = "You have {0} attemps to mine for bits";
        const string MessageX = "Insert the x axis: ";
        const string MessageY = "Insert the y axis: ";
        const string MessageNothingFound = "You mine at position [{0}] [{1}] but found nothing.";
        const string MessageFound = "You mine at position [{0}][{1}] and you get {2} bits";
        const string MessageRange = "Coordinates out of range (0-4). Please try again";

        const string MessageEmptyInventory = "Your inventory is empty";
        const string MessageInventory = "Your inventory contains: ";

        const int ColumnMatrix = 5;
        const int FileMatrix = 5;

        int op = 0, inicial_level = 1, days = 5, hours_level = 0, levelWizard = 0, attemps = 5, coinNumber = 8;
        string name = "", tempName = "", levelText = "", item = "";
        bool validInput, pass = false;
        var random = new Random();

        string[] monster = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
        int[] hpMonsters = { 3, 5, 10, 11, 18, 15, 20, 50 };
        string[] rollDice = { One, Two, Three, Four, Five, Six };

        string[] inventory = new string[0];

        string[,] matrixVisble = new string[FileMatrix, ColumnMatrix];
        string[,] matrixVisbleThings = new string[FileMatrix, ColumnMatrix];

        ; do
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
                    int monsters = random.Next(0, 8);

                    int liveMonsters = hpMonsters[monsters];

                    Console.WriteLine(MessageMonster, monster[monsters]);
                    Console.WriteLine(MessageHp, monster[monsters], hpMonsters[monsters]);

                    while (liveMonsters > 0)
                    {
                        int dice = random.Next(0, 6);
                        Console.WriteLine(MessageRoll, dice + 1);
                        Console.WriteLine(rollDice[dice]);
                        Console.WriteLine(MessageDamage);
                        liveMonsters = liveMonsters - (dice + 1);
                        if (liveMonsters < 0)
                        {
                            liveMonsters = 0;
                        }
                        Console.WriteLine(MessageHp, monster[monsters], liveMonsters);
                        Console.WriteLine(MessageKey);
                        Console.ReadLine();
                    }
                    Console.WriteLine(MessageDefeated, monster[monsters]);

                    if (levelWizard < 5)
                    {
                        levelWizard++;
                    }
                    break;
                case 3:
                    for (int i = 0; i < FileMatrix; i++)
                    {
                        for (int j = 0; j < ColumnMatrix; j++)
                        {
                            matrixVisble[i, j] = "➖";
                        }
                    }
                    for (int i = 0; i < FileMatrix; i++)
                    {
                        for (int j = 0; j < ColumnMatrix; j++)
                        {
                            matrixVisbleThings[i, j] = "-";
                        }
                    }
                    for (int i = 0; i < coinNumber; i++)
                    {
                        int x = random.Next(FileMatrix);
                        int y = random.Next(ColumnMatrix);

                        if (matrixVisbleThings[x, y] == "-")
                            matrixVisbleThings[x, y] = "🪙";
                        else
                            i--;
                    }
                    for (int i = 0; i < attemps; i++)
                    {
                        Console.WriteLine($"Attemp {i + 1} of {attemps}");

                        Console.Write("  ");
                        for (int j = 0; j < ColumnMatrix; j++)
                        {
                            Console.Write(j + "  ");
                        }
                        Console.WriteLine();

                        for (int b = 0; b < FileMatrix; b++)
                        {
                            Console.Write(b + " ");
                            for (int j = 0; j < ColumnMatrix; j++)
                            {
                                Console.Write(matrixVisble[b, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.Write(MessageX);
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write(MessageY);
                        int y = Convert.ToInt32(Console.ReadLine());

                        if (x < 0 || x >= FileMatrix || y < 0 || y >= ColumnMatrix)
                        {
                            Console.WriteLine(MessageRange);
                            i--;
                        }
                        if (matrixVisbleThings[x, y] == "🪙")
                        {
                            int bits = random.Next(5, 51);
                            matrixVisble[x, y] = "🪙";
                            matrixVisbleThings[x, y] = "-";

                            Console.WriteLine(MessageFound, x, y, bits);
                        }
                        else
                        {
                            matrixVisble[x, y] = "❌";
                            Console.WriteLine(MessageNothingFound, x, y);
                        }
                    }
                    break;
                case 4:
                    if (item != "")
                    {
                        string[] tempArray = new string[inventory.Length + 1];
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            tempArray[i] = inventory[i];
                        }
                        tempArray[tempArray.Length - 1] = item;
                        inventory = tempArray;
                        item = "";
                    }

                    if (inventory.Length == 0)
                    {
                        Console.WriteLine(MessageEmptyInventory);
                    }
                    else
                    {
                        Console.WriteLine(MessageInventory);
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine(inventory[i]);
                        }
                    }
                    break;
            }
        }
        while (op != 0);
    }
}

