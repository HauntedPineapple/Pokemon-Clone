using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Type
    {
        #region Member Variables
        private TypeName m_name;
        #endregion

        #region Constructors
        public Type(TypeName a_name)
        {
            m_name = a_name;
        }
        #endregion

        #region Properties
        public TypeName Name { get { return m_name; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Type: "+Name.ToString();
        }
        #endregion
    }
}
