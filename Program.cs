using System;
public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Strings Inicial Menu
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
        const string ChooseOption = "Choose an option (1-7) - (0) to exit: ";
        const string ChooseOptionError = "Invalid input. Please enter a number between 0 and 3.";

        //Strings Chapter One
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

        //Strings Chapter Two
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

        //Strings Chapter Three
        const string MessageAttemps = "You have {0} attemps to mine for bits";
        const string MessageX = "Insert the x axis: ";
        const string MessageY = "Insert the y axis: ";
        const string MessageNothingFound = "You mine at position [{0}] [{1}] but found nothing.";
        const string MessageFound = "You mine at position [{0}][{1}] and you get {2} bits";
        const string MessageRange = "Coordinates out of range (0-4). Please try again";
        const string MessageInvalidRow = "Error! The row it's invalid. Introduce a number between 0-4";
        const string MessageInvalidCol = "Error! The column it's invalid. Introduce a number between 0-4";

        //Strings Chapter Four
        const string MessageEmptyInventory = "Your inventory is empty";
        const string MessageInventory = "Your inventory contains: ";

        //Strings Chapter Five
        const string MessageChooseItems = "You choose to buy items";
        const string MessageBits = "You have {0} bits available";
        const string MessagePurchase = "Items available for purchase: ";
        const string MessageItems = "{0} - {1} - Price: {2}";
        const string MessageWishBuyItem = "Select the item you wish to buy (1-5) (0 to exit):";
        const string MessageExitShop = "Thank you for visiting the shop!";
        const string MessageRestant = "You have purchased: {0} for {1} bits. Bits remaining: {2}";
        const string MessageNoBits = "You do not have enough bits to purchase this item.";
        const string MessageInputError = "The input it's not valid. Introduce a number between 0 and {0}";

       //Strings Chapter Six
        const string MessageTrainingLevels = "Keep training to unlock new powers!";
        const string MessageAvailableAttacksLevels = "Available attacks for level {0}";

        //Strings Chapter Seven
        const string MessageAncientScroll = "You found an ancient scroll with encrypted messages!";
        const string MessageScrollToDecode = "Scroll to decode";
        const string MessageScrollOne = "The 🐲 sleeps in the mountain of fire 🔥";
        const string MessageScrollTwo = "Ancient magic flows through the crystal caves ";
        const string MessageScrollThree = "Spell: Ignis 5 🔥, Aqua 6 💧, Terra 3 🌍, Ventus 8 🌪️ ";
        const string MessageFollowingScroll = "You must decode the following scroll: ";
        const string MessageChooseOperation = "Choose a decoding operation: ";
        const string MessageOperationOne = " 1. Decipher spell (remove spaces)";
        const string MessageOperationTwo = " 2. Count magical runes (vowels)";
        const string MessageOperationThree = " 3. Extract secret code (numbers)";
        const string MessageDeciphred = "Deciphered Spell: {0}";
        const string MessageVowelsFound = "{0} magical runes (vowels) found";
        const string PossibleVowels = "aàáeèéiíïoòóuúüAÀÁEÈÉIÍÏOÒÓUÚÜ";
        const string PossibleNumbers = "0123456789";
        const string MessageScanning = "Scanning: ...";
        const string MessageDecodedNumber = "🔮 Decoded number: {0}";
        const string MessageCongratulations = "Congratulations! You have successfully decoded all parts of the scroll";

        const int ColumnMatrix = 5;
        const int FileMatrix = 5;
        const int LevelsNumbers = 5;

        //Variables
        int op = 0, inicial_level = 1, days = 5, hours_level = 0, levelWizard = 1, attemps = 5, coinNumber = 8, bitsUsers = 0, vowelsCount = 0;
        string name = "", tempName = "", levelText = "", item = "", noEspaces = "", onlyNumbers = "";
        bool validInput, pass = false, scrollOne = false, scrollTwo = false, scrollThree = false, validRowInput = false, validColInput = false, validInputFive = false, validInputSeven = false;
        var random = new Random();

        //Arrays 
        string[] monster = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
        int[] hpMonsters = { 3, 5, 10, 11, 18, 15, 20, 50 };
        string[] rollDice = { One, Two, Three, Four, Five, Six };

        string[] inventory = new string[0];

        string[] objectsItems = { "Iron Dagger 🗡️", "Healing Potion ⚗️", "Ancient Key 🗝️", "Crossbow 🏹", "Metal Shield 🛡️" };
        int[] objectsPrice = { 30, 10, 50, 40, 20 };

        string[][] attacksuser = new string[LevelsNumbers][]
            {
                new string[] { "Magic Spark 💫" },
                new string[] { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" },
                new string[] { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" },
                new string[] { "Wave of Light ⚜️", "Storm of Wings 🐦" },
                new string[] { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" },
            };

        string[] DecodeOptions =
        {
            MessageScrollOne, MessageScrollTwo, MessageScrollThree
        };

        //Matrix
        string[,] matrixVisble = new string[FileMatrix, ColumnMatrix];
        string[,] matrixVisbleThings = new string[FileMatrix, ColumnMatrix];

        //Inicial loop of the game
        do
        {
            Console.WriteLine(MenuTitle);

            if (pass)
            {
                Console.WriteLine(Welcome, name, levelText, levelWizard);
            }

            //Show Menu
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

            //Switch of options 
            switch (op)
            {
                case 0:
                    Console.WriteLine("Exit the game");
                    break;
                case 1:
                    Console.WriteLine(NameWizard);
                    tempName = Console.ReadLine();

                    if (tempName == null)
                    {
                        tempName = "Default";
                    }

                    // --- Creating the wizard name by capitalizing only the first letter ---
                    // This ensures the name always starts with an uppercase letter even if user writes in lowercase.
                    tempName = tempName.ToLower();
                    string firstLetter = tempName.Substring(0, 1).ToUpper();
                    string wizard = tempName.Substring(1, tempName.Length - 1);

                    name = firstLetter + wizard;

                    for (int i = 1; i <= days; i++)
                    {
                        // --- Random training simulation ---
                        // Each "day" generates random training hours and random power increase.
                        // Both values accumulate over several days, affecting the final level.
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

                    // --- Combat system ---
                    // Uses a loop that repeats until the monster's HP drops to 0.
                    // Each iteration simulates rolling a dice (1–6) and subtracting damage.
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
                        Console.ReadKey();
                    }
                    Console.WriteLine(MessageDefeated, monster[monsters]);

                    if (levelWizard < 5)
                    {
                        levelWizard++;
                    }
                    break;
                case 3:
                    // --- Matrix initialization for mining ---
                    // matrixVisible is shown to the player, initially filled with '➖'
                    // matrixVisibleThings (hidden layer) contains coins or empty spaces.
                    // The player only sees the visible layer.
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
                    // --- Randomly placing coins in the hidden matrix ---
                    // If the selected cell already has a coin, the loop repeats (i--) to guarantee exactly 'coinNumber' coins.
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

                        int x = 0;
                        int y = 0;

                        while (!validRowInput)
                        {
                            try
                            {
                                Console.Write(MessageX);
                                x = Convert.ToInt32(Console.ReadLine());
                                if (x < 0 || x > 4)
                                {
                                    Console.WriteLine(MessageInvalidRow);
                                }
                                else
                                {
                                    validRowInput = true;
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(ChooseOptionError);
                                validRowInput = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(ChooseOptionError);
                                validRowInput = false;
                            }
                        }
                        while (!validColInput)
                        {
                            try
                            {
                                Console.Write(MessageY);
                                y = Convert.ToInt32(Console.ReadLine());
                                if (y < 0 || y > 4)
                                {
                                    Console.WriteLine(MessageInvalidCol);
                                }
                                else
                                {
                                    validColInput = true;
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(ChooseOptionError);
                                validColInput = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(ChooseOptionError);
                                validColInput = false;
                            }
                        }

                        if (validRowInput && validColInput)
                        {
                            if (x < 0 || x >= FileMatrix || y < 0 || y >= ColumnMatrix)
                            {
                                Console.WriteLine(MessageRange);
                                i--;
                            }
                            if (matrixVisbleThings[x, y] == "🪙")
                            {
                                int bits = random.Next(5, 51);
                                bitsUsers += bits;
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
                    }
                    break;
                case 4:
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
                case 5:
                    int userSelection = 0;
                    Console.WriteLine(MessageChooseItems);
                    Console.WriteLine(MessageBits, bitsUsers);
                    Console.WriteLine(MessagePurchase);

                    for (int i = 0; i < objectsItems.Length; i++)
                    {
                        Console.WriteLine(MessageItems, (i + 1), objectsItems[i], objectsPrice[i]);
                    }

                    while (!validInputFive)
                    {
                        try
                        {
                            Console.WriteLine(MessageWishBuyItem);
                            userSelection = Convert.ToInt32(Console.ReadLine());
                            if (userSelection < 0 || userSelection > objectsItems.Length)
                            {
                                Console.WriteLine(MessageInputError, objectsItems.Length);
                            }
                            else
                            {
                                validInputFive = true;
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(ChooseOptionError);
                            validInputFive = false;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(ChooseOptionError);
                            validInputFive = false;
                        }
                    }

                    if (validInputFive)
                    {
                        if (userSelection == 0)
                        {
                            Console.WriteLine(MessageExitShop);
                        }
                        else
                        {
                            if (bitsUsers >= objectsPrice[userSelection - 1])
                            {
                                bitsUsers -= objectsPrice[userSelection - 1];
                                Console.WriteLine(MessageRestant, objectsItems[userSelection - 1], objectsPrice[userSelection - 1], bitsUsers);

                                // --- Expanding the inventory dynamically ---
                                // Arrays in C# are fixed size, so to add a new item:
                                // 1. Create a new array bigger by 1
                                // 2. Copy old items
                                // 3. Add the new item at the end
                                string[] tempArray = new string[inventory.Length + 1];
                                for (int i = 0; i < inventory.Length; i++)
                                {
                                    tempArray[i] = inventory[i];
                                }
                                tempArray[tempArray.Length - 1] = objectsItems[userSelection - 1];
                                inventory = tempArray;
                            }
                            else
                            {
                                Console.WriteLine(MessageNoBits);
                            }
                        }
                        item = objectsItems[userSelection - 1];
                    }
                    break;
                case 6:
                    Console.WriteLine(MessageAvailableAttacksLevels, levelWizard);

                    // --- Showing attacks based on current level ---
                    // Uses a jagged array (array of arrays), where each level has a different number of attacks.
                    for (int i = 0; i < attacksuser[levelWizard - 1].Length; i++)
                    {
                        Console.WriteLine(attacksuser[levelWizard - 1][i]);
                    }
                    Console.WriteLine(MessageTrainingLevels);
                    break;
                case 7:
                    int introduceNumber = 0;
                    Console.WriteLine(MessageAncientScroll);
                    Console.WriteLine();
                    Console.WriteLine(MessageScrollToDecode);
                    for (int i = 0; i < DecodeOptions.Length; i++)
                    {
                        Console.WriteLine($"  {i + 1}. {DecodeOptions[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(MessageFollowingScroll);
                    Console.WriteLine(MessageChooseOperation);
                    Console.WriteLine(MessageOperationOne);
                    Console.WriteLine(MessageOperationTwo);
                    Console.WriteLine(MessageOperationThree);

                    while (!validInputSeven)
                    {
                        try
                        {
                            introduceNumber = Convert.ToInt32(Console.ReadLine());
                            if (introduceNumber < 0 || introduceNumber > DecodeOptions.Length)
                            {
                                Console.WriteLine(MessageInputError, DecodeOptions.Length);
                            }
                            else
                            {
                                validInputSeven = true;
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(ChooseOptionError);
                            validInputSeven = false;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(ChooseOptionError);
                            validInputSeven = false;
                        }
                    }

                    if (validInputSeven)
                    {
                        switch (introduceNumber)
                        {
                            case 1:
                                // --- Decoding scroll: removing spaces ---
                                // Builds a new string ignoring all space characters.
                                for (int i = 0; i < MessageScrollOne.Length; i++)
                                {
                                    if (MessageScrollOne[i] != ' ')
                                    {
                                        noEspaces += MessageScrollOne[i];
                                    }
                                }
                                Console.WriteLine(MessageDeciphred, noEspaces);
                                scrollOne = true;
                                break;
                            case 2:
                                for (int i = 0; i < MessageScrollTwo.Length; i++)
                                {
                                    char c = MessageScrollTwo[i];
                                    if (PossibleVowels.Contains(c))
                                    {
                                        vowelsCount++;
                                    }
                                }
                                Console.WriteLine(MessageVowelsFound, vowelsCount);
                                scrollTwo = true;
                                break;
                            case 3:
                                for (int i = 0; i < MessageScrollThree.Length; i++)
                                {
                                    char c = MessageScrollThree[i];
                                    if (PossibleNumbers.Contains(c))
                                    {
                                        onlyNumbers += c;
                                    }
                                }
                                Console.WriteLine(MessageScanning);
                                Console.WriteLine(MessageDecodedNumber, onlyNumbers);
                                scrollThree = true;
                                break;
                        }
                    }
      
                    if (scrollOne && scrollTwo && scrollThree)
                    {
                        Console.WriteLine(MessageCongratulations);
                    }
                    break;
            }
        }
        while (op != 0);
    }
}

