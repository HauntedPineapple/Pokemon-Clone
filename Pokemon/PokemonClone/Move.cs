using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Move
    {
        #region Member Variables
        protected string m_name;
        protected string m_description;
        protected Type m_type;
        protected int m_priority;
        #endregion

        #region Constructors
        public Move(string a_name, Type a_type, string a_description = "", int a_priority = 0)
        {
            m_name = a_name;
            m_type = a_type;
            m_description = a_description;
            m_priority = a_priority;
        }
        #endregion

        #region Properties
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public Type Type { get { return m_type; } }
        public int Priority { get { return m_priority; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "";
        }
        #endregion
    }
}
