using System;
using Codes.AppSetting.AppInfo;
using Codes.Coresystem.ConsoleFunction;
using Codes.Description.GameDataFunctionsNamespace;
using Codes.Description.Dictionary;
using Codes.CoreSystem.LoadCharacter;
using Codes.CoreSystem.SQLite;
using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;
using Codes.CoreSystem.OnePlayerProfile;
using DesignBernard;
using Character_Creation_Prototype.Codes.StoryJester;

namespace Character_Creation_Prototype.Codes
{ 
    class Console_Main_View
    {
        public static void Main(string[] args)
        {
            bool runProgram = true;
            SQLiteClass.CreateConnection();

            TitleScreen.start();

            while (runProgram) 
            {
                ConsoleMenu.MainView();


                Console.WriteLine();

                byte mainView_Input = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 5, "Select: ", ConsoleMenu.MainView);


                if (mainView_Input == 1)
                {
                    Character createdNewCharInStory = ConsoleConnect.callStorySystem();
                    OnePlayerProfile.SetLoadedCharacter(createdNewCharInStory);
                    Console.Clear();

                }
                else if (mainView_Input == 2)
                {
                    Character loadedChar = ConsoleConnect.callLoadSystem();
                    OnePlayerProfile.SetLoadedCharacter(loadedChar);
                    Console.Clear();

                }
                else if (mainView_Input == 3)
                {
                    Character createdNewChar = ConsoleConnect.callCreateCharSystem();
                    OnePlayerProfile.SetLoadedCharacter(createdNewChar);
                    Console.Clear();

                }
                else if (mainView_Input == 4)
                {
                    ConsoleConnect.callCredits();
                    Console.Clear();

                }
                else if (mainView_Input == 5)
                {
                    ConsoleConnect.callCloseProgram();
                    runProgram = false;
                    Console.WriteLine("Program Closing.");

                }
            }
        }
    }
}
