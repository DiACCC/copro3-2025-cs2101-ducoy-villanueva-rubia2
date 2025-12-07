using System;

namespace Codes.Description.ParentItems
{

    public class BaseItem // Clothing (Shirt, Pants, Shoes, Cape, Vest, Gloves, Neckware)
    {
        protected string name;
        protected string description;
        protected string category; // shirt, pants, armor etc
        protected int health, stamina, strenght, haste, agility, defense, poise;

        public BaseItem(string name, string category, string description, int health, int stamina, int strenght, int haste, int agility, int defense, int poise)
        {
            this.name = name;
            this.description = description;
            this.category = category;
            this.health = health;
            this.stamina = stamina;
            this.strenght = strenght;
            this.haste = haste;
            this.agility = agility;
            this.defense = defense;
            this.poise = poise;
        }

        public int getPoise() { return this.poise; }
        public void addPoise(int value) { this.poise += value; }
        public void minusPoise(int value) { this.poise -= value; }

        public int getDefense() { return this.defense; }
        public void addDefense(int value) { this.defense += value; }
        public void minusDefense(int value) { this.poise -= value; }

        public int getAgility() { return this.agility; }
        public void addAgility(int value) { this.agility += value; }
        public void minusAgility(int value) { this.poise -= value; }

        public int getHaste() { return this.haste; }
        public void addHaste(int value) { this.haste += value; }
        public void minusHaste(int value) { this.poise -= value; }

        public int getStrenght() { return this.strenght; }
        public void addStrenght(int value) { this.strenght += value; }
        public void minusStrenght(int value) { this.poise -= value; }

        public int getStamina() { return this.stamina; }
        public void addStamina(int value) { this.stamina += value; }
        public void minusStamina(int value) { this.poise -= value; }

        public int getHealth() { return this.health; }
        public void addHealth(int value) { this.health += value; }
        public void minusHealth(int value) { this.poise -= value; }

        public BaseItem(string name, string category)
        {
            this.name = name;
            this.category = category;
        }

        public BaseItem(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public string getCategory()
        {
            return this.category;
        }
    } 

    public class ComplexItem : BaseItem // Armor, Accessories, Weapon, Companion
    {
        protected string moreDescription;

        public ComplexItem(string name, string category, string description, string more, int health, int stamina, int strenght, int haste, int agility, int defense, int poise) : base(name, category, description, health, stamina, strenght, haste, agility, defense, poise)
        {
            this.moreDescription = more;
        }


        public void setMoreDescription(string moreDescription)
        {
            this.moreDescription = moreDescription;
        }

        public string getMoreDescription()
        {
            return this.moreDescription;
        }

    }
}
