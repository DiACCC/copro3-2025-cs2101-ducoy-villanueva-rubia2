using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;
using Codes.Coresystem.ConsoleFunction;
using Codes.CoreSystem.CharacterCreationFolder.CreateNewCharacter2;
using Codes.CoreSystem.OnePlayerProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codes.Coresystem.ConsoleFunction;

namespace Character_Creation_Prototype.Codes.StoryJester
{
    class story
    {
        static string message =
            "The air in the sheltered glade had grown thick with the unspoken gravity of history, " +
            "\na weight felt most keenly by those who dwelled within the ancient, luminous canopy. ";
        static string message2 =
            "\n\nWarnings were a constant, a constant, grave reminder: Stay within the light; the world beyond is broken and unforgiving. " +
            "\nYet.... an insistent curiosity pulled at the edges of tradition.";

        static string message3 =
            "\n\nWhile tracing the deep, gnarled roots of a massive, " +
            "\npetrified tree, it was unearthed\na fragment, spine-worn cover bearing the monumental title, The Book of Zephyro.";

        static string message4 =
            "\nIts pages, though brittle with age, hummed with the ghosts of forgotten ancient times—stories of colossal ruins, vanished cities, " +
            "\nand the once-thriving civilizations scattered across the forsaken lands. " +
            "\nThis revelation stirred a magnetic yearning, an irresistible need to witness the truths buried within the silent monuments " +
            "\nof the world’s scarred history. ";

        static string message5 =
            "\n\nThe dangers were well-known: the acid swamps, the territorial beasts, the crushing weight of solitude—" +
            "\nyet the allure remained absolute. " +
            "\nFrom deep within the earth, a strange, low resonance began to rise, a rhythmic pulse that felt like a personal summons, " +
            "\ndrowning out every warning whispered beneath the luminous canopy. " +

            "\n\nIt was the call of discovery—both challenge and promise and despite the pleas of those left behind, the path forward was chosen " +
            "\nguided by an unshakable resolve to uncover the mysteries hidden within the world’s ruined remains.";


        static void Type(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(1);
            }
        }
        static void Type2(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(3);
            }
        }
        static void Type3(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(2);
            }
        }

        static void Type4(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(3);
            }
        }

        static void Type5(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(2);
            }
        }

        public static Character Play()
        {
            Console.Clear();

            Type(message);
            Type2(message2);
            Type3(message3);
            Type4(message4);
            Type5(message5);

            //this annoying input fix lol
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            void menu()
            {
                Console.WriteLine("\n\n[1] Return to main menu \n[2] Create new character");
            }

            menu();

            byte choices = ConsoleMenu.ValidateSelectionMainMenu<byte>(1, 2, "Select: ", menu);

            if (choices == 1)
            {
                Console.WriteLine("\nReturning...");
                Thread.Sleep(1000);

                return null;
            }
            else if (choices == 2)
            {
                Character createdNewChar = ConsoleConnect.callCreateCharSystem();
                Console.Clear();
                return createdNewChar;
            }

            return null;
        }
    }
}