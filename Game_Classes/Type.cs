using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Classes
{
    class Type
    {
        string name;
        List<String> weakTo, resistantTo, effectiveAgainst, immuneTo;

        public Type(string name, List<String> weaknesses, List<String> resistances, List<String> effectiveness)
        {
            this.name = name;
            weakTo = weaknesses;
            resistantTo = resistances;
            effectiveAgainst = effectiveness;
        }

        public string Name { get { return name; } }
        public List<String> WeakTo { get { return weakTo; } }
        public List<String> ResistantTo { get { return resistantTo; } }
        public List<String> EffectiveAgainst { get { return effectiveAgainst; } }

        public new void ToString()
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(name);
            Console.Write("Weak To: ");
            foreach (string entry in weakTo)
            {
                Console.Write(entry + " ");
            }
            Console.Write("\nResistant To: ");
            foreach (string entry in resistantTo)
            {
                Console.Write(entry + " ");
            }
            Console.Write("\nEffective Against: ");
            foreach (string entry in effectiveAgainst)
            {
                Console.Write(entry + " ");
            }
            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
