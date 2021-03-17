﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class Pokemon
    {
        int hp, attack, specialAttack, defense, specialDefense, speed;
        Type firstType, secondType;
        String name, description;
        List<Move> possibleMoves;
        List<string> possibleAbilities;


        public Pokemon(string name)
        {
            this.name = name;
        }
        // Monotype pokemon
        public Pokemon(string name, int hp, int atk, int spAtk, int def, int spDef, int speed, Type type, List<Move> possibleMoves = null, List<string> possibleAbilities = null, string description = "")
        {
            this.name = name;
            this.hp = hp;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            firstType = type;
            secondType = type;
            this.possibleMoves = possibleMoves;
            this.possibleAbilities = possibleAbilities;
            this.description = description;
        }

        // Two-type pokemon
        public Pokemon(string name, int hp, int atk, int spAtk, int def, int spDef, int speed, Type type1, Type type2, List<Move> possibleMoves = null, List<string> possibleAbilities = null, string description = "")
        {
            this.name = name;
            this.hp = hp;
            attack = atk;
            specialAttack = spAtk;
            defense = def;
            specialDefense = spDef;
            this.speed = speed;
            firstType = type1;
            secondType = type2;
            this.possibleMoves = possibleMoves;
            this.description = description;
        }

        #region properties
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public List<Move> PossibleMoves { get { return possibleMoves; } }
        public List<string> PossibleAbilities { get { return possibleAbilities; } }
        public int HP { get { return hp; } }
        public int Attack { get { return attack; } }
        public int SpecialAttack { get { return specialAttack; } }
        public int Defense { get { return defense; } }
        public int SpecialDefense { get { return specialDefense; } }
        public int Speed { get { return speed; } }
        #endregion

        public void ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.name);
            Console.WriteLine("HP: " + hp + "\tSpeed: " + speed);
            Console.WriteLine("Attack: " + attack + "\tSpecial Attack: " + specialAttack);
            Console.WriteLine("Defense: " + defense + "\tSpecial Defense: " + specialDefense);
            Console.WriteLine("Possible abilities: ");
            foreach(string ability in possibleAbilities)
            {
                Console.WriteLine(ability);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public new void PrintPossibleMoves()
        {
            Console.WriteLine("Moves that " + this.name + " can learn:");
            foreach (Move move in possibleMoves)
            {
                Console.WriteLine(move.Name);
            }
        }
    }
}
