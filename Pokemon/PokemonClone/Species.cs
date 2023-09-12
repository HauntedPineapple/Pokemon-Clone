using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Species
    {
        #region Member Variables
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
        #endregion

        #region Constructors
        public Species(string a_name, Type a_type1, Type a_type2, string a_description, 
            int a_baseHP, int a_baseAttack, int a_baseSpecialAttack, int a_baseDefense, int a_baseSpecialDefense, int a_baseSpeed)
        {
            m_name = a_name;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
        }

        /// <summary>
        /// Create pokemon species using an array to add in the base stats
        /// </summary>
        /// <param name="a_baseStats">must be in the order of "hp, atk, spAtk, def, spDef, speed"</param>
        public Species(string a_name, Type a_type1, Type a_type2, string a_description, int[] a_baseStats)
        {
            m_name = a_name;
            m_type1 = a_type1;
            m_type2 = a_type2;
            m_description = a_description;
        }
        #endregion

        #region Properties
        public string Name { get { return m_name; } }
        public Type PrimaryType { get { return m_type1; } }
        public Type SecondaryType { get { return m_type2; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "";
        }
        #endregion
    }
}
