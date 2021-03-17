using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class Item
    {
        protected string name, description;
        protected int value;
        protected Item_Type itemType;

        public Item(string name, int value, Item_Type iType, string description="")
        {
            this.name = name;
            this.description = description;
            this.value = value;
            itemType = iType;
        }
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public int Value { get { return value; } }

        public new virtual void ToString()
        {

        }
    }
}
