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
        #endregion

        #region Constructors
        public Move(string a_name, Type a_type, string a_description = "")
        {
            m_name = a_name;
            m_type = a_type;
            m_description = a_description;
        }
        #endregion

        #region Properties
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public Type Type { get { return m_type; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "";
        }
        #endregion
    }
}
