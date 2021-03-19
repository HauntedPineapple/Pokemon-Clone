using System;
using System.Collections.Generic;
using System.Text;



namespace PokeTheDex
{
    class Pokemon
    {
        String name, description;
        Type firstType, secondType;
        int id;
        float height, weight;
        int hp, attack, specialAttack, defense, specialDefense, speed;
        bool hasMega;
        Region region;
        List<Move> possibleMoves;
        List<Ability> possibleAbilities;

        public Pokemon()
        {
            name = "Unknown";
            id = -1;
            height = -1;
            weight = -1;
            hp = -1;
            attack = -1;
            specialAttack = -1;
            defense = -1;
            specialDefense = -1;
            hasMega = false;
            region = Region.Kanto;
            firstType = null;
            secondType = null;
            description = null;
            possibleMoves = null;
            possibleAbilities = null;
        }

        public Pokemon(string name, int id, Type type)
        {
            name = "Unknown";
            id = -1;
            height = -1;
            weight = -1;
            hp = -1;
            attack = -1;
            specialAttack = -1;
            defense = -1;
            specialDefense = -1;
            region = Region.Kanto;
            firstType = type;
            secondType = type;
            description = null;
            possibleMoves = null;
        }
        public Pokemon(string name, int id, Type type1, Type type2)
        {
            this.name = name;
            this.id = id;
            firstType = type1;
            secondType = type2;

            height = -1;
            weight = -1;
            hp = -1;
            attack = -1;
            specialAttack = -1;
            defense = -1;
            specialDefense = -1;
            region = Region.Kanto;
            description = null;
            hasMega = false;
            possibleAbilities = null;
            possibleMoves = null;
        }
        // Monotype pokemon
        public Pokemon(string name, int id, Type type, float height, float weight, int hp, int atk, int spAtk, int def, int spDef, int speed, Region region = Region.Kanto, bool megaStatus = false, string description = "")
        {
            this.name = name;
            this.id = id;
            this.hp = hp;
            this.height = height;
            this.weight = weight;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            firstType = type;
            secondType = type;
            this.description = description;
            this.region = region;
            hasMega = megaStatus;
            possibleAbilities = null;
            possibleMoves = null;
        }
        public Pokemon(string name, int id, Type type, float height, float weight, int hp, int atk, int spAtk, int def, int spDef, int speed, List<Move> possibleMoves = null, List<Ability> possibleAbilities = null, Region region = Region.Kanto, bool megaStatus=false,string description = "")
        {
            this.name = name;
            this.id = id;
            this.hp = hp;
            this.height = height;
            this.weight = weight;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            firstType = type;
            secondType = type;
            this.description = description;
            this.region = region;
            hasMega = megaStatus;
            this.possibleAbilities = possibleAbilities;
            this.possibleMoves = possibleMoves;
        }

        // Two-type pokemon
        public Pokemon(string name, int id, Type type1, Type type2, float height, float weight, int hp, int atk, int spAtk, int def, int spDef, int speed, Region region = Region.Kanto, bool megaStatus=false, string description = "")
        {
            this.name = name;
            this.id = id;
            this.height = height;
            this.weight = weight;
            this.hp = hp;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            firstType = type1;
            secondType = type2;
            this.description = description;
            this.region = region;
            hasMega = megaStatus;
            possibleAbilities = null;
            possibleMoves = null;
        }
        public Pokemon(string name, int id, Type type1, Type type2, float height, float weight, int hp, int atk, int spAtk, int def, int spDef, int speed, List<Move> possibleMoves = null, List<Ability> possibleAbilities = null, Region region = Region.Kanto, bool megaStatus=false,string description = "")
        {
            this.name = name;
            this.id = id;
            this.height = height;
            this.weight = weight;
            this.hp = hp;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            firstType = type1;
            secondType = type2;
            this.description = description;
            this.region = region;
            hasMega = megaStatus;
            this.possibleAbilities = possibleAbilities;
            this.possibleMoves = possibleMoves;
        }

        #region properties
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public List<Move> PossibleMoves { get { return possibleMoves; } set { possibleMoves = value; } }
        public int HP { get { return hp; } set { hp = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int SpecialAttack { get { return specialAttack; } set { specialAttack = value; } }
        public int Defense { get { return defense; } set { defense = value; } }
        public int SpecialDefense { get { return specialDefense; } set { specialDefense = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        #endregion

        public void PrintPokemon()
        {
            Console.WriteLine("#" + id + " " + name);
            Console.WriteLine("Height: " + height + "m\tWeight: " + weight + "kg");
            Console.Write("Type: ");
            if (firstType != secondType)
            {
                Console.WriteLine(firstType + " " + secondType);
            }
            else
            {
                Console.WriteLine(firstType);
            }
            Console.WriteLine("HP: " + hp + "\tSpeed: " + speed);
            Console.WriteLine("Attack: " + attack + "\tSpecial Attack: " + specialAttack);
            Console.WriteLine("Defense: " + defense + "\tSpecial Defense: " + specialDefense);
        }
        public void PrintBaseStats()
        {

        }
        public void PrintPossibleMoves()
        {
            Console.WriteLine("Moves that " + this.name + " can learn:");
            foreach (Move move in possibleMoves)
            {
                Console.WriteLine(move.Name);
            }
        }
    }
}
