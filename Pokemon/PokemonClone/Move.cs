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
        //protected string m_ID;
        protected string m_description;
        protected Type m_type;

        // protected int m_priority = 0;
        protected int m_pp;
        //protected int m_currentPP;
        // protected int m_maxPP;
        protected int m_power;
        protected int m_accuracy;

        protected bool m_isSpecial;
        //protected bool m_makesContact;

        public Move(string a_name, Type a_type, int a_power, int a_accuracy, int a_PP, bool a_isSpecial = false, string a_description = "") // string a_ID = "") //bool a_makesContact = false) //int a_priority = 0)
        {
            m_name = a_name;
            //m_ID = a_ID;
            m_description = a_description;
            m_type = a_type;
            m_pp = a_PP;
            m_power = a_power;
            m_accuracy = a_accuracy;
            m_isSpecial = a_isSpecial;
            //m_maxPP = a_maxPP;
            //m_makesContact = a_makesContact;
        }

        public Type Type { get { return m_type; } }
        public string Name { get { return m_name; } }
        //public string ID { get { return m_ID; } }
        public string Description { get { return m_description; } }
        public int PP { get { return m_pp; } }
        public int Power { get { return m_power; } }
        public int Accuracy { get { return m_accuracy; } }
        public bool IsSpecial { get { return m_isSpecial; } }
        //public int CurrentPP { get { return m_currentPP; } }
        //public int MaxPP { get { return m_maxPP; } }
        //public int Priority { get { return m_priority; } }
        //public bool MakesContact { get { return m_makesContact; } }

        public override string ToString()
        {
            string output = m_name;
            output += "\nType: " + m_type + "   Categpry: ";
            if (m_isSpecial) output += "Special";
            else output += "Physical";
            output += "\nAccuracy: " + m_type + "   Power: " + m_power;
            //if (m_description != "") output += m_description;
            return output;
        }

        public void UseMove(Pokemon a_attackingPokemon, Pokemon a_defendingPokemon)
        {// TODO
        }

        public static int CalculateDamage(Move a_move, Pokemon a_attackingPokemon, Pokemon a_defendingPokemon)
        {
            double effectiveness = 1;
            // calculate effectiveness
            if (a_defendingPokemon.PrimaryType == a_defendingPokemon.SecondaryType)
            {
                effectiveness = Type.CalculateDamageMultiplier(a_move.Type, a_defendingPokemon.PrimaryType);
                if (effectiveness == 0)
                    return 0;
            }
            else
            {
                effectiveness = Type.CalculateDamageMultiplier(a_move.Type, a_defendingPokemon.PrimaryType, a_defendingPokemon.SecondaryType);
                if (effectiveness == 0)
                    return 0;
            }

            Random rng = new Random();

            // calulate random factor
            int random = rng.Next(85, 101);
            random /= 100;

            // calculate same-type-attack-bonus
            double stab = 1;
            if (a_attackingPokemon.PrimaryType == a_move.Type || a_attackingPokemon.SecondaryType == a_move.Type)
            {
                stab = 1.5;
            }

            // roll for critical
            double critical = 1;
            if (rng.Next(101) <= 4) //4% chance
            {
                critical = 1.5;
            }

            int attack, defense;
            if (a_move.IsSpecial)
            { // attack is special
                attack = a_attackingPokemon.SpecialAttack;
                defense = a_defendingPokemon.SpecialDefense;
            }
            else
            { // attack is physical
                attack = a_attackingPokemon.Attack;
                defense = a_defendingPokemon.Defense;
            }

            int level = a_attackingPokemon.Level;
            int power = a_move.Power;

            // Calulate damage
            double totalDamage = (2 + level) / 5;
            totalDamage += 2;
            totalDamage = totalDamage * power * (attack / defense);
            totalDamage /= 50;
            totalDamage += 2;
            totalDamage *= stab * critical * effectiveness * random;

            return (int)totalDamage;
        }
    }
}
