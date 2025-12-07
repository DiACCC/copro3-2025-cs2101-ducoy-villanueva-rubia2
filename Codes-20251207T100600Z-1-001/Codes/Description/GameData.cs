using System;
using Codes.Description.ParentItems;

namespace Codes.Description.Dictionary
{
    public static class GameData
    {
        // I. BODY FEATURES - DICTIONARIES

        public static byte maxOptionRace = 5;
        public static Dictionary<string, BaseItem> race = new Dictionary<string, BaseItem>()
        {
            {"Human", new BaseItem(
                "Human",
                "Race",
                "A human, an ordinary character that has a balanced stats without any special abilities but has access to all skills.",
                100, // health
                50, // stamina
                50, // strenght
                50, // haste
                10, // agility
                0, // defense
                30 // poise
                )},
            {"Elf", new BaseItem(
                "Elf",
                "Race",
                "An Elf is a slender, graceful, and long-lived humanoid that has pointy ears. They have a strong connection to nature.\r\nThey have a higher stamina recovery and a high mobility but they have lower health points compared to humans.\r\n",
                75, // health
                80, // stamina
                80, // strenght
                40, // haste
                15, // agility
                0, // defense
                15 // poise
                )},
             {"Orc", new BaseItem(
                "Orc",
                "Race",
                "An Orc is squat, broad, flat-nosed, sallow-skinned, with wide mouths and slant eyes, they are bigger than humans and elves and have a larger body compared to them.\r\nBecause of this they have higher health points and a strong attack damage, in return they move slower compared to humans and elves and also have a lower efficiency in attacks.\r\nDue to their massive physique, they have more powerful arms that can wield heavy armaments with one hand.\r\n",
                150, // health
                100, // stamina
                0, // strenght
                100, // haste
                7, // agility
                0, // defense
                50 // poise
                 )},
             {"Draconian", new BaseItem(
                "Draconian",
                "Race",
                "A Draconian is a powerful humanoid defined by their reptilian heritage.\r\nThey possess thick, burnished scales, strong clawed limbs, and often large, folded wings that suggest a capacity for flight.\r\nDue to their imposing, muscular physique, they have inherently higher physical fortitude and strength compared to other races.\r\nHowever, this bulk often results in a lower overall movement speed and limits their natural grace.\r\n",
                125, // health
                90, // stamina
                70, // strenght
                10, // haste
                18, // agility
                0, // defense
                40 // poise
                 )},
             {"Merfolk", new BaseItem(
                "Merfolk",
                "Race",
                "Merfolk are elegant, aquatic humanoids, characterized by their iridescent fish tail replacing their lower limbs. \r\nNaturally adapted to deep water, they possess exceptional speed and grace in aquatic environments.\r\nWhile their slender physique grants them high mobility and fluid movement, they possess less natural durability than surface dwellers.\r\nUnique Ability = Ocean’s grace - Moves faster in water.\r\n",
                100, // health
                80, // stamina
                60, // strenght
                13, // haste
                20, // agility
                0, // defense
                35 // poise
                 )},
        };

        public static byte maxOptionGender = 2;
        public static Dictionary<string, BaseItem> gender = new Dictionary<string, BaseItem>()
        {
            {"Male", new BaseItem(
                "Male",
                "Gender",
                "Lalake",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Female", new BaseItem(
                "Female",
                "Gender",
                "Babae",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

            public static byte maxOptionFemaleHair = 6;
            public static Dictionary<string, BaseItem> femaleHair = new Dictionary<string, BaseItem>()
    {
        {"Pixie", new BaseItem(
            "Pixie",
            "Female Hair",
            "A short, cropped cut that frames the face. Favored by scouts and agile fighters who prefer nothing to grab onto in a skirmish.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Waterfall", new BaseItem(
            "Waterfall",
            "Female Hair",
            "Long, flowing locks that cascade down the back like a river. Symbolizes grace and an untamed spirit, though high maintenance.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Braids", new BaseItem(
            "Braids",
            "Female Hair",
            "Tight, interlaced plaits designed to keep hair secure during battle while displaying intricate tribal or noble patterns.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Valkyrie", new BaseItem(
            "Valkyrie",
            "Female Hair",
            "A warrior's style with shaved sides and a high knot or crest, invoking the fierce spirit of the legendary choosers of the slain.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Bun", new BaseItem(
            "Bun",
            "Female Hair",
            "Hair pulled back tightly into a spherical coil. Represents discipline, order, and a focus purely on the task at hand.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Ponytail", new BaseItem(
            "Ponytail",
            "Female Hair",
            "Simple and practical, hair gathered at the back to ensure clear vision while maintaining a youthful, energetic appearance.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
    };

            public static byte maxOptionMaleHair = 5;
            public static Dictionary<string, BaseItem> maleHair = new Dictionary<string, BaseItem>()
    {
        {"Clean Cut", new BaseItem(
            "Clean Cut",
            "Male Hair",
            "A neat, trimmed style that suggests nobility, discipline, or a man who takes pride in a civilized appearance.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Buzz", new BaseItem(
            "Buzz",
            "Male Hair",
            "Hair clipped extremely close to the scalp. Low maintenance and utilitarian, ideal for wearing heavy helmets comfortably.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Undercut", new BaseItem(
            "Undercut",
            "Male Hair",
            "Short sides with length on top, a style popular among mercenaries and city-dwellers seeking a sharp, dangerous look.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Bald Eagle", new BaseItem(
            "Bald Eagle",
            "Male Hair",
            "A completely shaved head that gleams in the sun. Aerodynamic and intimidating, showing a veteran's scars.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
        {"Viking Cut", new BaseItem(
            "Viking Cut",
            "Male Hair",
            "Long, swept-back hair often paired with a beard. The mark of a raider who thrives in the frozen wilds.",
            0, // health
            0, // stamina
            0, // strenght
            0, // haste
            0, // agility
            0, // defense
            0 // poise
            )},
};

        public static byte maxOptionSkinColor = 3;
        public static Dictionary<string, BaseItem> skinColor = new Dictionary<string, BaseItem>()
        {
            {"Fair", new BaseItem(
                "Fair",
                "Skin Color",
                "Very light skin that often burns easily and rarely tans.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Light", new BaseItem(
                "Light",
                "Skin Color",
                "Slightly darker than fair skin, this tone may tan but can also burn.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Deep", new BaseItem(
                "Deep",
                "Skin Color",
                "The darkest skin tone, ranging from rich brown to black, which is very resistant to sun damage.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        public static byte maxOptionShirt = 5;
        public static Dictionary<string, BaseItem> shirt = new Dictionary<string, BaseItem>()
        {
            {"Chemise", new BaseItem(
                "Chemise",
                "Shirt",
                "A simple, lightweight linen or wool undergarment worn next to the skin by all classes to protect outer \r\nclothes from sweat and oil.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Tunic", new BaseItem(
                "Tunic",
                "Shirt",
                "A basic, knee-length or shorter garment worn over the chemise, serving as the main body covering for \r\nmen of all social ranks.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Tabard", new BaseItem(
                "Tabard",
                "Shirt",
                "A simple, short-sleeved or sleeveless heavy cloth or leather garment often decorated with a coat of \r\narms, traditionally worn over armor by knights and men-at-arms.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Dalmatic", new BaseItem(
                "Dalmatic",
                "Shirt",
                "A long, wide-sleeved tunic, often richly embroidered or decorated, originally associated with \r\nByzantine and religious attire, later worn by nobility.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Bliaut", new BaseItem(
                "Bliaut",
                "Shirt",
                "A luxurious, form-fitting outer garment for noblemen and women in the 12th and 13th centuries, often \r\nfeaturing long, trailing sleeves and complex lacing.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},

        };

        public static byte maxOptionPants = 5;
        public static Dictionary<string, BaseItem> pants = new Dictionary<string, BaseItem>()
        {
            {"Hose", new BaseItem(
                "Hose",
                "Pants",
                "Fitted garments for the legs, often worn with a tunic and attached to the belt or a separate \r\nundergarment called braies.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Undertunic", new BaseItem(
                "Undertunic",
                "Pants",
                "A secondary, protective tunic worn directly over the chemise and under the surcoat or main \r\ngarment.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Surcoat", new BaseItem(
                "Surcoat",
                "Pants",
                "A long, sleeveless, or short-sleeved garment worn over the tunic, which could be functional (to \r\nprotect clothes/armor from the sun) or decorative (for display).\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Braies", new BaseItem(
                "Surcoat",
                "Pants",
                "Loose-fitting linen undergarments resembling shorts or drawers, tied at the waist, and worn beneath \r\nthe hose.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Chausses", new BaseItem(
                "Surcoat",
                "Pants",
                "A term often used interchangeably with hose, specifically referring to mail or padded leg protection \r\nfor armored warriors.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},

        };

        public static byte maxOptionShoes = 5;
        public static Dictionary<string, BaseItem> shoes = new Dictionary<string, BaseItem>()
        {
            {"Simple Anker", new BaseItem(
                "Simple Anker",
                "Shoes",
                "Basic, low-cut leather shoes that cover the foot up to the ankle, typical of common folk.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Poulines", new BaseItem(
                "Poulines",
                "Shoes",
                "Extremely long and pointed shoes, popular among the nobility in the 14th and 15th centuries, \r\nsometimes requiring a whalebone stiffener or a chain to hold the point up.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Anglo-Saxon", new BaseItem(
                "Anglo-Saxon",
                "Shoes",
                "Simple, often turn-shoe construction boots or shoes, commonly made of leather and worn for \r\ndaily activities across the period.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Boots", new BaseItem(
                "Boots",
                "Shoes",
                "High-cut leather footwear, often reaching the calf or knee, typically worn for riding, travel, or by soldiers \r\nfor greater protection.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Cloggs", new BaseItem(
                "Cloggs",
                "Shoes",
                "Wooden-soled shoes worn over other footwear, used primarily in muddy or wet conditions to lift the \r\nleather shoe out of the muck.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},

        };

        public static byte maxOptionCape = 5;
        public static Dictionary<string, BaseItem> cape = new Dictionary<string, BaseItem>()
        {
            {"Traveler’s Cloak", new ComplexItem(
                "Traveler’s Cloak", // Name
                "Cape", // Category
                "A lightweight, weather-resistant cloak made from tightly woven wool.\r\nThis cape is designed for long journeys, offering protection against rain, wind, and rough terrain.\r\nIts simple design provides minimal defense, but grants increased mobility and stamina due to its comfort and durability.", // Description
                "(Agility +2, Stamina +10, Defense +3)",
                0, // health
                10, // stamina
                0, // strenght
                0, // haste
                2, // agility
                3, // defense
                0 // poise
                )},

            {"Knight’s Mantle", new ComplexItem(
                "Knight’s Mantle", // Name
                "Cape", // Category
                "A heavy, reinforced cape worn over armor by knights and elite soldiers.\r\nConstructed from thick wool or layered fabric, sometimes lined with leather, it offers modest protection against slashes and environmental hazards.\r\nIts weight slightly reduces mobility, but its presence symbolizes authority, discipline, and battlefield readiness. ", // Description
                "(Agility -1, Defense +7, Haste -1)",
                0, // health
                0, // stamina
                0, // strenght
                -1, // haste
                -1, // agility
                7, // defense
                0 // poise
                )},
            {"Ranger’s Hooded Cloak", new ComplexItem(
                "Ranger’s Hooded Cloak", // Name
                "Cape", // Category
                "A dark-colored, hooded cloak favored by scouts, trackers, and archers.\r\nIts matte fabric reduces noise and blends with natural surroundings, improving stealth and concealment. (Less \r\nlikely to be targeted by enemies)\r\nThis cape provides minor insulation and grants bonuses to mobility and stealth-based actions.\r\n", // Description
                "(Less likely to be targeted, Agility +2)",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                2, // agility
                0, // defense
                0 // poise
                )},
            {"Guardian’s Cloak", new ComplexItem(
                "Guardian’s Cloak", // Name
                "Cape", // Category
                "A durable, reinforced cloak worn by temple guardians and elite protectors.\r\nCrafted from layered wool and lined with thin leather, it offers better resistance against slashes and harsh weather than a standard cloak.\r\n\r\nAlthough slightly heavier, it grants improved defense and stability, making the wearer harder to stagger during \r\ncombat.\r\n", // Description
                "(Defense +7, Poise +5, Stamina +5)",
                0, // health
                5, // stamina
                0, // strenght
                0, // haste
                0, // agility
                7, // defense
                5 // poise
                )},
            {"Battle-Worn War Cloak", new ComplexItem(
                "Battle-Worn War Cloak", // Name
                "Cape", // Category
                "A rugged, thick cloak often stained and torn from previous battles.\r\nMade from heavy wool or leather-backed fabric, it offers moderate protection from harsh weather and glancing \r\nattacks.\r\nIts weight slows movement slightly, but it conveys experience, resilience, and battlefield presence.\r\n", // Description
                "(Strength +5, Agility -1, Poise +5)",
                0, // health
                0, // stamina
                5, // strenght
                0, // haste
                -1, // agility
                0, // defense
                5 // poise
                )},
        };

        public static byte maxOptionVest = 5;
        public static Dictionary<string, BaseItem> vest = new Dictionary<string, BaseItem>()
        {
            {"Garen Short Sleeves", new BaseItem(
                "Garen Short Sleeves",
                "Vest",
                "A sleeveless or short-sleeved fitted garment worn over a tunic, potentially for minor protection or warmth.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Penda Suede Jerkin", new BaseItem(
                "Penda Suede Jerkin",
                "Vest",
                "A sturdy, sleeveless jacket made from soft deerskin or other suede leather, often worn for work or travel.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Geoffrey Canvas", new BaseItem(
                "Geoffrey Canvas",
                "Vest",
                "A stiff, close-fitting jacket made of heavy woven cloth, typically padded for insulation and minor defense.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Doublet", new BaseItem(
                "Doublet",
                "Vest",
                "A close-fitting, often padded jacket worn from the 14th century onward, serving as a primary garment and base layer for attaching armor.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Gipon", new BaseItem(
                "Gipon",
                "Vest",
                "A form of padded jacket, similar to a doublet, often worn beneath a coat of mail to absorb the shock of blows.",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        public static byte maxOptionGloves = 5;
        public static Dictionary<string, BaseItem> gloves = new Dictionary<string, BaseItem>()
        {
            {"Archer Gloves", new BaseItem(
                "Archer Gloves",
                "Gloves",
                "Light leather gloves designed with reinforced fingers to protect the hand from the bowstring \r\nwithout restricting movement.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Swordman Gloves", new BaseItem(
                "Swordman Gloves",
                "Gloves",
                "Sturdy, often fingerless or mitten-style gloves with leather or metal reinforcements to \r\nprotect the hands during sword fighting.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Mufflers", new BaseItem(
                "Mufflers",
                "Gloves",
                "Simple, often wool or knitted hand coverings worn by commoners in cold weather, usually without\r\nindividual fingers.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Plate Gauntlets", new BaseItem(
                "Plate Gauntlets",
                "Gloves",
                "Articulated metal gloves, crucial pieces of armor designed to completely encase and protect \r\nthe warrior's hand.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Falconer's Glove", new BaseItem(
                "Falconer's Glove",
                "Gloves",
                "A heavy, long leather glove worn on the arm to protect the handler from the talons of a bird \r\nof prey.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        public static byte maxOptionNeckware = 5;
        public static Dictionary<string, BaseItem> neckware = new Dictionary<string, BaseItem>()
        {
            {"Wimples", new BaseItem(
                "Wimples",
                "Neckware",
                "A piece of cloth draped and pinned around the neck and chin, often covering the hair, worn primarily \r\nby married women in the High and Late Middle Ages.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Gorgets", new BaseItem(
                "Gorgets",
                "Neckware",
                "A piece of steel or leather armor specifically designed to protect the throat and the base of the neck, \r\nworn as part of a full harness.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Scarves", new BaseItem(
                "Scarves",
                "Neckware",
                "Simple lengths of cloth tied or wrapped around the neck for warmth or as a decorative accessory,\r\nsimilar to modern scarves.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},

            {"Partlet", new BaseItem(
                "Partlet",
                "Neckware",
                "A decorative and protective fill-in worn over the neck and upper chest, often made of fine linen, worn \r\nto achieve a more modest look with low-cut gowns.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Coif", new BaseItem(
                "Coif",
                "Neckware",
                "A close-fitting linen or padded cap covering the top, back, and sides of the head, often worn under a \r\nhelmet or by common workers.\r\n",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        // armor
        public static byte maxOptionHelmet = 5;
        public static Dictionary<string, ComplexItem> helmet = new Dictionary<string, ComplexItem>()
        {
             {"Veteran Archer", new ComplexItem(
                "Veteran Archer",
                "Helmet",
                "The Veteran Archer Helmet is a style of historical or reenactment gear, such as the \r\nWar of the Roses archer helmet, which is designed to provide head protection while maintaining the \r\nunimpeded vision needed for archery. \r\n",
                "(Poise +10, Defense +15, Agility -1)",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                -1, // agility
                15, // defense
                10 // poise

                )},
             {"Veteran Man-at-Arms", new ComplexItem(
                "Veteran Man-at-Arms",
                "Helmet",
                "The Veteran Man-at-Arms Helmet is a high-quality, durable helmet, often with \r\nfull-face protection, suitable for experienced soldiers who are part of a larger, heavily armored fighting force.  \r\n",
                "(Poise +10, Defense +17, Agility -2)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                10 // poise
                )},
             {"Veteran Vanguard", new ComplexItem(
                "Veteran Knight",
                "Helmet",
                "The Veteran Vanguard Helmet is a helmet for elite jump pack assault troops who \r\nuse high-quality melee weapons and can reach combat quickly. This piece of armor is designed for quick and \r\nfast combat pace, it is suited for those who use lighter weapons. \r\n",
                "(Poise +7, Defense +10, Agility +2)",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                2, // agility
                10, // defense
                7 // poise
                )},
             {"Veteran Knight", new ComplexItem(
                "Veteran Knight",
                "Helmet",
                "The Veteran Knight Helmet is a piece of armor that is both historically inspired and \r\nfunctional, designed to provide full head protection with features like a full visor, cheek plates, and a neck \r\nguard. This is the most durable and provides one of the most defense out of all the other helmets.  \r\n",
                "(Poise +15, Defense+20, -1 Agility)",
                0, // health
                0, // stamina
                0, // strenght
                0, // haste
                -1, // agility
                20, // defense
                15 // poise
                )},
             {"Bruiser", new ComplexItem(
                "Bruiser",
                "Helmet",
                "The Bruiser Helmet’s visibility is poor, but it offers substantial protection for the head. It is a \r\nmedium helmet that provides moderate head protection. The helmet prioritizes the wearer's safety in combat \r\nover their vision. In exchange to this, those who wear this equipment gain a great amount of resistance against \r\ntheir opponents. \r\n",
                "Poise +20, Defense+17, +15 HealthPoints, -10 Stamina",
                15, // health
                -10, // stamina
                0, // strenght
                0, // haste
                0, // agility
                17, // defense
                20 // poise
                )},


        };

        public static byte maxOptionChestArmor = 5;
        public static Dictionary<string, ComplexItem> chestArmor = new Dictionary<string, ComplexItem>()
        {
            {"Cuirass", new ComplexItem(
                 "Cuirass",
                 "Chest Armor",
                 "The Cuirass is a piece of armor that covers the torso, consisting of a breastplate for the front and a \r\nbackplate for the back, fastened together to protect the wearer's chest and back from the neck to the waist. It \r\nprovides high armor as well as providing the wearer more sustainability to damage. \r\n",
                 "(Poise +30, Defense+25, Healthpoints +15)",
                15, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                25, // defense
                30 // poise
                )},
            {"Brigandine", new ComplexItem(
                 "Brigandine",
                 "Chest Armor",
                 "The Brigandine is a layered protection system made of small metal plates riveted to a fabric or \r\nleather undercoat, often covered by an outer cloth layer. This provides impressive, durable protection that is \r\ngenerally more flexible than full plate but can come with penalties.\r\n",
                 "(Poise +30, Defense+35, Agility -2, +15 Healthpoints, Haste -1)",
                 15, // health
                0, // stamina
                0, // strenght
                -1, // haste
                -2, // agility
                35, // defense
                30 // poise
                )},
            {"Main Hauberk", new ComplexItem(
                 "Main Hauberk",
                 "Chest Armor",
                 "The Mail Hauberk is a type of long, chainmail shirt that provides good physical protection but \r\nis often heavy and can limit movement. It emphasizes the balance between its defense and the fatigue or \r\nmobility penalties it incurs, with some variations being more specialized or ornate. It is often great paired with \r\nheavier weapons.\r\n",
                 "(Poise +30, Defense+30, Stamina -10)",
                 0, // health
                -10, // stamina
                0, // strenght
                0, // haste
                0, // agility
                30, // defense
                30 // poise
                )},
            {"Studded Leather", new ComplexItem(
                 "Studded Leather",
                 "Chest Armor",
                 "The Studded Leather Armor is a light armor made from flexible leather with \r\nhundreds of metal rivets or studs, creating a rigid, flexible, and protective layer that deflects cuts and slashes. It \r\nis great paired with lighter weapons and projectiles. \r\n",
                 "(Poise +25, Defense+20, Haste +2, Stamina +10)",
                 0, // health
                10, // stamina
                0, // strenght
                2, // haste
                0, // agility
                20, // defense
                25 // poise
                )},
            {"Padded", new ComplexItem(
                 "Padded",
                 "Chest Armor",
                 "neckwareeeeeeeee na boi!",
                 "(Poise +25, Defense +25, Agility +3)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                3, // agility
                25, // defense
                25 // poise
                )},
        };

        public static byte maxOptionArmGuard = 5;
        public static Dictionary<string, ComplexItem> armGuard = new Dictionary<string, ComplexItem>()
        {
            {"Vambraces", new ComplexItem(
                 "Vambraces", // Name
                 "Glove", // Category
                 "The Vambraces are armor pieces that cover the forearm, offering protection against attacks. \r\nThey are typically made of leather or metal and can be worn independently or as part of a larger suit of armor, \r\noften connecting to a gauntlet.\r\n", // Description
                 "(Defense +5, Agility +1)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                1, // agility
                5, // defense
                0 // poise
                )},
            {"Rerebraces", new ComplexItem(
                 "Rerebraces", // Name
                 "Glove", // Category
                 "The Rerebraces is a piece of armor that protects the upper arm above the elbow. It typically \r\nforms a tubular or shaped plate, connecting a shoulder defense to the elbow protection.\r\n", // Description
                 "(Defense +7, +1 Haste)",
                 0, // health
                0, // stamina
                0, // strenght
                1, // haste
                0, // agility
                7, // defense
                0 // poise
                )},
            {"Pauldrons", new ComplexItem(
                 "Pauldrons", // Name
                 "Glove", // Category
                 "The Pauldrons are pieces of plate armor that covers the shoulder, evolving from the earlier \r\nspaulder in the 15th century. It typically consists of a large, curved dome for the shoulder joint, with additional \r\nplates to protect the armpit and sometimes parts of the chest and back.\r\n", // Description
                 "(Defense +9)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                9, // defense
                0 // poise
                )},
            {"Gardbrace", new ComplexItem(
                 "Gardbrace", // Name
                 "Glove", // Category
                 "The Gardbrace is a piece of armor that attaches to the pauldron to provide extra protection for the \r\nshoulder and armpit, often used in jousting or tournament armor. It is typically asymmetric and designed to \r\ndeflect blows away from vulnerable areas like the neck and armpit, with larger versions being especially useful \r\nfor blocking lances.\r\n", // Description
                 "(Defence +7, Poise +5)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                7, // defense
                5 // poise
                )},
            {"Spaulder", new ComplexItem(
                 "Spaulder", // Name
                 "Glove", // Category
                 "The Spaulder are pieces of armor that protect the shoulder, typically consisting of a single plate or \r\nmultiple lames that are joined and secured to the upper arm with leather straps and buckles. They can be \r\nmade of steel or other materials like leather and are designed to shield the shoulder joint and upper arm from \r\nstrikes while allowing for freedom of movement.\r\n", // Description
                 "(Defense +5, Stamina +5, Haste +1)",
                 0, // health
                5, // stamina
                0, // strenght
                1, // haste
                0, // agility
                5, // defense
                0 // poise
                )},
        };

        public static byte maxOptionWaist = 5;
        public static Dictionary<string, ComplexItem> waist = new Dictionary<string, ComplexItem>()
        {
            {"Faulds", new ComplexItem(
                 "Faulds", // Name
                 "Waist", // Category
                 "The Faulds is a piece of plate armor worn around the waist and hips to protect them from attacks. \r\nThey consist of overlapping metal plates, or lames, that form an articulated, skirt-like apron extending from the \r\nbottom of a breastplate. \r\n", // Description
                 "(Defense +15)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                15, // defense
                0 // poise
                )},
            {"Cuisses", new ComplexItem(
                 "Cuisses", // Name
                 "Waist", // Category
                 "The Cuisses pieces of medieval armor that protect the thighs, typically made of padded material or\r\n plates of steel. They were worn to protect from thrusts that could bypass other forms of armor.\r\n", // Description
                 "(Defense +15)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                15, // defense
                0 // poise
                )},
            {"Sabaton", new ComplexItem(
                 "Sabaton", // Name
                 "Waist", // Category
                 "The Sabaton is a piece of plate armor that covers and protects the feet, made of articulated, \r\noverlapping metal plates (lames) that were riveted together. They were an essential part of a full suit of armor, \r\nparticularly for mounted knights, and were worn over a shoe or boot. \r\n", // Description
                 "(Defense +15)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                15, // defense
                0 // poise
                )},
            {"Leather War Boots", new ComplexItem(
                 "Leather War Boots", // Name
                 "Waist", // Category
                 "The Leather War Boots are crafted from hardened cuir-bouilli leather, offering reliable protection without restricting movement. The outer layer is toughened through boiling and shaping, giving the boots a rigid shell capable of deflecting glancing blows. Inside, softer leather padding cushions the foot, making them comfortable for long marches. Favored by infantry and scouts, these boots strike a balance between durability, mobility, and weight. \r\n", // Description
                 "(Defense +15)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                15, // defense
                0 // poise
                )},
             {"Quilted Boots", new ComplexItem(
                 "Quilted Boots", // Name
                 "Waist", // Category
                 "The Quilted Boots are Lightweight footwear made from layers of thick cloth, wool, and stitched padding. These boots provide warmth and moderate cushioning, reducing fatigue during travel. Though they lack strong defensive qualities, the dense quilting absorbs minor impacts and prevents chafing beneath heavier armor. They offer basic protection at minimal weight and cost.\r\n(Defense +15)\r\n", // Description
                 "(Defense +15)",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                15, // defense
                0 // poise
                )},

        };

        public static byte maxOptionCharmItems = 5;
        public static Dictionary<string, BaseItem> accessories = new Dictionary<string, BaseItem>()
        {
            {"Crystals", new BaseItem(
                 "Crystals", // Name
                 "Accessories", // Category
                 "These are small, clear, iridescent shards that gracefully orbit the character's head and hands, \r\nproviding a subtle, ethereal visual flair. They catch the light beautifully, gently diffusing it into a spectrum of \r\nfaint, shifting colors for a sparkling effect.\r\n", // Description
                 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Amethyst", new BaseItem(
                 "Amethyst", // Name
                 "Accessories", // Category
                 "This artifact is a large, polished geode of deep, regal purple, often worn on a belt or shoulder strap \r\nfor visual impact. While stationary, the Amethyst subtly pulses, emitting a gentle, warm violet light that \r\nmomentarily illuminates the immediate surroundings\r\n.", // Description
                 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Sunstone Pendant", new BaseItem(
                 "Sunstone Pendant", // Name
                 "Accessories", // Category
                 "Worn as a striking necklace, this vibrant, fire-hued gem is designed purely to capture the \r\nattention of other players. As the character moves, the pendant leaves a bright, golden trail of light that quickly \r\nfades away behind them, serving as a dynamic visual cue. \r\n", // Description
                 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Shroud of Whispers", new BaseItem(
                 "Shroud of Whispers", // Name
                 "Accessories", // Category
                 "This finely woven, dark cloth is usually draped over one shoulder or across a piece of \r\narmor, emphasizing a mysterious, shadowy aesthetic. When the character is still, their silhouette will \r\noccasionally flicker and slightly blur at the edges, giving the illusion of ancient or shifting magic. \r\n", // Description
                 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Golem's Core", new BaseItem(
                 "Golem's Core", // Name
                 "Accessories", // Category
                 "This is a heavy, moss-covered, and decorative piece of petrified wood, often fastened securely\r\nto a character's backpack or pauldron as a status symbol. While equipped, a small, decorative spark effect \r\nconsisting of miniature lightning bolts will appear and vanish near the character's feet every few seconds.\r\n", // Description
                 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},

        };

        public static byte maxOptionMainWeapon = 9;
        public static Dictionary<string, BaseItem> mainWeapon = new Dictionary<string, BaseItem>()
        {
            {"Sword", new BaseItem(
                 "Sword",
                 "Main Weapon",
                 "A Sword is a bladed melee weapon that is versatile, it is intended for bruising and thrusting against their \r\nopponents.\r\nIt is often used because it represents the meaning of power. It has a balanced stats that deals a great amount\r\nof damage and grants the players equal mobility and efficiency in speed.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Long Sword", new BaseItem(
                 "Long SWord",
                 "Main Weapon",
                 "A Long Sword is a quick, effective, and versatile weapon capable of deadly thrusts, slices, and cuts.\r\nIt is a two-handed or one-handed slashing weapon that offers a balance of reach and damage.\r\nUnlike its counterpart, the long sword has a wider reach and deals greater damage compared to it, in \r\nexchange to this it has a lower mobility and slower speed in its attacks.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Great Sword", new BaseItem(
                 "Great SWord",
                 "Main Weapon",
                 "A Great Sword is a large, heavy weapon known for dealing massive damage with slow, powerful swings that \r\nare difficult to block.\r\nThis large weapon cannot be handled with one hand, it requires both of the player’s hands in order to use this.\r\nThis deals a devastating amount of damage to its opponents and has a lower chance of being interrupted while \r\nattacking.\r\nIn return this has one of the slowest swing times and affects the player’s mobility a lot more than lighter \r\nweapons.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Great Hammer", new BaseItem(
                 "Great Hammer",
                 "Main Weapon",
                 "The Great Hammer is a large, heavy weapon known for its high damage and slow, powerful swings.\r\nMuch like the greatsword, this weapon cannot be handled with one hand, it requires both of the player’s hands \r\nin order to use this.\r\nThis deals a devastating amount of damage to its opponent but compared to the Great Sword, this weapon has \r\na squared-like shape of attack when swinging at its opponents.\r\nThis weapon has one of the slowest swing times and affects the player’s mobility a lot more than lighter \r\nweapons.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Bows", new BaseItem(
                 "Bows",
                 "Main Weapon",
                 "Bows are ranged weapons that fire projectiles like arrows, requiring players to draw back a string to increase \r\ndamage and accuracy before releasing.\r\nThis weapon has a unique feature that gives the user more mobility when using a ranged-like weapon, this \r\nweapon also scales with the player’s mobility and attack efficiency.\r\nThis weapon’s attack efficiency doesn’t increase,it has a fixed speed in its attack.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Crossbows", new BaseItem(
                 "Crossbows",
                 "Main Weapon",
                 "Crossbows are silent, heavy-hitting, slow-reloading ranged weapons that offer stealthy attacks and high \r\ndamage per shot.\r\nThis weapon has a unique feature that gives the user more mobility when using a ranged-like weapon, Unlike \r\nits counterpart the Bow\r\nthis weapon does not scale with the player’s mobility and attack efficiency, instead it deals greater damage \r\nbased on the player’s attack.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Spears", new BaseItem(
                 "Spear",
                 "Main Weapon",
                 "Spears are long-reach, thrusting melee weapons that emphasize distance control, precision, and versatility.\r\nThis weapon deals similar but less damage compared to a sword but has a higher distance to hit their \r\nopponents, \r\nmuch like a sword it has balanced stats and deals a great amount of damage but has a higher attack efficiency \r\ncompared to a sword.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Battle Axe", new BaseItem(
                 "Battle Axe",
                 "Main Weapon",
                 "The Battle Axe is a versatile melee weapon, often characterized by high damage but a slower attack efficiency.\r\nThis weapon can be dual-wielded for a more significant amount of damage, in exchange this weapon even if \r\nused single handedly,\r\nhas a slower attack efficiency compared to a Long Sword but is slightly faster than a Great Sword.\r\nThis weapon scales based on the player’s attack.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Hallberd", new BaseItem(
                 "Hallberd",
                 "Main Weapon",
                 "The halberd is a versatile long-handled polearm that combines the functions of both an axe and a spear.\r\nThis weapon has a unique way of attacking compared to the Spear, it has the attacks of both Spear and an \r\nAxe. \r\nThis weapon has a higher mobility than the Battle Axe and has a longer range than the Spear, but this weapon \r\ndoes not deal higher damage than the Battle Axe and cannot surpass the Spear in terms of its mobility and \r\nspeed.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        public static byte maxOptionSubWeapon = 5;
        public static Dictionary<string, BaseItem> subWeapon = new Dictionary<string, BaseItem>()
        {
            {"Mace", new BaseItem(
                 "Mace",
                 "Sub-Weapon",
                 "The Mace is a blunt, melee weapon in video games, characterized by a heavy head on a handle designed for \r\npowerful strikes.\r\nThis weapon is a single handed weapon that can be equipped by the player when desired.\r\nThis weapon deals a good amount of damage that has a decent efficiency in attack. \r\n",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Hammer", new BaseItem(
                 "Hammer",
                 "Sub-Weapon",
                 "The Hammer has a high damage potential, crushing force, and a focus on close-range combat.\r\nThis is a single handed weapon that can be equipped by the player when desired.\r\nThis weapon deals a good amount of damage and has a decent efficiency in attack but has a bit shorter range.\r\n",
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Hatchet", new BaseItem(
                 "Hatchet", // Name
                 "Sub-Weapon", // Category
                 "The hatchet has a faster, repeated attack swing compared to larger, two-handed axes, but often with \r\nlower individual hit damage.\r\nThis weapon is a single handed weapon that can be equipped by the player when desired. This weapon has a \r\nlonger distance reach than other substitute weapons,\r\nit is also light which allows for faster efficiency in attacks but deals less damage than other substitute weapons. This weapon scales with the player’s efficiency attack.\r\n", // Description
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Throwing Axe", new BaseItem(
                 "Throwing Axe", // Name
                 "Sub-Weapon", // Category
                 "A Throwing Axe is a weapon used for projectile attacks, requiring players to aim and throw the axe at a target.\r\nThis weapon can also be used like the Hatchet. This weapon is a single handed weapon that can be equipped \r\nby the player when desired.\r\nCompared to the Hatchet this deals a lot less in exchange for its projectile attack.\r\n", // Description
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Daggers", new BaseItem(
                 "Daggers", // Name
                 "Sub-Weapon", // Category
                 "The Dagger(s) is a fast one-handed weapon with a significantly shorter range compared to the other substitute\r\nweapons.\r\nThis weapon also deals significantly less damage compared to the other substitute weapon, in exchange to its \r\nlower range and damage,\r\nthis weapon can be used as a throwing projectile and has a unique feature of triggering a critical hit that deals \r\ndouble the damage of the original hit.\r\n", // Description
 
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},


        };

        public static byte maxOptionShield = 5;
        public static Dictionary<string, BaseItem> shield = new Dictionary<string, BaseItem>()
        {
            {"Bucker Shield", new BaseItem(
                 "Bucket Shield", // Name
                 "Sub-Weapon", // Category
                 "The Buckler Shield is a small, handheld shield in games that is ideal for parrying and fast-paced combat but \r\noffers less protection than larger shields.\r\nThis shield can be used to block attacks but each blocked attack will consume a portion of the player’s \r\nstamina.\r\nThis armament scales with the player’s health points and stamina.\r\n", // Description

                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Pavise Shield", new BaseItem(
                 "Pavise Shield", // Name
                 "Shield", // Category
                 "The Pavise Shield is a large, oblong shield that is primarily used as a portable, deployable cover that can take\r\nprojectiles with ease and handles melee attacks well.\r\nThis armament can parry incoming attacks due to its larger appearance and heavier weightload. \r\nThis armament can be used to block attacks but each blocked attack will consume a portion of the player’s \r\nstamina.\r\nThis armament can be used both single-handedly or two-handedly with two-handing consuming less stamina, \r\nthis armament affects the player’s mobility.\r\nThis armament scales with the player’s health points and stamina\r\n", // Description

                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Heater Shield", new BaseItem(
                 "Heater Shield", // Name
                 "Shield", // Category
                 "The Heater Shield is a medium-sized metal shield that offers solid physical protection without being overly \r\nheavy, providing a balanced option for defense and agility.\r\nThis armament can parry incoming attacks but has a less efficient speed unlike the Buckler Shield.\r\nThis armament can be used to block attacks but each blocked attack will consume a portion of the player’s \r\nstamina.\r\nThis armament affects a tiny amount of the players mobility due to its bigger size than the Buckler Shield.\r\nThis armament scales with the player’s health points and stamina.\r\n", // Description

                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Kite Shield", new BaseItem(
                 "Kite Shield", // Name
                 "Shield", // Category
                 "The Kite Shield is a medium-sized shield that offers good protection, balancing defense and mobility better \r\nthan heavier greatshields.\r\nThis armament can parry incoming attacks but has a significantly less efficient speed in doing so due to its \r\nheavier and larger look.\r\nThis armament can be used to block attacks but each blocked attack will consume a portion of the player’s \r\nstamina.\r\nThis weapon excels in blocking projectiles while maintaining its mobility, in return due to its smaller and weaker \r\nstrength than the Pavise Shield each projectile consumes the player’s stamina by a small amount.\r\nThis armament scales with the player’s health points and attack.\r\n", // Description

                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Tower Shield", new BaseItem(
                 "Bucket Shield", // Name
                 "Shield", // Category
                 "The Tower Shield is a large, heavy shield that provides high defense, often at the cost of reduced mobility, due \r\nto its size and weight.\r\nThis gives the highest protection to the player and each blocked hit will not consume the player’s stamina \r\nexcluding heavy-hitting weapons like the Great Sword.\r\nThis weapon has a unique parry compared to the other shields, it can parry its opponents when a sufficient \r\namount of damage is taken that deals a great amount of damage that is based on the player’s health points.\r\n", // Description

                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        public static byte maxOptionCompanion = 5;
        public static Dictionary<string, BaseItem> companion = new Dictionary<string, BaseItem>()
        {
            {"War Horse", new BaseItem(
                 "War Horse", // Name
                 "Companion", // Category
                 "A sturdy, well-trained mount accustomed to rough terrain and the clamor of combat. It provides high speed for travel and can carry heavy loads, acting as reliable transportation and a mobile inventory.", // Description
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Loyal Hound", new BaseItem(
                 "Loyal Hound", // Name
                 "Companion", // Category
                 "A large, protective dog whose senses are far sharper than any human's. It excels at detecting hidden dangers, tracking scents, and serving as a vital early warning system against ambushes.", // Description
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Trained Falcon", new BaseItem(
                 "Trained Falcon", // Name
                 "Companion", // Category
                 "A highly focused bird of prey, small enough to perch on the shoulder or wrist. It is excellent for silent, high-altitude scouting and quickly reporting observations back to its handler.\r\n", // Description
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Mountain Gryphtlet", new BaseItem(
                 "War Horse", // Name
                 "Companion", // Category
                 "A young, flight-capable creature resembling a small gryphon or hawk. While too small to carry a rider, it provides unparalleled aerial surveillance and can quickly deliver messages over short distances.\r\n", // Description
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Pack Mule", new BaseItem(
                 "Pack Mule", // Name
                 "Companion", // Category
                 "A docile, strong-willed animal known for its unmatched endurance on long journeys. It is slower than a horse but can carry significantly heavier and more awkward loads across difficult, mountainous paths.", // Description
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
        };

        public static byte maxOptionStats = 7;
        public static Dictionary<string, BaseItem> stats = new Dictionary<string, BaseItem>()
        {
             {"Health +10", new BaseItem(
                 "Health +10",
                 "Stats",
                 "This is the amount of damage the player can take.",
                 10, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Stamina +6", new BaseItem(
                 "Stamina +6",
                 "Stats",
                 "This is the amount of sprint, attacks and dodge the player can do. Walking will regenerate the player’s stamina\r\nstanding still regenerates more and sitting down will significantly regenerate the player’s stamina.\r\n",
                 0, // health
                6, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Strenght +8", new BaseItem(
                 "Strenght +8",
                 "Stats",
                 "This is the amount of damage the player can do to their enemies.",
                 0, // health
                0, // stamina
                8, // strenght
                0, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Haste +4", new BaseItem(
                 "Haste +4",
                 "Stats",
                 "This is how efficiently the player can attack their enemies.",
                 0, // health
                0, // stamina
                0, // strenght
                4, // haste
                0, // agility
                0, // defense
                0 // poise
                )},
            {"Agility +6", new BaseItem(
                 "Agility +6",
                 "Stats",
                 "This is how fast the player can move around.",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                6, // agility
                0, // defense
                0 // poise
                )},
            {"Defense +9", new BaseItem(
                 "Defense +9",
                 "Stats",
                 "This is how much damage mitigation the player can have",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                9, // defense
                0 // poise
                )},
            {"Poise +15", new BaseItem(
                 "Poise +15",
                 "Stats",
                 "This is how much damage the players can take before they are staggered and removed from their fighting stance.",
                 0, // health
                0, // stamina
                0, // strenght
                0, // haste
                0, // agility
                0, // defense
                15 // poise
                )},
        };

    }
    
}
