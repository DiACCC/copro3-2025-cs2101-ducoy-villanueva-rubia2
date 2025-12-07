using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;
using Codes.Coresystem.ConsoleFunction;
using Codes.Description.Dictionary;
using Codes.Description.GameDataFunctionsNamespace;
using Codes.Description.ParentItems;
using System;

namespace Codes.CoreSystem.CreateNewCharacter
{
    class CreateNewCharacter
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("----CREATE CHARACTER----");

            string characterName = "";

            while (true)
            {
                characterName = ConsoleMenu.GetValidatedInput<string>("Enter Character Name: ");

                if (!string.IsNullOrWhiteSpace(characterName))
                {
                    break;
                }

                Console.WriteLine("\nBawal white space or empty name lol.");
            }
            //Create Character Empty
            Character newCharacter = new Character(characterName);

            //Race
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT RACE FOR {newCharacter.getName()}----");
                GameDataFunction.DisplayAllNames(GameData.race);
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Race: ");
                string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.race, plrInput);
                GameDataFunction.DisplayItemDetailsByName(GameData.race, inputNameSelected);

                Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ");

                if (confirmingSelection == 1)
                {
                    newCharacter.setRace(inputNameSelected);
                    break;
                }
                else 
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1500);
                }
            }

            //Gender
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT GENDER FOR {newCharacter.getName()}----");
                GameDataFunction.DisplayAllNames(GameData.gender); //change here
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 2, "Select Gender: ");
                string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.gender, plrInput); //change here
                GameDataFunction.DisplayItemDetailsByName(GameData.gender, inputNameSelected); // change here boiiiiiiii iyak

                Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                if (confirmingSelection == 1)
                {
                    newCharacter.setGender(inputNameSelected);
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1500);
                }
            }

            //Hair
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT {newCharacter.getGender()} HAIR FOR {newCharacter.getName()}----");

                string inputNameSelected = "";

                if (newCharacter.getGender() == "Male")
                {
                    GameDataFunction.DisplayAllNames(GameData.maleHair); //change here
                    int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Hair: ");
                    inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.maleHair, plrInput); //change here
                    GameDataFunction.DisplayItemDetailsByName(GameData.maleHair, inputNameSelected); // change here boiiiiiiii iyak
                }
                else if (newCharacter.getGender() == "Female")
                {
                    GameDataFunction.DisplayAllNames(GameData.femaleHair); //change here
                    int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Hair: ");
                    inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.femaleHair, plrInput); //change here
                    GameDataFunction.DisplayItemDetailsByName(GameData.femaleHair, inputNameSelected); // change here boiiiiiiii iyak
                }

                Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                if (confirmingSelection == 1)
                {
                    newCharacter.setHair(inputNameSelected); // change this too
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1500);
                }
            }

            //SkinColor
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT SKIN FOR {newCharacter.getName()}----");
                GameDataFunction.DisplayAllNames(GameData.skinColor); //change here
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 2, "Select Gender: ");
                string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.skinColor, plrInput); //change here
                GameDataFunction.DisplayItemDetailsByName(GameData.skinColor, inputNameSelected); // change here boiiiiiiii iyak

                Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                if (confirmingSelection == 1)
                {
                    newCharacter.setSkinColor(inputNameSelected);
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1500);
                }
            }


            //Display Clothes
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT CLOTHES FOR {newCharacter.getName()}----");

                int plrOptionSelect = 0;

                if (newCharacter.getShirt() != null && newCharacter.getPants() != null && newCharacter.getShoes() != null && newCharacter.getVest() != null && newCharacter.getGloves() != null)
                {
                    Console.WriteLine($"[1] Shirt : {newCharacter.getShirt()} \n[2] Pants : {newCharacter.getPants()} \n[3] Shoes : {newCharacter.getShoes()} \n[4] Vest : {newCharacter.getVest()} \n[5] Gloves : {newCharacter.getGloves()} \n[6] Next");
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Option: ");

                }
                else
                {
                    Console.WriteLine($"[1] Shirt : {newCharacter.getShirt()} \n[2] Pants : {newCharacter.getPants()} \n[3] Shoes : {newCharacter.getShoes()} \n[4] Vest : {newCharacter.getVest()} \n[5] Gloves : {newCharacter.getGloves()}");
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 5, "Select Option: ");
                }




                if (plrOptionSelect == 1)
                {
                    //Shirt
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT SHIRT FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.shirt); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Shirt: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.shirt, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.shirt, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setShirt(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 2)
                {
                    //Pants
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT PANTS FOR {newCharacter.getName()}----"); // chang this also
                        GameDataFunction.DisplayAllNames(GameData.pants); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Pants: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.pants, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.pants, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setPants(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 3)
                {
                    //Shoes
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT SHOES FOR {newCharacter.getName()}----"); // chang this also
                        GameDataFunction.DisplayAllNames(GameData.shoes); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Shoes: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.shoes, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.shoes, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setShoes(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 4)
                {
                    //Vest
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT VEST FOR {newCharacter.getName()}----"); // chang this also
                        GameDataFunction.DisplayAllNames(GameData.vest); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Vest: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.vest, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.vest, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setVest(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 5)
                {
                    //gloves
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT GLOVES FOR {newCharacter.getName()}----"); // chang this also
                        GameDataFunction.DisplayAllNames(GameData.gloves); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 2, "Select Gloves: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.gloves, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.gloves, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setGloves(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 6)
                {
                    break;
                }
            }


            //Display Armor List
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT ARMOR FOR {newCharacter.getName()}----");

                int plrOptionSelect = 0;

                if (newCharacter.getHead() != null && newCharacter.getChest() != null && newCharacter.getArm() != null && newCharacter.getWaist() != null && newCharacter.getAccessories() != null)
                {
                    Console.WriteLine($"[1] Head : {newCharacter.getHead()} \n[2] Chest : {newCharacter.getChest()} \n[3] Arm : {newCharacter.getArm()} \n[4] Waist Down : {newCharacter.getWaist()} \n[5] Accessories : {newCharacter.getAccessories()} \n[6] Next");
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Option: ");

                }
                else
                {
                    Console.WriteLine($"[1] Head : {newCharacter.getHead()} \n[2] Chest : {newCharacter.getChest()} \n[3] Arm : {newCharacter.getArm()} \n[4] Waist Down : {newCharacter.getWaist()} \n[5] Accessories : {newCharacter.getAccessories()}");
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 5, "Select Option: ");
                }




                if (plrOptionSelect == 1)
                {
                    //Head
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT HEAD FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.helmet); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Helmet: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.helmet, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.helmet, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setHead(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 2)
                {
                    //Chest
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT CHEST FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.chestArmor); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Chest Armor: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.chestArmor, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.chestArmor, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setChest(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 3)
                {
                    //arm
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT ARM FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.chestArmor); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 1, "Select Arm Armor: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.armGuard, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.armGuard, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setArm(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 4)
                {
                    //waist down
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT WAIST DOWN FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.waist); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 1, "Select Waist Down Armor: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.waist, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.waist, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setWaist(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 5)
                {
                    //accessories
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT ACCESSORIES FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.accessories); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 1, "Select Accessories: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.accessories, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.accessories, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setAccessories(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 6)
                {
                    break;
                }
            }


            //Weapon Category List
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT WEAPON FOR {newCharacter.getName()}----");

                int plrOptionSelect = 0;

                if (newCharacter.getMainWeapon() != null && newCharacter.getSubWeapon() != null && newCharacter.getShield() != null)
                {
                    Console.WriteLine($"[1] Main Weapon : {newCharacter.getMainWeapon()} \n[2] Sub Weapon : {newCharacter.getSubWeapon()} \n[3] Shield : {newCharacter.getShield()} \n[4] Next");
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 4, "Select Option: ");

                }
                else
                {
                    Console.WriteLine($"[1] Main Weapon : {newCharacter.getMainWeapon()} \n[2] Sub Weapon : {newCharacter.getSubWeapon()} \n[3] Shield : {newCharacter.getShield()}");
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Option: ");
                }

                if (plrOptionSelect == 1)
                {
                    //Main Weappon
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT MAIN WEAPON FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.mainWeapon); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 9, "Select Main Weapon: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.mainWeapon, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.mainWeapon, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setMainWeapon(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 2)
                {
                    //Sub Weappon
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT SUB-WEAPON FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.subWeapon); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Sub-Weapon: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.subWeapon, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.subWeapon, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setSubWeapon(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 3)
                {
                    //shield
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"----SELECT SHIELD FOR {newCharacter.getName()}----"); // Change this also
                        GameDataFunction.DisplayAllNames(GameData.shield); //change here
                        int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 1, "Select Shield: "); // chang this laso
                        string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.shield, plrInput); //change here
                        GameDataFunction.DisplayItemDetailsByName(GameData.shield, inputNameSelected); // change here boiiiiiiii iyak

                        Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                        byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                        if (confirmingSelection == 1)
                        {
                            newCharacter.setShield(inputNameSelected); // change this also
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Resellecting...");
                            Thread.Sleep(1500);
                        }
                    }
                }
                else if (plrOptionSelect == 4)
                {
                    break;
                }
                
            }

            //Companion Category List
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT COMPANION FOR {newCharacter.getName()}----"); // Change this also
                GameDataFunction.DisplayAllNames(GameData.companion); //change here
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 1, "Select Companion: "); // chang this laso
                string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.companion, plrInput); //change here
                GameDataFunction.DisplayItemDetailsByName(GameData.companion, inputNameSelected); // change here boiiiiiiii iyak

                Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                if (confirmingSelection == 1)
                {
                    newCharacter.setCompanion(inputNameSelected); // change this also
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1500);
                }
            }


            //Stats List
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"----SELECT STATS FOR {newCharacter.getName()}----"); // Change this also
                GameDataFunction.DisplayAllNames(GameData.stats); //change here
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Increase Stats: "); // chang this laso
                string inputNameSelected = GameDataFunction.GetItemNameByIndex(GameData.stats, plrInput); //change here
                GameDataFunction.DisplayItemDetailsByName(GameData.stats, inputNameSelected); // change here boiiiiiiii iyak

                Console.WriteLine("\n[1] Confirm \n[2] Reselect");
                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ");

                if (confirmingSelection >= 1 && confirmingSelection <=5)
                {
                    BaseItem item = GameData.stats[inputNameSelected];

                    if (plrInput == 1)
                    {   
                        newCharacter.addHealth(item.getHealth()); // change this also
                    }
                    else if (plrInput == 2)
                    {
                        newCharacter.addStamina(item.getStamina()); // change this also
                    }
                    else if (plrInput == 3)
                    {
                        newCharacter.addStrength(item.getStrenght()); // change this also
                    }
                    else if (plrInput == 4)
                    {
                        newCharacter.addHaste(item.getHaste()); // change this also
                    }
                    else if (plrInput == 5)
                    {
                        newCharacter.addAgility(item.getAgility()); // change this also
                    }

                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("\nCreating Character Description");
            Console.WriteLine($"Name: {newCharacter.getName()}");
            Console.WriteLine($"Race: {newCharacter.getRace()}");
            Console.WriteLine($"Gender: {newCharacter.getGender()}");
            Console.WriteLine($"Skin Color: {newCharacter.getSkinColor()}");
            Console.WriteLine($"Hair: {newCharacter.getHair()}");
            Console.WriteLine($"\nCharacter Stats");
            Console.WriteLine($"Health: 100 -> {newCharacter.getHealth()}");
            Console.WriteLine($"Stamina: 10 -> {newCharacter.getStamina()}");
            Console.WriteLine($"Strenght: 5 -> {newCharacter.getStrength()}");
            Console.WriteLine($"Haste: 10 -> {newCharacter.getHaste()}");
            Console.WriteLine($"Agility: 10 ->  {newCharacter.getAgility()}");
            Console.WriteLine($"\nCharacter Equipment");
            Console.WriteLine($"Shirt: {newCharacter.getShirt()}");
            Console.WriteLine($"Pants: {newCharacter.getPants()}");
            Console.WriteLine($"Shoes: {newCharacter.getShoes()}");
            Console.WriteLine($"Vest: {newCharacter.getVest()}");
            Console.WriteLine($"Gloves: {newCharacter.getGloves()}");
            Console.WriteLine($"Neckware: {newCharacter.getNeckware()}");
            Console.WriteLine($"Head: {newCharacter.getHead()}");
            Console.WriteLine($"Chest: {newCharacter.getChest()}");
            Console.WriteLine($"Arm: {newCharacter.getArm()}");
            Console.WriteLine($"Waist: {newCharacter.getWaist()}");
            Console.WriteLine($"Companion: {newCharacter.getCompanion()}");
            Console.WriteLine($"Accessories: {newCharacter.getAccessories()}");
            Console.WriteLine($"\nCharacter Weapons");
            Console.WriteLine($"Main Weapon: {newCharacter.getMainWeapon()}");
            Console.WriteLine($"Sub-Weapon: {newCharacter.getSubWeapon()}");
            Console.WriteLine($"Shield: {newCharacter.getShield()}");

            Console.WriteLine("[1] Save [2] Restart [3] Cancel");
            byte finalDecision = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 3, "Select Option: ");

            if (finalDecision == 1)
            {
                //Soon yung datastore jusko kaloka na
                Console.WriteLine("Character Saved!");
                Thread.Sleep(2000);
            }
            else if (finalDecision == 2)
            {
                Console.WriteLine("Soon na to, pakipindot nalang ulit");
                Thread.Sleep(2000);
            }
            else if (finalDecision == 3)
            {
                Thread.Sleep(1000);
            }

        }
    }
}

//GameDataFunction.DisplayAllNames(GameData.femaleHair);
//GameDataFunction.DisplayItemDetailsByName(GameData.femaleHair, "Pixie");