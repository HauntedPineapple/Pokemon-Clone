using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClone
{
    internal class Type
    {
        private TypeName m_name;
        private TypeName[] m_effectiveAgainst;
        private TypeName[] m_weakAgainst;
        private TypeName[] m_noEffectOn;

        public Type(TypeName a_name, TypeName[] a_effectiveAgainst, TypeName[] a_weakAgainst, TypeName[] a_noEffectOn)
        {
            m_name = a_name;
            m_effectiveAgainst = a_effectiveAgainst;
            m_weakAgainst = a_weakAgainst;
            m_noEffectOn = a_noEffectOn;
        }

        public TypeName Name { get { return m_name; } }

        public override string ToString()
        {
            return Name.ToString();
        }

        /// <summary>
        /// Checks to see if the effectivity of this type against the given type
        /// </summary>
        public Effectivity CheckEffectivenessAgainst(Type a_otherType)
        {
            if (Array.IndexOf(m_effectiveAgainst, a_otherType) != -1) return Effectivity.SuperEffective;
            if (Array.IndexOf(m_weakAgainst, a_otherType) != -1) return Effectivity.NotEffective;
            if (Array.IndexOf(m_noEffectOn, a_otherType) != -1) return Effectivity.NoEffect;
            return Effectivity.Regular;
        }
    }
}
