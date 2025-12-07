using System;
using Microsoft.Data.Sqlite;
using Character_Creation_Prototype.Codes.CoreSystem.CharacterClass;

namespace Codes.CoreSystem.SQLite
{
    
    class SQLiteClass
    {
        public static Character LoadCharacter(string characterName)
        {
            Character loadedChar = new Character(characterName);

            using (var myConnection = new SqliteConnection("Data Source=DatabaseCharacterCreation1.sqlite"))
            {
                myConnection.Open();

                string visualCmd = "SELECT * FROM Character_Save WHERE Name = @Name";

                Console.Clear();

                using (var cmd = new SqliteCommand(visualCmd, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", characterName);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map Database Columns -> Character Class Methods
                            loadedChar.setRace(reader["Race"].ToString());
                            loadedChar.setGender(reader["Gender"].ToString());
                            loadedChar.setHair(reader["Hair"].ToString());
                            loadedChar.setSkinColor(reader["SkinColor"].ToString());

                            // Equipment
                            loadedChar.setShirt(reader["Shirt"].ToString());
                            loadedChar.setPants(reader["Pants"].ToString());
                            loadedChar.setShoes(reader["Shoes"].ToString());
                            loadedChar.setCape(reader["Cape"].ToString() == "1" || reader["Cape"].ToString() == "True"); // Handle Bool logic
                            loadedChar.setVest(reader["Vest"].ToString());
                            loadedChar.setGloves(reader["Gloves"].ToString());
                            loadedChar.setNeckware(reader["Neckware"].ToString());
                            loadedChar.setHead(reader["Helmet"].ToString());
                            loadedChar.setChest(reader["ChestArmor"].ToString());
                            loadedChar.setArm(reader["ArmGuard"].ToString());
                            loadedChar.setWaist(reader["WaistDown"].ToString());

                            // Items
                            loadedChar.setAccessories(reader["CharmItem"].ToString());
                            loadedChar.setMainWeapon(reader["MainWeapon"].ToString());
                            loadedChar.setSubWeapon(reader["SubWeapon"].ToString());
                            loadedChar.setShield(reader["Shield"].ToString());
                            loadedChar.setCompanion(reader["Companion"].ToString());

                            // set Stats
                            int hp = Convert.ToInt32(reader["Health"]);
                            int stam = Convert.ToInt32(reader["Stamina"]);
                            int str = Convert.ToInt32(reader["Strength"]);
                            int haste = Convert.ToInt32(reader["Haste"]);
                            int agi = Convert.ToInt32(reader["Agility"]);
                            int def = Convert.ToInt32(reader["Defense"]);
                            int poise = Convert.ToInt32(reader["Poise"]);

                            loadedChar.setWholeBaseStatsChar(hp, stam, str, haste, agi, def, poise);
                        }
                    }
                }

            }

            Console.WriteLine("Character Loaded Successfully!");
            return loadedChar; 
        }

        public static List<string> GetCharacterNames()
        {
            List<string> names = new List<string>();

            using (var myConnection = new SqliteConnection("Data Source=DatabaseCharacterCreation1.sqlite"))
            {
                myConnection.Open();

                string commandText = "SELECT Name FROM Character_Save";

                using (var cmd = new SqliteCommand(commandText, myConnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            names.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return names;
        }

        public static void DeleteCharacter(string characterName)
        {
            using (var myConnection = new SqliteConnection("Data Source=DatabaseCharacterCreation1.sqlite"))
            {
                myConnection.Open();

                string commandText = "DELETE FROM Character_Save WHERE Name = @Name";

                using (var cmd = new SqliteCommand(commandText, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", characterName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Successfully deleted character: {characterName}");
                    }
                    else
                    {
                        Console.WriteLine($"Character '{characterName}' was not found.");
                    }
                }
            }
        }

        public static void SaveCharacter(Character data)
        {
            using (var myConnection = new SqliteConnection("Data Source=DatabaseCharacterCreation1.sqlite"))
            {
                myConnection.Open();

                string commandText = @"
                INSERT OR REPLACE INTO Character_Save (
                    Name, Race, Gender, Hair, SkinColor, 
                    Shirt, Pants, Shoes, Cape, Vest, 
                    Gloves, Neckware, Helmet, ChestArmor, ArmGuard, 
                    WaistDown, CharmItem, MainWeapon, SubWeapon, Shield, 
                    Companion, Health, Stamina, Strength, Haste, 
                    Agility, Defense, Poise
                ) 
                VALUES (
                    @Name, @Race, @Gender, @Hair, @SkinColor, 
                    @Shirt, @Pants, @Shoes, @Cape, @Vest, 
                    @Gloves, @Neckware, @Helmet, @ChestArmor, @ArmGuard, 
                    @WaistDown, @CharmItem, @MainWeapon, @SubWeapon, @Shield, 
                    @Companion, @Health, @Stamina, @Strength, @Haste, 
                    @Agility, @Defense, @Poise
                )";

                using (var cmd = new SqliteCommand(commandText, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", data.getName());
                    cmd.Parameters.AddWithValue("@Race", data.getRace());
                    cmd.Parameters.AddWithValue("@Gender", data.getGender());
                    cmd.Parameters.AddWithValue("@Hair", data.getHair());
                    cmd.Parameters.AddWithValue("@SkinColor", data.getSkinColor());

                    cmd.Parameters.AddWithValue("@Shirt", data.getShirt());
                    cmd.Parameters.AddWithValue("@Pants", data.getPants());
                    cmd.Parameters.AddWithValue("@Shoes", data.getShoes());
                    cmd.Parameters.AddWithValue("@Cape", data.getCape());
                    cmd.Parameters.AddWithValue("@Vest", data.getVest());

                    cmd.Parameters.AddWithValue("@Gloves", data.getGloves());
                    cmd.Parameters.AddWithValue("@Neckware", data.getNeckware()); 
                    cmd.Parameters.AddWithValue("@Helmet", data.getHead());       
                    cmd.Parameters.AddWithValue("@ChestArmor", data.getChest());
                    cmd.Parameters.AddWithValue("@ArmGuard", data.getArm());

                    cmd.Parameters.AddWithValue("@WaistDown", data.getWaist());
                    cmd.Parameters.AddWithValue("@CharmItem", data.getAccessories());
                    cmd.Parameters.AddWithValue("@MainWeapon", data.getMainWeapon());
                    cmd.Parameters.AddWithValue("@SubWeapon", data.getSubWeapon());
                    cmd.Parameters.AddWithValue("@Shield", data.getShield());
                    cmd.Parameters.AddWithValue("@Companion", data.getCompanion());

                    cmd.Parameters.AddWithValue("@Health", data.getHealth());
                    cmd.Parameters.AddWithValue("@Stamina", data.getStamina());
                    cmd.Parameters.AddWithValue("@Strength", data.getStrength());
                    cmd.Parameters.AddWithValue("@Haste", data.getHaste());
                    cmd.Parameters.AddWithValue("@Agility", data.getAgility());
                    cmd.Parameters.AddWithValue("@Defense", data.getDefense());
                    cmd.Parameters.AddWithValue("@Poise", data.getPoise());

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Character Visual Data Saved Successfully!");
                }
            }
        }

        public static void CreateConnection()
        {
            using (var myConnection = new SqliteConnection("Data Source=DatabaseCharacterCreation1.sqlite"))
            {
                myConnection.Open();
                Console.WriteLine("Database Connected Successfully!");

                string charTableCommand = @"
                    CREATE TABLE IF NOT EXISTS Character_Save (
                        Name TEXT PRIMARY KEY,
                        Race TEXT, 
                        Gender TEXT, 
                        Hair TEXT, 
                        SkinColor TEXT,
                        Shirt TEXT,
                        Pants TEXT,
                        Shoes TEXT,
                        Cape TEXT,
                        Vest TEXT,
                        Gloves TEXT,
                        Neckware TEXT,
                        Helmet TEXT,
                        ChestArmor TEXT,
                        ArmGuard TEXT,
                        WaistDown TEXT,
                        CharmItem TEXT,
                        MainWeapon TEXT,
                        SubWeapon TEXT,
                        Shield INTEGER,
                        Companion TEXT,
                        Health INTEGER,
                        Stamina INTEGER,
                        Strength INTEGER,
                        Haste INTEGER,
                        Agility INTEGER,
                        Defense INTEGER,
                        Poise INTEGER
                    )";

                using (var charCreateCommand = new SqliteCommand(charTableCommand, myConnection))
                {
                    charCreateCommand.ExecuteNonQuery();
                    Console.WriteLine("Database Setting 1 Executed Successfully!");
                }

                Thread.Sleep(1500);
                Console.Clear();

            }
        }


    }
}
