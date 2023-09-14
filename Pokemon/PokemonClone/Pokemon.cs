using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Pokemon
    {
        const int m_EV = 42; // 252(max EVs)/6(num stats)

        private Species m_species;
        private string m_nickname;

        private Nature m_nature;

        private int m_level;
        private int m_currentHP;

        private Stats m_stats;
        private Stats m_IVs;

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
        public int CurrentHP { get { return m_currentHP; } }

        public Stats Stats { get { return m_stats; } }
        public int HP { get { return m_stats.hp; } }
        public int Attack { get { return m_stats.attack; } }
        public int SpecialAttack { get { return m_stats.specialAttack; } }
        public int Defense { get { return m_stats.defense; } }
        public int SpecialDefense { get { return m_stats.specialDefense; } }
        public int Speed { get { return m_stats.speed; } }

        public Stats IVs { get { return m_IVs; } }
        public int HPIV { get { return m_IVs.hp; } }
        public int AttackIV { get { return m_IVs.attack; } }
        public int SpecialAttackIV { get { return m_IVs.specialAttack; } }
        public int DefenseIV { get { return m_IVs.defense; } }
        public int SpecialDefenseIV { get { return m_IVs.specialDefense; } }
        public int SpeedIV { get { return m_IVs.speed; } }
        #endregion

        public override string ToString()
        {
            string output = "";

            if (m_nickname != "") output += "Name: " + m_nickname + "\nSpecies: " + m_species.Name;
            else output += "Name: " + m_species.Name;

            output += "\nLevel" + m_level;
            output += "\nHP: " + m_currentHP + "/" + m_stats.hp;
            output += "\n";

            return output;
        }

        // --------- HELPER METHODS ---------
        private void CalculateStats()
        {
            if (m_nature.increasedStat == StatName.Attack && m_nature.decreasedStat == StatName.Attack)
                m_stats.attack = CalculateStat(m_species.BaseStats.attack, m_IVs.attack, 1);
            else if (m_nature.increasedStat == StatName.Attack)
                m_stats.attack = CalculateStat(m_species.BaseStats.attack, m_IVs.attack, 1.1);
            else if (m_nature.decreasedStat == StatName.Attack)
                m_stats.attack = CalculateStat(m_species.BaseStats.attack, m_IVs.attack, 0.9);
            else
                m_stats.attack = CalculateStat(m_species.BaseStats.attack, m_IVs.attack, 1);

            if (m_nature.increasedStat == StatName.SpecialAttack && m_nature.decreasedStat == StatName.SpecialAttack)
                m_stats.specialAttack = CalculateStat(m_species.BaseStats.specialAttack, m_IVs.specialAttack, 1);
            else if (m_nature.increasedStat == StatName.SpecialAttack)
                m_stats.specialAttack = CalculateStat(m_species.BaseStats.specialAttack, m_IVs.specialAttack, 1.1);
            else if (m_nature.decreasedStat == StatName.SpecialAttack)
                m_stats.specialAttack = CalculateStat(m_species.BaseStats.specialAttack, m_IVs.specialAttack, 0.9);
            else
                m_stats.specialAttack = CalculateStat(m_species.BaseStats.specialAttack, m_IVs.specialAttack, 1);

            if (m_nature.increasedStat == StatName.Defense && m_nature.decreasedStat == StatName.Defense)
                m_stats.defense = CalculateStat(m_species.BaseStats.defense, m_IVs.defense, 1);
            else if (m_nature.increasedStat == StatName.Defense)
                m_stats.defense = CalculateStat(m_species.BaseStats.defense, m_IVs.defense, 1.1);
            else if (m_nature.decreasedStat == StatName.Defense)
                m_stats.defense = CalculateStat(m_species.BaseStats.defense, m_IVs.defense, 0.9);
            else
                m_stats.defense = CalculateStat(m_species.BaseStats.defense, m_IVs.defense, 1);

            if (m_nature.increasedStat == StatName.SpecialDefense && m_nature.decreasedStat == StatName.SpecialDefense)
                m_stats.specialDefense = CalculateStat(m_species.BaseStats.specialDefense, m_IVs.specialDefense, 1);
            else if (m_nature.increasedStat == StatName.SpecialDefense)
                m_stats.specialDefense = CalculateStat(m_species.BaseStats.specialDefense, m_IVs.specialDefense, 1.1);
            else if (m_nature.decreasedStat == StatName.SpecialDefense)
                m_stats.specialDefense = CalculateStat(m_species.BaseStats.specialDefense, m_IVs.specialDefense, 0.9);
            else
                m_stats.specialDefense = CalculateStat(m_species.BaseStats.specialDefense, m_IVs.specialDefense, 1);

            if (m_nature.increasedStat == StatName.Speed && m_nature.decreasedStat == StatName.Speed)
                m_stats.speed = CalculateStat(m_species.BaseStats.speed, m_IVs.speed, 1);
            else if (m_nature.increasedStat == StatName.Speed)
                m_stats.speed = CalculateStat(m_species.BaseStats.speed, m_IVs.speed, 1.1);
            else if (m_nature.decreasedStat == StatName.Speed)
                m_stats.speed = CalculateStat(m_species.BaseStats.speed, m_IVs.speed, 0.9);
            else
                m_stats.speed = CalculateStat(m_species.BaseStats.speed, m_IVs.speed, 1);

            CalculateHP();
        }

        private int CalculateStat(int a_statBase, int a_statIV, double a_natureMultiplier)
        {
            double stat = ((2 * a_statBase + a_statIV + (m_EV / 4) * m_level) / 100) + 5;
            stat *= a_natureMultiplier;
            return (int)stat;
        }

        private void CalculateHP()
        {
            double hp = (2 * m_species.BaseHP + m_IVs.hp + (m_EV / 4) * m_level) / 100;
            hp += m_level + 10;
            m_stats.hp = (int)hp;
        }

        private void RollIVs()
        {
            Random random = new Random();
            m_IVs.hp = random.Next(32);
            m_IVs.attack = random.Next(32);
            m_IVs.specialAttack = random.Next(32);
            m_IVs.defense = random.Next(32);
            m_IVs.specialDefense = random.Next(32);
            m_IVs.speed = random.Next(32);
        }
    }
}
