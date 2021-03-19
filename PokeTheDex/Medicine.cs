using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class Medicine:Item
    {
        public Medicine(string name, int value, Item_Type type = Item_Type.Medicine, string description = "") : base(name, value, Item_Type.Medicine, description)
        {
            this.name = name;
            this.description = description;
            this.value = value;
        }

    }
}
