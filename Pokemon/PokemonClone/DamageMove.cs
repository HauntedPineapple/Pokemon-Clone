using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class DamageMove : Move
    {
        #region Member Variables
        #endregion

        #region Constructors
        public DamageMove(string a_name, Type a_type, string a_description = "", int a_priority = 0) : base(a_name, a_type, a_description, a_priority)
        {
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public override string ToString()
        {
            return "";
        }
        #endregion
    }
}
