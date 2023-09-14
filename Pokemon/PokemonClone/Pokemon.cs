﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Pokemon
    {
        const int EV = 42; // 252(max EVs)/6(num stats)

        private Species m_species;
        private string m_nickname;

        KeyValuePair<string, Dictionary<int, string>> m_nature;

        private int m_level;
        private int m_currentHP;

        private int m_hp;
        private int m_attack;
        private int m_specialAttack;
        private int m_defense;
        private int m_specialDefense;
        private int m_speed;

        private int m_hpIV;
        private int m_attackIV;
        private int m_specialAttackIV;
        private int m_defenseIV;
        private int m_specialDefenseIV;
        private int m_speedIV;

        private Move[] m_moveset = new Move[4];

        #region Constructors
        public Pokemon(Species a_species, int a_level)
        {
            m_species = a_species;
            m_nickname = "";
            m_level = a_level;
        }

        public Pokemon(Species a_species, int a_level, Move[] a_moveset)
        {
            m_species = a_species;
            m_nickname = "";
            m_level = a_level;

            if (a_moveset.Length > 4)
            {
                for (int i = 0; i < 4; i++) { m_moveset[i] = a_moveset[i]; }
            }
            else m_moveset = a_moveset;
        }

        public Pokemon(Species a_species, string a_name, int a_level)
        {
            m_species = a_species;
            m_nickname = a_name;
            m_level = a_level;
        }

        public Pokemon(Species a_species, string a_name, int a_level, Move[] a_moveset)
        {
            m_species = a_species;
            m_nickname = a_name;
            m_level = a_level;

            if (a_moveset.Length > 4)
            {
                for (int i = 0; i < 4; i++) { m_moveset[i] = a_moveset[i]; }
            }
            else m_moveset = a_moveset;
        }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                if (m_nickname != "")
                    return m_nickname;
                else
                    return m_species.Name;
            }
        }
        public Type PrimaryType { get { return m_species.PrimaryType; } }
        public Type SecondaryType { get { return m_species.SecondaryType; } }
        #endregion

        public override string ToString()
        {
            string output = "";

            if (m_nickname != "") output += "Name: " + m_nickname + "\nSpecies: " + m_species.Name;
            else output += "Name: " + m_species.Name;

            output += "\nLevel" + m_level;
            output += "\nHP: " + m_currentHP + "/" + m_hp;
            output += "\n";

            return output;
        }

        // --------- HELPER METHODS ---------
        private void CalculateStats()
        { // uses these formulas: https://bulbapedia.bulbagarden.net/wiki/Stat#:~:text=190-,Generation%20III%20onward,-H

        }

        private void RollIVs()
        {
            Random random = new Random();
            m_hpIV = random.Next(32);
            m_attackIV = random.Next(32);
            m_specialAttackIV = random.Next(32);
            m_defenseIV = random.Next(32);
            m_specialDefenseIV = random.Next(32);
            m_speedIV = random.Next(32);
        }
    }
}
