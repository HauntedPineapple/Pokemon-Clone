using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Species
    {
        private string m_name;
        private string m_description;
        private Type m_type1;
        private Type m_type2;

        private Stats m_baseStats;

        #region Constructors
        public Species(string a_name, Type a_type1, Type a_type2, string a_description,
            int a_baseHP, int a_baseAttack, int a_baseSpecialAttack, int a_baseDefense, int a_baseSpecialDefense, int a_baseSpeed)
        {
            m_name = a_name;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
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
        public Species(string a_name, Type a_type1, Type a_type2, string a_description, int[] a_baseStats)
        {
            if (a_baseStats.Length != 6)
                throw new ArgumentException("Error, must use an array containing SIX stats", nameof(a_baseStats));

            m_name = a_name;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
            m_baseStats.hp = a_baseStats[0];
            m_baseStats.attack = a_baseStats[1];
            m_baseStats.specialAttack = a_baseStats[2];
            m_baseStats.defense = a_baseStats[3];
            m_baseStats.specialDefense = a_baseStats[4];
            m_baseStats.speed = a_baseStats[5];
        }
        #endregion

        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
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
            return "";
        }
    }
}
