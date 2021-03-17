using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheMon
{
    class Move
    {
        string name, description;
        Type moveType;
        bool isPhysical, isDamaging;
        int powerPoints, basePower, accuracy;
        //TODO: add priority
        public Move(string name, Type type, bool damaging, bool physical, int pp, int bp, int acc, string description = "")
        {
            this.name = name;
            moveType = type;
            isDamaging = damaging;
            isPhysical = physical;
            powerPoints = pp;
            basePower = bp;
            accuracy = acc;
            this.description = description;
        }

        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public bool IsPhysical { get { return isPhysical; } }
        public bool IsDamaging { get { return isDamaging; } }
        public Type MoveType { get { return moveType; } }
        public int BasePower { get { return basePower; } }
        public int Accuracy { get { return accuracy; } }
        public int PP { get { return powerPoints; } set { powerPoints = value; } }

        public new void ToString()
        {
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(name);
            if (description.Length > 1)
            {
                Console.WriteLine(description);
            }
            Console.Write("Type: " + moveType.Name+"\t");
            if (isPhysical&&isDamaging)
            {
                Console.Write("Category: Physical\n");
            }
            else if(!isPhysical&&isDamaging)
            {
                Console.Write("Category: Special\n");
            }
            else if (!isDamaging)
            {
                Console.Write("Category: Non-Damaging\n");
            }
            Console.WriteLine("PP: "+powerPoints+"\tPower: "+basePower+"\tAccuracy: "+accuracy);
            //Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
