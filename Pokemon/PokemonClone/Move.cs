using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Move
    {
        protected string m_name;
        protected string m_description;
        protected Type m_type;

        protected int m_priority = 0;
        protected int m_pp;
        protected int m_currentPP;
        // protected int m_maxPP;
        protected int m_damage;
        protected int m_accuracy;

        protected bool m_isSpecial;


        public Move(string a_name, Type a_type, int a_damage, int a_accuracy, int a_PP, string a_description = "") //int a_priority = 0)
        {
            m_name = a_name;
            m_type = a_type;
            m_description = a_description;
            m_damage = a_damage;
            m_accuracy = a_accuracy;
            m_pp = m_currentPP = a_PP;
        }

        public Type Type { get { return m_type; } }
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public int PP { get { return m_pp; } }
        public int CurrentPP { get { return m_currentPP; } }
        public int Damage { get { return m_damage; } }
        public int Accuracy { get { return m_accuracy; } }
        public int Priority { get { return m_priority; } }

        public override string ToString()
        {
            return Name;
        }

        public virtual void UseMove(Pokemon a_pokemon) { }

        public virtual void UseMove(Pokemon a_attackingPokemon, Pokemon a_defendingPokemon)
        {

        }
    }
}
