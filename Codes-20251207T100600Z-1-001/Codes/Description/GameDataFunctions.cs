using System;
using Codes.Description.Dictionary;
using Codes.Description.ParentItems;

namespace Codes.Description.GameDataFunctionsNamespace
{
    public class GameDataFunction
    {
        public static void DisplayAllNames(Dictionary<string, BaseItem> itemDictionary)
        {
            Console.WriteLine("\n========== Available Selection ==========\n");
            
            int index = 1;

            foreach (string itemName in itemDictionary.Keys)
            {
                Console.WriteLine($"    [{index++}] {itemName}");
            }
            Console.WriteLine($"\n========================================");
        }

        public static void DisplayAllNames(Dictionary<string, ComplexItem> itemDictionary)
        {
            Console.WriteLine("\n========== Available Selection ==========\n");
            int index = 1;

            foreach (string itemName in itemDictionary.Keys)
            {
                Console.WriteLine($"    [{index++}] {itemName}");
            }
            Console.WriteLine($"\n========================================");
        }

        public static void DisplayItemDetailsByName(Dictionary<string, BaseItem> itemDictionary, string itemName)
        {
            if (itemDictionary.ContainsKey(itemName))
            {
                BaseItem item = itemDictionary[itemName];
                Console.WriteLine($"\n========== {item.getName()} Details ==========");
                
                Console.WriteLine($"    \nCategory: {item.getCategory()}");
                Console.WriteLine($"\nDescription: {item.getDescription()}");
                
                if (item is ComplexItem complexItem)
                {
                    Console.WriteLine($"\nExtra Detail: {complexItem.getMoreDescription()}");
                    Console.WriteLine($"\n======================");
                    //Console.WriteLine($"Base Stat: Eme diko alam ano pa ilalagay dito, placeholder pwede baguhin");
                }
                else
                {
                    Console.WriteLine($"\n======================");
                }

            }
            else
            {
                Console.WriteLine($"\nError: Item '{itemName}' not found");
            }
        }

        public static void DisplayItemDetailsByName(Dictionary<string, ComplexItem> itemDictionary, string itemName)
        {
            if (itemDictionary.ContainsKey(itemName))
            {
                BaseItem item = itemDictionary[itemName];
                Console.WriteLine($"\n========== {item.getName()} Details ==========");
                Console.WriteLine($"    \nCategory: {item.getCategory()}");
                Console.WriteLine($"\nDescription: {item.getDescription()}");

                if (item is ComplexItem complexItem)
                {
                    Console.WriteLine($"Extra Detail: {complexItem.getMoreDescription()}");
                    //Console.WriteLine($"Base Stat: Eme diko alam ano pa ilalagay dito, placeholder pwede baguhin");
                    Console.WriteLine($"\n======================");
                }
                else
                {
                    Console.WriteLine($"\n=====================");
                }

            }
            else
            {
                Console.WriteLine($"\nError: Item '{itemName}' not found");
            }
        }

        public static string GetItemNameByIndex(Dictionary<string, BaseItem> itemDictionary, int oneBasedIndex)
        {
            List<string> itemNames = new List<string>(itemDictionary.Keys);

            int zeroBasedIndex = oneBasedIndex - 1;

            if (zeroBasedIndex >= 0 && zeroBasedIndex < itemNames.Count)
            {
                return itemNames[zeroBasedIndex];
            }
            else
            {
                throw new IndexOutOfRangeException($"Error: Invalid index {oneBasedIndex} provided for item selection.");
            }
        }


        public static string GetItemNameByIndex(Dictionary<string, ComplexItem> itemDictionary, int oneBasedIndex)
        {
            List<string> itemNames = new List<string>(itemDictionary.Keys);

            int zeroBasedIndex = oneBasedIndex - 1;

            if (zeroBasedIndex >= 0 && zeroBasedIndex < itemNames.Count)
            {
                return itemNames[zeroBasedIndex];
            }
            else
            {
                throw new IndexOutOfRangeException($"Error: Invalid index {oneBasedIndex} provided for item selection.");
            }
        }
    }
}

