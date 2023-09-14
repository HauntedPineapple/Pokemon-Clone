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

        private int m_baseHP;
        private int m_baseAttack;
        private int m_baseSpecialAttack;
        private int m_baseDefense;
        private int m_baseSpecialDefense;
        private int m_baseSpeed;

        #region Constructors
        public Species(string a_name, Type a_type1, Type a_type2, string a_description,
            int a_baseHP, int a_baseAttack, int a_baseSpecialAttack, int a_baseDefense, int a_baseSpecialDefense, int a_baseSpeed)
        {
            m_name = a_name;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
            m_baseHP = a_baseHP;
            m_baseAttack = a_baseAttack;
            m_baseSpecialAttack = a_baseSpecialAttack;
            m_baseDefense = a_baseDefense;
            m_baseSpecialDefense = a_baseSpecialDefense;
            m_baseSpeed = a_baseSpeed;
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
            m_baseHP = a_baseStats[0];
            m_baseAttack = a_baseStats[1];
            m_baseSpecialAttack = a_baseStats[2];
            m_baseDefense = a_baseStats[3];
            m_baseSpecialDefense = a_baseStats[4];
            m_baseSpeed = a_baseStats[5];
        }
        #endregion

        public string Name { get { return m_name; } }
        public Type PrimaryType { get { return m_type1; } }
        public Type SecondaryType { get { return m_type2; } }

        public override string ToString()
        {
            return "";
        }
    }
}
