using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Classes
{
    class Pokemon
    {
        int hp, attack, specialAttack, defense, specialDefense, speed;
        Type firstType, secondType;
        MoveSet moves;
        String name, ability;

        public Pokemon(string name)
        {
            this.name = name;
        }
        // Monotype pokemon
        public Pokemon(string name, int hp, int atk, int spAtk, int def, int spDef, int speed, MoveSet moves, Type type, string ability = "")
        {
            this.name = name;
            this.hp = hp;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            this.moves = moves;
            firstType = type;
            secondType = type;
            this.ability = ability;
        }
        // Two-type pokemon
        public Pokemon(string name, int hp, int atk, int spAtk, int def, int spDef, int speed, MoveSet moves, Type type1, Type type2, string ability = "")
        {
            this.name = name;
            this.hp = hp;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            this.moves = moves;
            firstType = type1;
            secondType = type2;
            this.ability = ability;
        }

        #region properties
        public string Name { get { return name; } }
        public string Ability { get { return ability; } }
        public int HP { get { return hp; } set { hp = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int SpecialAttack { get { return specialAttack; } set { specialAttack = value; } }
        public int Defense { get { return defense; } set { defense = value; } }
        public int SpecialDefense { get { return specialDefense; } set { specialDefense = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        #endregion

        public new void ToString()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.WriteLine("HP: " + hp);
            moves.ToString();
            //Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
