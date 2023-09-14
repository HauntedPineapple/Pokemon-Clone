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
        protected string m_ID;
        protected string m_description;
        protected Type m_type;

        // protected int m_priority = 0;
        protected int m_pp;
        //protected int m_currentPP;
        // protected int m_maxPP;
        protected int m_damage;
        protected int m_accuracy;

        protected bool m_isSpecial;
        //protected bool m_makesContact;

        public Move(string a_name, Type a_type, int a_damage, int a_accuracy, int a_PP, bool a_isSpecial = false, string a_description = "", string a_ID = "") //bool a_makesContact = false) //int a_priority = 0)
        {
            m_name = a_name;
            m_ID = a_ID;
            m_description = a_description;
            m_type = a_type;
            m_pp = a_PP;
            m_damage = a_damage;
            m_accuracy = a_accuracy;
            m_isSpecial = a_isSpecial;
            //m_maxPP = a_maxPP;
            //m_makesContact = a_makesContact;
        }

        public Type Type { get { return m_type; } }
        public string Name { get { return m_name; } }
        public string ID { get { return m_ID; } }
        public string Description { get { return m_description; } }
        public int PP { get { return m_pp; } }
        //public int CurrentPP { get { return m_currentPP; } }
        //public int MaxPP { get { return m_maxPP; } }
        public int Damage { get { return m_damage; } }
        public int Accuracy { get { return m_accuracy; } }
        //public int Priority { get { return m_priority; } }
        public bool IsSpecial { get { return m_isSpecial; } }
        //public bool MakesContact { get { return m_makesContact; } }

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
