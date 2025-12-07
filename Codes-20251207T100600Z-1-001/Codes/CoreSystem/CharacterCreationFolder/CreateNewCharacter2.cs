using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;
using Codes.Coresystem.ConsoleFunction;
using Codes.CoreSystem.SQLite;
using Codes.Description.Dictionary;
using Codes.Description.GameDataFunctionsNamespace;
using Codes.Description.ParentItems;
using Microsoft.Data.Sqlite;
using System;
using System.Linq;
using System.Threading;
using Codes.Coresystem.ConsoleFunction;
using Codes.CoreSystem.SQLite;

namespace Codes.CoreSystem.CharacterCreationFolder.CreateNewCharacter2
{
    public class CreateNewCharacter2
    {
        public static Character Run()
        {   
            String characterName = createName();
            
            Character newCharacter = new Character(characterName);

            selectRace(newCharacter);
            
            selectGender(newCharacter);

            selectHair(newCharacter);

            selectSkinColor(newCharacter);

            selectClothes(newCharacter);

            selectArmor(newCharacter);

            selectCape(newCharacter);

            selectWeapons(newCharacter);

            selectCompanion(newCharacter);

            selectStats(newCharacter);

            addingTheAddtionalStatsFromArmor(newCharacter);

            showResults(newCharacter);

            return newCharacter;
        }

        private static void showResults(Character newCharacter) 
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("\n          Creating Character Description");
            Console.WriteLine($"Name:           {newCharacter.getName()}");
            Console.WriteLine($"Race:           {newCharacter.getRace()}");
            Console.WriteLine($"Gender:         {newCharacter.getGender()}");
            Console.WriteLine($"Skin Color:     {newCharacter.getSkinColor()}");
            Console.WriteLine($"Hair:           {newCharacter.getHair()}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"\n         Character Stats");
            Console.WriteLine($"Health:         {GameData.race[newCharacter.getRace()].getHealth()} -> {newCharacter.getTotalHealth()}");
            Console.WriteLine($"Stamina:        {GameData.race[newCharacter.getRace()].getStamina()} -> {newCharacter.getTotalStamina()}");
            Console.WriteLine($"Strenght:       {GameData.race[newCharacter.getRace()].getStrenght()} -> {newCharacter.getTotalStrength()}");
            Console.WriteLine($"Haste:          {GameData.race[newCharacter.getRace()].getHaste()} -> {newCharacter.getTotalHaste()}");
            Console.WriteLine($"Agility:        {GameData.race[newCharacter.getRace()].getAgility()} ->  {newCharacter.getTotalAgility()}");
            Console.WriteLine($"Defense:        {GameData.race[newCharacter.getRace()].getDefense()} ->  {newCharacter.getTotalDefense()}");
            Console.WriteLine($"Poise:          {GameData.race[newCharacter.getRace()].getPoise()} ->  {newCharacter.getTotalPoise()}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"\n         Character Equipment");
            Console.WriteLine($"Shirt:          {newCharacter.getShirt()}");
            Console.WriteLine($"Pants:          {newCharacter.getPants()}");
            Console.WriteLine($"Shoes:          {newCharacter.getShoes()}");
            Console.WriteLine($"Vest:           {newCharacter.getVest()}");
            Console.WriteLine($"Gloves:         {newCharacter.getGloves()}");
            Console.WriteLine($"Neckware:       {newCharacter.getNeckware()}");
            Console.WriteLine($"Head:           {newCharacter.getHead()}");
            Console.WriteLine($"Chest:          {newCharacter.getChest()}");
            Console.WriteLine($"Arm:            {newCharacter.getArm()}");
            Console.WriteLine($"Waist:          {newCharacter.getWaist()}");
            Console.WriteLine($"Cape:           ");
            Console.WriteLine($"Companion:      {newCharacter.getCompanion()}");
            Console.WriteLine($"Accessories:    {newCharacter.getAccessories()}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"\n         Character Weapons");
            Console.WriteLine($"Main Weapon:    {newCharacter.getMainWeapon()}");
            Console.WriteLine($"Sub-Weapon:     {newCharacter.getSubWeapon()}");
            Console.WriteLine($"Shield:         {newCharacter.getShield()}");
            Console.WriteLine("=================================================");
            Console.WriteLine("[1] Save [2] Restart [3] Cancel");
            byte finalDecision = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 3, "Select Option: ");

            if (finalDecision == 1)
            {
                SQLiteClass.SaveCharacter(newCharacter);

                Console.WriteLine("Character Save Process Complete!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else if (finalDecision == 2)
            {
                newCharacter = null; // deleting character created
                Console.WriteLine("Restart character picking.");
                Thread.Sleep(2000);

                CreateNewCharacter2.Run();
                Console.Clear();
            }
            else if (finalDecision == 3)
            {
                newCharacter = null; // deleting character created
                Console.WriteLine("Cancel character picking.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private static void addingTheAddtionalStatsFromArmor(Character newCharacter)
        {
            //helmet
            newCharacter.addTotalHealth(GameData.helmet[newCharacter.getHead()].getHealth());
            newCharacter.addTotalStamina(GameData.helmet[newCharacter.getHead()].getStamina());
            newCharacter.addTotalStrength(GameData.helmet[newCharacter.getHead()].getStrenght());
            newCharacter.addTotalHaste(GameData.helmet[newCharacter.getHead()].getHaste());
            newCharacter.addTotalAgility(GameData.helmet[newCharacter.getHead()].getAgility());
            newCharacter.addTotalDefense(GameData.helmet[newCharacter.getHead()].getDefense());
            newCharacter.addTotalPoise(GameData.helmet[newCharacter.getHead()].getPoise());

            //chest
            newCharacter.addTotalHealth(GameData.chestArmor[newCharacter.getChest()].getHealth());
            newCharacter.addTotalStamina(GameData.chestArmor[newCharacter.getChest()].getStamina());
            newCharacter.addTotalStrength(GameData.chestArmor[newCharacter.getChest()].getStrenght());
            newCharacter.addTotalHaste(GameData.chestArmor[newCharacter.getChest()].getHaste());
            newCharacter.addTotalAgility(GameData.chestArmor[newCharacter.getChest()].getAgility());
            newCharacter.addTotalDefense(GameData.chestArmor[newCharacter.getChest()].getDefense());
            newCharacter.addTotalPoise(GameData.chestArmor[newCharacter.getChest()].getPoise());

            //Arm
            newCharacter.addTotalHealth(GameData.armGuard[newCharacter.getArm()].getHealth());
            newCharacter.addTotalStamina(GameData.armGuard[newCharacter.getArm()].getStamina());
            newCharacter.addTotalStrength(GameData.armGuard[newCharacter.getArm()].getStrenght());
            newCharacter.addTotalHaste(GameData.armGuard[newCharacter.getArm()].getHaste());
            newCharacter.addTotalAgility(GameData.armGuard[newCharacter.getArm()].getAgility());
            newCharacter.addTotalDefense(GameData.armGuard[newCharacter.getArm()].getDefense());
            newCharacter.addTotalPoise(GameData.armGuard[newCharacter.getArm()].getPoise());

            //Waist
            newCharacter.addTotalHealth(GameData.waist[newCharacter.getWaist()].getHealth());
            newCharacter.addTotalStamina(GameData.waist[newCharacter.getWaist()].getStamina());
            newCharacter.addTotalStrength(GameData.waist[newCharacter.getWaist()].getStrenght());
            newCharacter.addTotalHaste(GameData.waist[newCharacter.getWaist()].getHaste());
            newCharacter.addTotalAgility(GameData.waist[newCharacter.getWaist()].getAgility());
            newCharacter.addTotalDefense(GameData.waist[newCharacter.getWaist()].getDefense());
            newCharacter.addTotalPoise(GameData.waist[newCharacter.getWaist()].getPoise());

        }


        private static void selectStats(Character newCharacter) // Complex Item
        {
            String TYPE = "Stats";
            var specificData = GameData.stats;
            byte maxOption = GameData.maxOptionStats;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);

                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection >= 1 && confirmingSelection <= 5)
                {
                    BaseItem item = GameData.stats[inputNameSelected];

                    if (plrInput == 1)
                    {
                        newCharacter.addTotalHealth(item.getHealth()); // change this also
                    }
                    else if (plrInput == 2)
                    {
                        newCharacter.addTotalStamina(item.getStamina()); // change this also
                    }
                    else if (plrInput == 3)
                    {
                        newCharacter.addTotalStrength(item.getStrenght()); // change this also
                    }
                    else if (plrInput == 4)
                    {
                        newCharacter.addTotalHaste(item.getHaste()); // change this also
                    }
                    else if (plrInput == 5)
                    {
                        newCharacter.addTotalAgility(item.getAgility()); // change this also
                    }

                    break;
                }
            }
        }


        private static void selectCompanion(Character newCharacter) // Complex Item
        {
            String TYPE = "Companion";
            var specificData = GameData.companion;
            byte maxOption = GameData.maxOptionCompanion;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setCompanion(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }
            }
        }


        private static void selectWeapons(Character newCharacter)
        {
            while (true)
            {
                int plrOptionSelect = 0;

                if (newCharacter.getMainWeapon() != null && newCharacter.getSubWeapon() != null && newCharacter.getShield() != null)
                {
                    void showScreenSelection()
                    {
                        Console.Clear();
                        Console.WriteLine($"----Select Armor for {newCharacter.getName()}----");

                        Console.WriteLine($"[1] Main Weapon : {newCharacter.getMainWeapon()} \n[2] Sub Weapon : {newCharacter.getSubWeapon()} \n[3] Shield : {newCharacter.getShield()} \n[4] Next");
                        
                    }

                    showScreenSelection();

                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 4, "Select Option: ", showScreenSelection);
                }
                else
                {
                    void showScreenSelection()
                    {
                        Console.Clear();
                        Console.WriteLine($"----Select Armor for {newCharacter.getName()}----");

                        Console.WriteLine($"[1] Main Weapon : {newCharacter.getMainWeapon()} \n[2] Sub Weapon : {newCharacter.getSubWeapon()} \n[3] Shield : {newCharacter.getShield()}");
                    }

                    showScreenSelection();
                        
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 3, "Select Option: ", showScreenSelection);
                }


                if (plrOptionSelect == 1)
                {
                    //Main Weapon
                    selectMainWeapon(newCharacter);
                    
                }
                else if (plrOptionSelect == 2)
                {
                    //Sub-weapon
                    selectSubWeapon(newCharacter);
                }
                else if (plrOptionSelect == 3)
                {
                    // Shield
                    selectShield(newCharacter);
                }
                else if (plrOptionSelect == 4)
                {
                    //close program
                    break;
                }
            }
        }

        private static void selectCape(Character newCharacter) // Complex Item
        {
            String TYPE = "Cape";
            var specificData = GameData.cape;
            byte maxOption = GameData.maxOptionCape;

            while (true)
            {
                void showScreenSelectionCape1()
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to use a cape?");
                    Console.WriteLine("[1] Yes (+5 Strength, -3 Agility) \n[2] No (No additional buff)");
                    
                }

                showScreenSelectionCape1();
                byte useCape = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, $"Select {TYPE}: ", showScreenSelectionCape1);

                if (useCape == 1)
                {
                    newCharacter.addTotalAgility(-1);
                    newCharacter.addTotalStrength(5);
                    newCharacter.setCape(true);
                    break;
                }
                else if (useCape == 2)
                {
                    newCharacter.setCape(false);
                    break;
                }
            }
        }

        private static void selectShield(Character newCharacter) // Complex Item
        {
            String TYPE = "Shield";
            var specificData = GameData.shield;
            byte maxOption = GameData.maxOptionShield;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setShield(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectSubWeapon(Character newCharacter) // Complex Item
        {
            String TYPE = "Sub-Weapon";
            var specificData = GameData.subWeapon;
            byte maxOption = GameData.maxOptionSubWeapon;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setSubWeapon(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectMainWeapon(Character newCharacter) // Complex Item
        {
            String TYPE = "Main Weapon";
            var specificData = GameData.mainWeapon;
            byte maxOption = GameData.maxOptionMainWeapon;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setMainWeapon(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectArmor(Character newCharacter)
        {
            while (true)
            {
                

                int plrOptionSelect = 0;

                if (newCharacter.getHead() != null && newCharacter.getChest() != null && newCharacter.getArm() != null && newCharacter.getWaist() != null && newCharacter.getAccessories() != null)
                {
                    void showScreenSelection()
                    {
                        Console.Clear();
                        Console.WriteLine($"----Select Armor for {newCharacter.getName()}----");
                        Console.WriteLine($"[1] Head : {newCharacter.getHead()} \n[2] Chest : {newCharacter.getChest()} \n[3] Arm : {newCharacter.getArm()} \n[4] Waist Down : {newCharacter.getWaist()} \n[5] Accessories : {newCharacter.getAccessories()} \n[6] Next");

                    }

                    showScreenSelection();

                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Option: ", showScreenSelection);

                }
                else
                {
                    void showScreenSelection()
                    {
                        Console.Clear();
                        Console.WriteLine($"----Select Armor for {newCharacter.getName()}----");
                        Console.WriteLine($"[1] Head : {newCharacter.getHead()} \n[2] Chest : {newCharacter.getChest()} \n[3] Arm : {newCharacter.getArm()} \n[4] Waist Down : {newCharacter.getWaist()} \n[5] Accessories : {newCharacter.getAccessories()}");

                    }

                    showScreenSelection();
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 5, "Select Option: ", showScreenSelection);
                }

                if (plrOptionSelect == 1)
                {
                    //Head
                    selectHeadArmor(newCharacter);
                }
                else if (plrOptionSelect == 2)
                {
                    //Chest
                    selectChest(newCharacter);
                }
                else if (plrOptionSelect == 3)
                {
                    //Arm
                    selectArm(newCharacter);
                }
                else if (plrOptionSelect == 4)
                {
                    //WaistDown
                    selectWaistDown(newCharacter);
                }
                else if (plrOptionSelect == 5)
                {
                    //Accessories
                    selectAccessories(newCharacter);
                }
                else if (plrOptionSelect == 6)
                {
                    //close program
                    break;
                }
            }
        }

        private static void selectAccessories(Character newCharacter) // Complex Item
        {
            String TYPE = "Accessories";
            var specificData = GameData.accessories;
            byte maxOption = GameData.maxOptionCharmItems;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setAccessories(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectWaistDown(Character newCharacter) // Complex Item
        {
            String TYPE = "Waist Down Armor";
            var specificData = GameData.waist;
            byte maxOption = GameData.maxOptionWaist;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setWaist(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectArm(Character newCharacter) // Complex Item
        {
            String TYPE = "Arm Armor";
            var specificData = GameData.armGuard;
            byte maxOption = GameData.maxOptionArmGuard;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setArm(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectChest(Character newCharacter) // Complex Item
        {
            String TYPE = "Chest Armor";
            var specificData = GameData.chestArmor;
            byte maxOption = GameData.maxOptionChestArmor;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setChest(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectHeadArmor(Character newCharacter) // Complex Item
        {
            String TYPE = "Head Armor";
            var specificData = GameData.helmet;
            byte maxOption = GameData.maxOptionHelmet;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // this is in ComplexItem
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setHead(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectClothes(Character newCharacter)
        { 
            while (true)
            {

                int plrOptionSelect = 0;

                if (newCharacter.getShirt() != null && newCharacter.getPants() != null && newCharacter.getShoes() != null && newCharacter.getVest() != null && newCharacter.getGloves() != null && newCharacter.getNeckware() != null)
                {
                    void showScreenSelection()
                    {
                        Console.Clear();
                        Console.WriteLine($"----Select Clothes for {newCharacter.getName()}----");
                        Console.WriteLine($"[1] Shirt : {newCharacter.getShirt()} \n[2] Pants : {newCharacter.getPants()} \n[3] Shoes : {newCharacter.getShoes()} \n[4] Vest : {newCharacter.getVest()} \n[5] Gloves : {newCharacter.getGloves()} \n[6] Neckware : {newCharacter.getNeckware()} \n[7] Next");

                    }

                    showScreenSelection();

                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 7, "Select Option: ", showScreenSelection);

                }
                else
                {
                    void showScreenSelection()
                    {
                        Console.Clear();
                        Console.WriteLine($"----Select Clothes for {newCharacter.getName()}----");
                        Console.WriteLine($"[1] Shirt : {newCharacter.getShirt()} \n[2] Pants : {newCharacter.getPants()} \n[3] Shoes : {newCharacter.getShoes()} \n[4] Vest : {newCharacter.getVest()} \n[5] Gloves : {newCharacter.getGloves()} \n[6] Neckware : {newCharacter.getNeckware()}");

                    }

                    showScreenSelection();
                    
                    plrOptionSelect = ConsoleMenu.ValidateSelectionMainMenu<int>(1, 6, "Select Option: ", showScreenSelection);
                }

                if (plrOptionSelect == 1)
                {
                    //shirt
                    selectShirt(newCharacter);

                }
                else if (plrOptionSelect == 2)
                {
                    //pants
                    selectPants(newCharacter);
                }
                else if (plrOptionSelect == 3)
                {
                    //shoes
                    selectShoes(newCharacter);
                }
                else if (plrOptionSelect == 4)
                {
                    //vest
                    selectVest(newCharacter);
                }
                else if (plrOptionSelect == 5)
                {
                    //gloves
                    selectGloves(newCharacter);
                }
                else if (plrOptionSelect == 6)
                {
                    //neckware
                    selectNeckware(newCharacter);
                }
                else if (plrOptionSelect == 7)
                {
                    //close program
                    break;
                }
            }
        }

        private static void selectNeckware(Character newCharacter)
        {
            String TYPE = "Neckware";
            var specificData = GameData.neckware;
            byte maxOption = GameData.maxOptionNeckware;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setNeckware(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }

        private static void selectGloves(Character newCharacter)
        {
            String TYPE = "Gloves";
            var specificData = GameData.gloves;
            byte maxOption = GameData.maxOptionGloves;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setGloves(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectVest(Character newCharacter)
        {
            String TYPE = "Vest";
            var specificData = GameData.vest;
            byte maxOption = GameData.maxOptionVest;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setVest(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectShoes(Character newCharacter)
        {
            String TYPE = "Shoes";
            var specificData = GameData.shoes;
            byte maxOption = GameData.maxOptionShoes;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setShoes(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectPants(Character newCharacter)
        {
            String TYPE = "Pants";
            var specificData = GameData.pants;
            byte maxOption = GameData.maxOptionPants;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setPants(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectShirt(Character newCharacter)
        {
            String TYPE = "Shirt";
            var specificData = GameData.shirt;
            byte maxOption = GameData.maxOptionShirt;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setShirt(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectSkinColor(Character newCharacter)
        {
            String TYPE = "Skin Color";
            var specificData = GameData.skinColor;
            byte maxOption = GameData.maxOptionSkinColor;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // Update this!
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setSkinColor(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectHair(Character newCharacter)
        {
            
            var currentHairList = GameData.maleHair;
            byte maxOption = GameData.maxOptionMaleHair;

            if (newCharacter.getGender() == "Female")
            {
                currentHairList = GameData.femaleHair;
                maxOption = GameData.maxOptionFemaleHair;
            }

            string TYPE = "Hair";


            while (true)
            {
                void showHairScreen()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(currentHairList);
                }

                showHairScreen();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, (int)maxOption, $"Select {TYPE}: ", showHairScreen);
        
                string inputNameSelected = GameDataFunction.GetItemNameByIndex(currentHairList, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(currentHairList, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setHair(inputNameSelected); // change this!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectGender(Character newCharacter)
        {
            String TYPE = "Gender";
            var specificData = GameData.gender;
            byte maxOption = GameData.maxOptionGender;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData); // Update this!
                }

                showScreenSelection();

                //Change GameData.maxOption_____!
                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setGender(inputNameSelected); // change this too!
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static void selectRace(Character newCharacter)
        {
            String TYPE = "Race";
            var specificData = GameData.race;
            byte maxOption = GameData.maxOptionRace;

            while (true)
            {
                void showScreenSelection()
                {
                    Console.Clear();
                    Console.WriteLine($"----Select {TYPE} for {newCharacter.getName()}----");

                    GameDataFunction.DisplayAllNames(specificData);
                }

                showScreenSelection();

                int plrInput = ConsoleMenu.ValidateSelectionMainMenu<int>(1, maxOption, $"Select {TYPE}: ", showScreenSelection);
                String inputNameSelected = GameDataFunction.GetItemNameByIndex(specificData, plrInput);

                Console.Clear();

                void showScreenComfirmation()
                {
                    GameDataFunction.DisplayItemDetailsByName(specificData, inputNameSelected);
                    Console.WriteLine("\n[1] Confirm \n[2] Reselect: ");
                }

                showScreenComfirmation();

                byte confirmingSelection = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Selection Option: ", showScreenComfirmation);

                if (confirmingSelection == 1)
                {
                    newCharacter.setRace(inputNameSelected);

                    var data = GameData.race[inputNameSelected];

                    int newHealth = data.getHealth();
                    int newStamina = data.getStamina();
                    int newStrenght = data.getStrenght();
                    int newHaste = data.getHaste();
                    int newAgility = data.getAgility();
                    int newDefense = data.getDefense();
                    int newPoise = data.getPoise();

                    newCharacter.setWholeBaseStatsChar(newHealth, newStamina, newStrenght, newHaste, newAgility, newDefense, newPoise);
                    break;
                }
                else
                {
                    Console.WriteLine("Resellecting...");
                    Thread.Sleep(1000);
                }

            }

        }


        private static string createName()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----CREATE CHARACTER----");

                List<String> takenNames = SQLiteClass.GetCharacterNames();
                
                String creatingName = ConsoleMenu.GetValidatedInput<String>("Enter your character name: ");

                if (creatingName.Length >= 4 && creatingName.Length <= 16 && creatingName.All(char.IsLetterOrDigit))
                {
                    if (takenNames.Contains(creatingName))
                    {
                        Console.WriteLine($"\nERROR: The name '{creatingName}' is already taken.");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        return creatingName;
                    }
                }
                else
                {
                    Console.WriteLine("\nERROR: Invalid name. Name must be 4-16 characters long and contain only letters and digits.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            
        }

        

    }
}
