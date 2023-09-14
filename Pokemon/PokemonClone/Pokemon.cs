using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Pokemon
    {
        const int m_EV = 42; // 252(max EVs)/6(num stats)

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
        private int[] m_currentPP = new int[4];

        #region Constructors
        public Pokemon(Species a_species, int a_level, Move[] a_moveset)
        {
            m_species = a_species;
            m_nickname = "";
            m_level = a_level;

            if (a_moveset.Length <= 4)
            {
                for (int i = 0; i < a_moveset.Length; i++)
                {
                    m_moveset[i] = a_moveset[i];
                    m_currentPP[i] = m_moveset[i].PP;
                }
            }

            RollIVs();
        }

        public Pokemon(Species a_species, string a_name, int a_level, Move[] a_moveset) : this(a_species, a_level, a_moveset)
        {
            m_nickname = a_name;
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
        public int HP { get { return m_hp; } }
        public int CurrentHP { get { return m_currentHP; } }
        public int Attack { get { return m_attack; } }
        public int SpecialAttack { get { return m_specialAttack; } }
        public int Defense { get { return m_defense; } }
        public int SpecialDefense { get { return m_specialDefense; } }
        public int Speed { get { return m_speed; } }
        public int HPIV { get { return m_hpIV; } }
        public int AttackIV { get { return m_attackIV; } }
        public int SpecialAttackIV { get { return m_specialAttackIV; } }
        public int DefenseIV { get { return m_defenseIV; } }
        public int SpecialDefenseIV { get { return m_specialDefenseIV; } }
        public int SpeedIV { get { return m_speedIV; } }
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
        private void CalculateStat(int a_statBase, int a_statIV)
        {
            int stat = (2 * a_statBase + a_statIV + (m_EV / 4) * m_level) / 100;
            stat += 5;
                      
        }

        private void CalculateHP()
        {
            int hp = (2 * m_species.BaseHP + m_hpIV + (m_EV / 4) * m_level) / 100;
            m_hp = hp + (m_level + 10);
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
