using Codes.AppSetting.AppInfo;
using Codes.CoreSystem.CharacterCreationFolder.CreateNewCharacter2;
using Codes.CoreSystem.LoadCharacter;
using Codes.Description.Dictionary;
using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;
using Codes.CoreSystem.OnePlayerProfile;
using System;
using Character_Creation_Prototype.Codes.StoryJester;

namespace Codes.Coresystem.ConsoleFunction
{
    class CharacterConsole
    {
        public static void displayCharacterInfo(Character newCharacter)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("\nCreating Character Description");
            Console.WriteLine($"Name: {newCharacter.getName()}");
            Console.WriteLine($"Race: {newCharacter.getRace()}");
            Console.WriteLine($"Gender: {newCharacter.getGender()}");
            Console.WriteLine($"Skin Color: {newCharacter.getSkinColor()}");
            Console.WriteLine($"Hair: {newCharacter.getHair()}");
            Console.WriteLine("\n=================================================");
            Console.WriteLine($"\nCharacter Stats");
            Console.WriteLine($"Health: {GameData.race[newCharacter.getRace()].getHealth()} -> {newCharacter.getTotalHealth()}");
            Console.WriteLine($"Stamina: {GameData.race[newCharacter.getRace()].getStamina()} -> {newCharacter.getTotalStamina()}");
            Console.WriteLine($"Strenght: {GameData.race[newCharacter.getRace()].getStrenght()} -> {newCharacter.getTotalStrength()}");
            Console.WriteLine($"Haste: {GameData.race[newCharacter.getRace()].getHaste()} -> {newCharacter.getTotalHaste()}");
            Console.WriteLine($"Agility: {GameData.race[newCharacter.getRace()].getAgility()} ->  {newCharacter.getTotalAgility()}");
            Console.WriteLine($"Defense: {GameData.race[newCharacter.getRace()].getDefense()} ->  {newCharacter.getTotalDefense()}");
            Console.WriteLine($"Poise: {GameData.race[newCharacter.getRace()].getPoise()} ->  {newCharacter.getTotalPoise()}");
            Console.WriteLine("\n=================================================");
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
            Console.WriteLine("\n=================================================");
            Console.WriteLine($"\nCharacter Weapons");
            Console.WriteLine($"Main Weapon: {newCharacter.getMainWeapon()}");
            Console.WriteLine($"Sub-Weapon: {newCharacter.getSubWeapon()}");
            Console.WriteLine($"Shield: {newCharacter.getShield()}");
            Console.WriteLine("\n=================================================");
        }
    }
    public interface IFunctions
    {
        static abstract Character callCreateCharSystem();
        static abstract Character callLoadSystem();
        static abstract Character callStorySystem();
        static abstract void callCredits();
        static abstract void callCloseProgram();
    }

    class ConsoleConnect : IFunctions
    {
        public static Character callCreateCharSystem()
        {
            //CreateNewCharacter.Run();
            Character createdChar = CreateNewCharacter2.Run();

            return createdChar;
        }

        public static Character callLoadSystem()
        {
            Character loadedChar = LoadCharacter.LoadCharacterFunction();
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();

            return loadedChar;
        }

        public static Character callStorySystem()
        {
            Character createdNewCharInStore = story.Play();
            return createdNewCharInStore;
        }

        public static void callCredits()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("             ACKNOWLEDGMENTS             ");
            Console.WriteLine("------------------------------------------\n");

            Console.WriteLine("This project was made possible through the dedication, creativity,");
            Console.WriteLine("and hard work of our entire group. A special thank you to:\n");

            Console.WriteLine($"   {AppInfoConfig.jester}  - story writer, documentation");
            Console.WriteLine("   For giving life into our program. Your imagination created the");
            Console.WriteLine("   story that gives our game its identity. Thank you for staying late");
            Console.WriteLine("   and dedicating your time to make this vision a reality.\n");

            Console.WriteLine($"   {AppInfoConfig.bernard} - flowchart, documentation");
            Console.WriteLine("   For your exceptional organizational skills. Your detailed flowcharts");
            Console.WriteLine("   gave us a near-perfect visual roadmap to follow. Thank you for");
            Console.WriteLine("   opening your home to us and providing a space for us to work together.\n");

            Console.WriteLine($"   {AppInfoConfig.jl} - coding, documentation");
            Console.WriteLine("   For connecting our collective ideas into a cohesive, organized system.");
            Console.WriteLine("   My code would be plain without the spark of Jester and Bernard creativity.");
            Console.WriteLine("   It was an honor to combine your knowledge into this final program.\n");

            Console.WriteLine("------------------------------------------\n");

            Console.WriteLine("   Special Thanks to Sir Lorenz Christopher Afan");
            Console.WriteLine("   Thank you for equipping us with the knowledge and skills to program.");
            Console.WriteLine("   Your guidance has made us more skilled developers, and this project");
            Console.WriteLine("   is a testament to what we have learned from you.\n");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void callCloseProgram()
        {
            
        }
    }

    class ConsoleMenu
    {
        public static void MainView()
        {
            Console.WriteLine($"Name: {AppInfoConfig.NAME}");


            if (OnePlayerProfile.GetLoadedCharacter() != null)
            {
                Console.WriteLine($"\n* Loaded Character: {OnePlayerProfile.GetLoadedCharacter().getName()}\n");
            }
            else
            {
                Console.WriteLine("\n* No Character Loaded.\n");
            }

            Console.WriteLine($"==================================\n");
            Console.WriteLine($"    [1] Story");
            Console.WriteLine($"    [2] Load Character");
            Console.WriteLine($"    [3] Create new Character");
            Console.WriteLine($"    [4] Credits");
            Console.WriteLine($"    [5] Quit");
            Console.WriteLine($"\n==================================");
        }
        
        public static T ValidateSelectionMainMenu<T>(T min, T max, string promptMessage, Action specificConsoleText)
        {
            while (true)
            {
                T selection = GetValidatedInput<T>(promptMessage, specificConsoleText);

                bool isGreaterThanMin = Comparer<T>.Default.Compare(selection, min) >= 0;
                bool isLessThanMax = Comparer<T>.Default.Compare(selection, max) <= 0;

                if (isGreaterThanMin && isLessThanMax)
                {
                    return selection; // Success! Return the validated value of type T.
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\nInvalid choice. Please select a number between {min} and {max}.");

                    Thread.Sleep(1000);

                    Console.Clear();
                    specificConsoleText();
                }
            }
        }

        public static T ValidateSelectionMainMenu<T>(T min, T max, string promptMessage)
        {
            while (true)
            {
                T selection = GetValidatedInput<T>(promptMessage, ConsoleMenu.MainView);

                bool isGreaterThanMin = Comparer<T>.Default.Compare(selection, min) >= 0;
                bool isLessThanMax = Comparer<T>.Default.Compare(selection, max) <= 0;

                if (isGreaterThanMin && isLessThanMax)
                {
                    return selection; // Success! Return the validated value of type T.
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\nInvalid choice. Please select a number between {min} and {max}. ETO YUNG LUMALABAS");

                    Thread.Sleep(1500);

                    Console.Clear();
                    
                }
            }
        }


        //Nakakatamad naman kung gagawa ako ng madaming methods para lang sa specific na data type, kaya gumawa ako ng method that check ng maayos para sa kailangan kong result hehe.
        public static T GetValidatedInput<T>(string promptMessage = "Enter selection: ", Action specificConsoleText = null)
        {
            while (true)
            {
                //Console.WriteLine("\n======================");
                Console.Write("\n" + promptMessage);
                string input = Console.ReadLine();
               

                // Pag string yung need result, then return agad, no need to try and catch lol.
                if (typeof(T) == typeof(string))
                {
                    return (T)(object)input;
                }

                
                try
                {
                    T result = (T)Convert.ChangeType(input, typeof(T));
                    return result;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine($"\nMali yung nilagay mo. Ulitin mo ulit dapat {typeof(T).Name}. Thanks!\n");

                    Thread.Sleep(1000);

                    Console.Clear();
                    specificConsoleText();
                }
                catch (InvalidCastException)
                {
                    Console.Clear();
                    Console.WriteLine($"\n Hindi match yung type sa needed input. Hindi keri ma {typeof(T).Name}, ulitin mo nalang, thanks...\n");

                    Thread.Sleep(1000);

                    Console.Clear();
                    specificConsoleText();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine($"\nOops! Masyadong malaki or bawal ang negative para sa {typeof(T).Name}.\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (specificConsoleText != null) specificConsoleText();
                }
            }
        }
    }
}
