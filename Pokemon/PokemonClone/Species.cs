using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Species
    {
        private int m_id;
        private string m_name;
        private string m_category;
        private string m_description;
        private Type m_type1;
        private Type m_type2;

        private Stats m_baseStats;

        private double m_weight;
        private double m_height;

        #region Constructors
        public Species(int a_id, string a_name, string a_category, Type a_type1, Type a_type2, string a_description, double a_weight, double a_height,
            int a_baseHP, int a_baseAttack, int a_baseSpecialAttack, int a_baseDefense, int a_baseSpecialDefense, int a_baseSpeed)
        {
            m_id = a_id;
            m_name = a_name;
            m_category = a_category;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
            m_weight = a_weight;
            m_height = a_height;
            m_baseStats.hp = a_baseHP;
            m_baseStats.attack = a_baseAttack;
            m_baseStats.specialAttack = a_baseSpecialAttack;
            m_baseStats.defense = a_baseDefense;
            m_baseStats.specialDefense = a_baseSpecialDefense;
            m_baseStats.speed = a_baseSpeed;
        }

        /// <summary>
        /// Create pokemon species using an array to add in the base stats
        /// </summary>
        /// <param name="a_baseStats">must be in the order of "hp, atk, spAtk, def, spDef, speed"</param>
        public Species(int a_id, string a_name, string a_category, Type a_type1, Type a_type2, string a_description, double a_weight, double a_height, int[] a_baseStats)
        {
            if (a_baseStats.Length != 6) throw new ArgumentException("Error, must use an array containing SIX stats", nameof(a_baseStats));
            m_id = a_id;
            m_name = a_name;
            m_category = a_category;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
            m_weight = a_weight;
            m_height = a_height;
            m_baseStats.hp = a_baseStats[0];
            m_baseStats.attack = a_baseStats[1];
            m_baseStats.specialAttack = a_baseStats[2];
            m_baseStats.defense = a_baseStats[3];
            m_baseStats.specialDefense = a_baseStats[4];
            m_baseStats.speed = a_baseStats[5];
        }
        #endregion

        public int ID { get { return m_id; } }
        public string Name { get { return m_name; } }
        public string Category { get { return m_category; } }
        public string Description { get { return m_description; } }
        public double Weight { get { return m_weight; } }
        public double Height { get { return m_height; } }
        public Type PrimaryType { get { return m_type1; } }
        public Type SecondaryType { get { return m_type2; } }
        public Stats BaseStats { get { return m_baseStats; } }
        public int BaseHP { get { return m_baseStats.hp; } }
        public int BaseAttack { get { return m_baseStats.attack; } }
        public int BaseSpecialAttack { get { return m_baseStats.specialAttack; } }
        public int BaseDefense { get { return m_baseStats.defense; } }
        public int BaseSpecialDefense { get { return m_baseStats.specialDefense; } }
        public int BaseSpeed { get { return m_baseStats.speed; } }

        public override string ToString()
        {
            string output = "No. " + m_id + " Species: " + m_name;
            output += "\n" + m_category;
            if (m_type1 == m_type2) output += "\nType: " + m_type1;
            else output += "\nType: " + m_type1 + "|" + m_type2;
            output += "\nHeight: " + m_height + "m   Weight: " + m_weight + "kg";
            output += "\n" + m_description;
            output += "\nBase Stats ";
            output += "\n\tHP: " + m_baseStats.hp + "   Speed: " + m_baseStats.speed;
            output += "\n\tAttack: " + m_baseStats.attack + "   Special Attack" + m_baseStats.specialAttack;
            output += "\n\tDefense: " + m_baseStats.defense + "   Special Defense: " + m_baseStats.specialDefense;

            return output;
        }
    }
}
