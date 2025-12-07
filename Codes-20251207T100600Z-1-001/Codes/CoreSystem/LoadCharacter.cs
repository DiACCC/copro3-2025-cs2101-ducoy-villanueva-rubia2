using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;
using Codes.Coresystem.ConsoleFunction;
using Codes.CoreSystem.SQLite;
using Codes.Description.Dictionary;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Codes.CoreSystem.LoadCharacter
{
    class LoadCharacter
    {
        public static Character LoadCharacterFunction()
        {
            List<string> saveFiles = SQLiteClass.GetCharacterNames();

            void prompt()
            {
                Console.Clear();

                Console.WriteLine("============= SELECT CHARACTER ============= \n\n[0] Return to Main menu");

                for (int i = 0; i < saveFiles.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {saveFiles[i]}");
                }

                
            }

            if (saveFiles.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("============= SELECT CHARACTER ============= ");
                Console.WriteLine("No save files found. ");
                Console.WriteLine("Wait for few seconds, you're returning to main menu");
                Thread.Sleep(500);
                return null;
            }
            else
            {
                while (true)
                {
                    prompt();

                    int choice = ConsoleMenu.ValidateSelectionMainMenu<int>(0, saveFiles.Count, "\nChoose Character ID: ", prompt);

                    if (choice == 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"Returning to menu!");
                        Thread.Sleep(1000);
                        return null;
                    }

                    int actualIndex = choice - 1;

                    if (actualIndex >= 0 && actualIndex < saveFiles.Count)
                    {
                        string selectedName = saveFiles[actualIndex];
                        Console.WriteLine($"Loading data for: {selectedName}...");
                        Thread.Sleep(1000);

                        Character loadedChar = SQLiteClass.LoadCharacter(selectedName);

                        if (loadedChar != null)
                        {
                            void promptingCharDescription()
                            {
                                Console.Clear(); 

                                Console.WriteLine("==========================================");
                                Console.WriteLine($"      SAVE FILE: {loadedChar.getName().ToUpper()}");
                                Console.WriteLine("==========================================");

                                Console.WriteLine($"Name:           {loadedChar.getName()}");
                                Console.WriteLine($"Race:           {loadedChar.getRace()}");
                                Console.WriteLine($"Gender:         {loadedChar.getGender()}");
                                Console.WriteLine($"Skin Color:     {loadedChar.getSkinColor()}");
                                Console.WriteLine($"Hair:           {loadedChar.getHair()}");
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine($"\n         Character Stats");
                                Console.WriteLine($"Health:         {GameData.race[loadedChar.getRace()].getHealth()} -> {loadedChar.getTotalHealth()}");
                                Console.WriteLine($"Stamina:        {GameData.race[loadedChar.getRace()].getStamina()} -> {loadedChar.getTotalStamina()}");
                                Console.WriteLine($"Strenght:       {GameData.race[loadedChar.getRace()].getStrenght()} -> {loadedChar.getTotalStrength()}");
                                Console.WriteLine($"Haste:          {GameData.race[loadedChar.getRace()].getHaste()} -> {loadedChar.getTotalHaste()}");
                                Console.WriteLine($"Agility:        {GameData.race[loadedChar.getRace()].getAgility()} ->  {loadedChar.getTotalAgility()}");
                                Console.WriteLine($"Defense:        {GameData.race[loadedChar.getRace()].getDefense()} ->  {loadedChar.getTotalDefense()}");
                                Console.WriteLine($"Poise:          {GameData.race[loadedChar.getRace()].getPoise()} ->  {loadedChar.getTotalPoise()}");
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine($"\n         Character Equipment");
                                Console.WriteLine($"Shirt:          {loadedChar.getShirt()}");
                                Console.WriteLine($"Pants:          {loadedChar.getPants()}");
                                Console.WriteLine($"Shoes:          {loadedChar.getShoes()}");
                                Console.WriteLine($"Vest:           {loadedChar.getVest()}");
                                Console.WriteLine($"Gloves:         {loadedChar.getGloves()}");
                                Console.WriteLine($"Neckware:       {loadedChar.getNeckware()}");
                                Console.WriteLine($"Head:           {loadedChar.getHead()}");
                                Console.WriteLine($"Chest:          {loadedChar.getChest()}");
                                Console.WriteLine($"Arm:            {loadedChar.getArm()}");
                                Console.WriteLine($"Waist:          {loadedChar.getWaist()}");
                                Console.WriteLine($"Cape:           ");
                                Console.WriteLine($"Companion:      {loadedChar.getCompanion()}");
                                Console.WriteLine($"Accessories:    {loadedChar.getAccessories()}");
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine($"\n         Character Weapons");
                                Console.WriteLine($"Main Weapon:    {loadedChar.getMainWeapon()}");
                                Console.WriteLine($"Sub-Weapon:     {loadedChar.getSubWeapon()}");
                                Console.WriteLine($"Shield:         {loadedChar.getShield()}");

                                Console.WriteLine("==========================================");

                                Console.WriteLine($"\n[1] LOAD GAME \n[2] GO BACK \n[3] RETURN TO MENU \n[4] DELETE CHARACTER!");
                            }

                            promptingCharDescription();

                            byte choiceIfSave = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 4, "Select Option: ", promptingCharDescription);

                            if (choiceIfSave == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Welcome back, {loadedChar.getName()}!");
                                Thread.Sleep(1500);
                                return loadedChar;
                            }
                            else if (choiceIfSave == 2)
                            {
                                
                                loadedChar = null;
                            }
                            else if (choiceIfSave == 3)
                            {
                                Console.Clear();
                                return null;
                            }
                            else if (choiceIfSave == 4)
                            {
                                void promptDeleteComfirmation()
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Are you sure you want to delete character {loadedChar.getName()}? \n[1] Yes \n[2] No");
                                }
                                promptDeleteComfirmation();
                                byte checkingIfDelete = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select Option: ", promptDeleteComfirmation);

                                if (checkingIfDelete == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Deleting character {loadedChar.getName()}...");
                                    SQLiteClass.DeleteCharacter(loadedChar.getName());
                                    Thread.Sleep(1500);
                                    return null;
                                }
                                else if (checkingIfDelete == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Returning to Load Selection...");
                                    Thread.Sleep(1000);
                                }
                            }

                        }
                    }
                }
            }
            return null;
        }
    }
}
