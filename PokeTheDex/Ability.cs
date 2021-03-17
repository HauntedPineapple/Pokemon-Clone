using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class Ability
    {
        string name, description;

        public Ability (string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public string Name { get { return name; } }
        public string Description { get { return description; } }
    }
}
