using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class StatusMove : Move
    {
        #region Member Variables
        #endregion

        #region Constructors
        public StatusMove(string a_name, Type a_type, string a_description = "") : base(a_name, a_type, a_description)
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
