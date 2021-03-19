using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class BattleItem:Item
    {
        public BattleItem(string name, int value, Item_Type type = Item_Type.Battle_Item, string description = "") : base(name, value, Item_Type.Battle_Item, description)
        {
            this.name = name;
            this.description = description;
            this.value = value;
        }

    }
}
