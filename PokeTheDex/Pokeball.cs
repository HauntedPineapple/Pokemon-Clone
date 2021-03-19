using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class Pokeball:Item
    {
        public Pokeball(string name, int value, Item_Type type = Item_Type.Pokeball,string description = "") : base(name, value, Item_Type.Pokeball, description)
        {
            this.name = name;
            this.description = description;
            this.value = value;
        }

        public virtual void TryToCatch()
        {

        }
        public virtual void CalculateCatchModifier()
        {

        }
    }
}
