using System;
using System.Runtime.CompilerServices;

namespace Character_Creation_Prototype.Codes.CoreSystem.CharacterClass
{
    public abstract class CharacterStats
    {
        //base stats
        protected int health = 0;
        protected int stamina = 0;
        protected int strength = 0;
        protected int haste = 0;
        protected int agility = 0;
        protected int defense = 0;
        protected int poise = 0;

        //Total stats from additional stats from equipments
        protected int totalHealth = 0;
        protected int totalStamina = 0;
        protected int totalStrength = 0;
        protected int totalHaste = 0;
        protected int totalAgility = 0;
        protected int totalDefense = 0;
        protected int totalPoise = 0;

        //Total Stats with additional stats
        public int getTotalPoise() { return this.totalPoise; }
        public void setTotalPoise(int value) { this.totalPoise = value; }

        public int getTotalDefense() { return this.totalDefense; }
        public void setTotalDefense(int value) { this.totalDefense = value; }

        public int getTotalHealth() { return this.totalHealth; }
        public void setTotalHealth(int value) { this.totalHealth = value; }

        public int getTotalStamina() { return this.totalStamina; }
        public void setTotalStamina(int value) { this.totalStamina = value; }

        public int getTotalStrength() { return this.totalStrength; }
        public void setTotalStrength(int value) { this.totalStrength = value; }

        public int getTotalHaste() { return this.totalHaste; }
        public void setTotalHaste(int value) { this.totalHaste = value; }

        public int getTotalAgility() { return this.totalAgility; }
        public void setTotalAgility(int value) { this.totalAgility = value; }


        public void addTotalPoise(int value) { this.totalPoise += value; }

        public void addTotalDefense(int value) { this.totalDefense += value; }

        public void addTotalHealth(int value) { this.totalHealth += value; }

        public void addTotalStamina(int value) { this.totalStamina += value; }

        public void addTotalStrength(int value) { this.totalStrength += value; }

        public void addTotalHaste(int value) { this.totalHaste += value; }

        public void addTotalAgility(int value) { this.totalAgility += value; }

        //Base stats
        public int getPoise() { return this.poise; }
        public void addPoise(int value) { this.poise += value; }

        public int getDefense() { return this.defense; }
        public void addDefense(int value) { this.defense += value; }

        public int getHealth() { return this.health; }
        public void addHealth(int value) { this.health += value; }

        public int getStamina() { return this.stamina; }
        public void addStamina(int value) { this.stamina += value; }

        public int getStrength() { return this.strength; }
        public void addStrength(int value) { this.strength += value; }

        public int getHaste() { return this.haste; }
        public void addHaste(int value) { this.haste += value; }

        public int getAgility() { return this.agility; }
        public void addAgility(int value) { this.agility += value; }

    }

    public abstract class CharacterFeatures : CharacterStats
    {
        protected string name, race, gender, skinColor, hair;


        public string getName() { return this.name; }
        public void setName(string value) { this.name = value; }

        public string getRace() { return this.race; }
        public void setRace(string value) { this.race = value; }

        public string getGender() { return this.gender; }
        public void setGender(string value) { this.gender = value; }

        public string getSkinColor() { return this.skinColor; }
        public void setSkinColor(string value) { this.skinColor = value; }

        public string getHair() { return this.hair; }
        public void setHair(string value) { this.hair = value; }

    }

    public abstract class CharacterCompanion : CharacterFeatures
    {
        protected string companion;

        public string getCompanion() { return this.companion; }
        public void setCompanion(string value) { this.companion = value; }
    }

    public abstract class CharacterEquipment : CharacterCompanion
    {
        protected string shirt, pants, shoes, vest, gloves, neckware, head, chest, arm, waist, accessories, mainWeapon, subWeapon, shield;
        protected bool cape;

        public abstract void setClothes(string shirt, string pants, string shoes, string vest, string gloves);


        public void setShield(string value) { this.shield = value; }
        public void setSubWeapon(string value) { this.subWeapon = value; }
        public void setMainWeapon(string value) { this.mainWeapon = value; }
        public void setAccessories(string value) { this.accessories = value; }
        public void setWaist(string value) { this.waist = value; }
        public void setArm(string value) { this.arm = value; }
        public void setChest(string value) { this.chest = value; }
        public void setHead(string value) { this.head = value; }
        public void setNeckware(string value) { this.neckware = value; }
        public void setGloves(string value) { this.gloves = value; }
        public void setVest(string value) { this.vest = value; }
        public void setCape(bool value) { this.cape = value; }

        public void setShoes(string value) { this.shoes = value; }
        public void setPants(string value) { this.pants = value; }
        public void setShirt(string value) { this.shirt = value; }


        public string getShield() { return this.shield; }
        public string getSubWeapon() { return this.subWeapon; }
        public string getMainWeapon() { return this.mainWeapon; }
        public string getAccessories() { return this.accessories; }
        public string getWaist() { return this.waist; }
        public string getArm() { return this.arm; }
        public string getChest() { return this.chest; }
        public string getHead() { return this.head; }
        public string getNeckware() { return this.neckware; }
        public string getGloves() { return this.gloves; }
        public string getVest() { return this.vest; }
        public bool getCape() { return this.cape; }

        public string getShoes() { return this.shoes; }
        public string getPants() { return this.pants; }
        public string getShirt() { return this.shirt; }

    }

    public class Character : CharacterEquipment
    {

        public Character(string name, string race, string gender, string skinColor)
        {
            this.name = name;
            this.race = race;
            this.gender = gender;
            this.skinColor = skinColor;

            // Default clothes
            // this.setClothes("Chemise", "Hose", "Simple Anker", "Garen Short Sleeves", "Archer Gloves");
        }

        public Character(string name)
        {
            this.name = name;

            // Initialize others to default "Unknown" so they aren't null
            this.race = "Unknown";
            this.gender = "Unknown";
            this.skinColor = "Unknown";

            // this.setClothes("Chemise", "Hose", "Simple Anker", "Garen Short Sleeves", "Archer Gloves");
        }

        

        public void setWholeBaseStatsChar(int health, int stamina, int strenght, int haste, int agility, int defense, int poise)
        {
            this.health = health; 
            this.stamina = stamina;
            this.strength = strenght;
            this.haste = haste;
            this.agility = agility;
            this.defense = defense;
            this.poise = poise;

            this.totalHealth = this.health;
            this.totalStamina = this.stamina;
            this.totalStrength = this.strength;
            this.totalHaste = this.haste;
            this.totalAgility = this.agility;
            this.totalDefense = this.defense;
            this.totalPoise = this.poise;
        }

        public override void setClothes(string shirt, string pants, string shoes, string vest, string gloves)
        {
            this.shirt = shirt;
            this.pants = pants;
            this.shoes = shoes;
            this.vest = vest;
            this.gloves = gloves;
        }

        
    }
}
