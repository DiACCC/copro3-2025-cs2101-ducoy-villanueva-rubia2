using System;
using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;

namespace Codes.CoreSystem.OnePlayerProfile
{
    class OnePlayerProfile
    {
        private static Character loadedCharacter = null;

        public OnePlayerProfile()
        {
            Console.WriteLine("Initializing profile of player.");
        }

        public static void SetLoadedCharacter(Character character)
        {
            loadedCharacter = character;
        }
        public static Character GetLoadedCharacter()
        {
            return loadedCharacter;
        }
    }
}