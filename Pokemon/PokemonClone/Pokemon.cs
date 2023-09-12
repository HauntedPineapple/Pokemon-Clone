using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Pokemon
    {
        static int EV = 42;

        #region Member Variables
        private Species m_species;
        private string m_name;
        private bool m_isMale;

        private int m_level;
        //private int exp;
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
        #endregion

        #region Constructors
        public Pokemon(Species a_species, string a_name, int a_level)
        {
            m_species = a_species;
            m_name = a_name;
            m_level = a_level;
        }

        public Pokemon(Species a_species, string a_name, Move[] a_moveset)
        {
            m_species = a_species;
            m_name = a_name;

            if (a_moveset.Length > 4)
            {
                for (int i = 0; i < 4; i++) { m_moveset[i] = a_moveset[i]; }
            }
            else m_moveset = a_moveset;
        }
        #endregion

        #region Properties
        public string Name { get { return m_name; } }
        public Type PrimaryType { get { return m_species.PrimaryType; } }
        public Type SecondaryType { get { return m_species.SecondaryType; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "";
        }
        #endregion
    }
}
