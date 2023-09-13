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
        private TypeName[] m_resistantTo;
        private TypeName[] m_weakTo;
        private TypeName[] m_noEffectFrom;

        /// <summary> Constructor </summary>
        /// <param name="a_effectiveAgainst">An array of types that this type is super effective against</param>
        /// <param name="a_weakAgainst">An array of types that this type is not very effective against</param>
        /// <param name="a_noEffectOn">An array of types that this type has no effect on</param>
        /// <param name="a_resistantTo">An array of types that this type is resistant to</param>
        /// <param name="a_weakTo">An array of types that this type is weak to</param>
        /// <param name="a_noEffectFrom">An array of types that this type is not effected by</param>
        public Type(TypeName a_name,
            TypeName[] a_effectiveAgainst, TypeName[] a_weakAgainst, TypeName[] a_noEffectOn,
            TypeName[] a_resistantTo, TypeName[] a_weakTo, TypeName[] a_noEffectFrom)
        {
            m_name = a_name;
            m_effectiveAgainst = a_effectiveAgainst;
            m_weakAgainst = a_weakAgainst;
            m_noEffectOn = a_noEffectOn;
            m_weakTo = a_weakTo;
            m_resistantTo = a_resistantTo;
            m_noEffectFrom = a_noEffectFrom;
        }


        #region Properties
        public TypeName Name { get { return m_name; } }

        /// <summary> An array of types that this type is super effective against </summary>
        public TypeName[] EffectiveAgainst { get { return m_effectiveAgainst; } }

        /// <summary> An array of types that this type is not very effective against </summary>
        public TypeName[] WeakAgainst { get { return m_weakAgainst; } }

        /// <summary> An array of types that this type has no effect on </summary>
        public TypeName[] NoEffectOn { get { return m_noEffectOn; } }

        /// <summary> An array of types that this type is resistant to </summary>
        public TypeName[] ResistantTo { get { return m_resistantTo; } }

        /// <summary> An array of types that this type is weak to </summary>
        public TypeName[] WeakTo { get { return m_weakTo; } }

        /// <summary> An array of types that this type is not effected by </summary>
        public TypeName[] NoEffectFrom { get { return m_noEffectFrom; } }
        #endregion

        public override string ToString()
        {
            return Name.ToString();
        }

        /// <summary> Returns the effectivity of this type against the given type </summary>
        public Effectivity CheckEffectivenessAgainst(Type a_defendingType)
        {
            if (Array.IndexOf(m_effectiveAgainst, a_defendingType) != -1) return Effectivity.SuperEffective;
            if (Array.IndexOf(m_weakAgainst, a_defendingType) != -1) return Effectivity.NotEffective;
            if (Array.IndexOf(m_noEffectOn, a_defendingType) != -1) return Effectivity.NoEffect;
            return Effectivity.Regular;
        }

        /// <summary> Returns the effectivity of the given type against this type </summary>
        public Effectivity CheckEffectivenessFrom(Type a_attackingType)
        {
            if (Array.IndexOf(m_weakTo, a_attackingType) != -1) return Effectivity.SuperEffective;
            if (Array.IndexOf(m_resistantTo, a_attackingType) != -1) return Effectivity.NotEffective;
            if (Array.IndexOf(m_noEffectFrom, a_attackingType) != -1) return Effectivity.NoEffect;
            return Effectivity.Regular;
        }
    }
}
