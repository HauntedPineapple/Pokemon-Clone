using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheDex
{
    class Move
    {
        string name, description;
        Type moveType;
        bool isPhysical;
        int powerPoints, basePower, accuracy;

        public Move(string name, Type type, bool physical, int pp, int bp, int acc, string description = "")
        {
            this.name = name;
            moveType = type;
            isPhysical = physical;
            powerPoints = pp;
            basePower = bp;
            accuracy = acc;
            this.description = description;
        }

        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public bool IsPhysical { get { return isPhysical; } }
        public Type MoveType { get { return moveType; } }
        public int BasePower { get { return basePower; } }
        public int Accuracy { get { return accuracy; } }
        public int PP { get { return powerPoints; } set { powerPoints = value; } }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(name);
            if (description.Length > 1)
            {
                Console.WriteLine(description);
            }
            Console.Write("Type: " + moveType.Name + "\t");
            if (isPhysical)
            {
                Console.Write("Category: Physical\n");
            }
            else
            {
                Console.Write("Category: Special\n");
            }
            Console.WriteLine("PP: " + powerPoints + "\tPower: " + basePower + "\tAccuracy: " + accuracy);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

