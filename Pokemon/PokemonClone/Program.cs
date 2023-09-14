namespace PokemonClone
{
    enum TypeName
    {
        Normal, Water, Fire, Grass, Electric, Ice, Fighting, Poison, Ground,
        Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
    }
    enum Effectivity { Regular, SuperEffective, NotEffective, NoEffect }
    enum Stat { HP, Attack, SpAttack, Defense, SpDefense, Speed }

    internal class Program
    {

        static void Main(string[] args)
        {
            //Dictionary<TypeName, Type> types = new Dictionary<TypeName, Type>();
            CreateTypes();
            PrintTypes(types);
            TestTypeClass(types);

            //Dictionary<string, Dictionary<int, string>> natures = new Dictionary<string, Dictionary<int, string>>();
            CreateNatures();
            PrintNatures();

            //CreateMoves();
            //CreateSpecies();

            //Console.WriteLine("");
        }

        public static Dictionary<string, Dictionary<int, string>> NATURES = new Dictionary<string, Dictionary<int, string>>();
        #region Create Natures
        // public static KeyValuePair<string, Dictionary<int, string>> lonelynature = new KeyValuePair<string, Dictionary<int, string>>("Lonely", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Defense" } });
        static void CreateNatures()
        {
            // a 1 int value indicates the corresponding stat is increased by 10%
            // a -1 int value indicates the corresponding stat is decreased by 10%
            natures.Add("Hardy", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Attack" } });
            natures.Add("Lonely", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Defense" } });
            natures.Add("Adamant", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Special Attack" } });
            natures.Add("Naughty", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Special Defense" } });
            natures.Add("Brave", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Speed" } });

            natures.Add("Bold", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Attack" } });
            natures.Add("Docile", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Defense" } });
            natures.Add("Impish", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Special Attack" } });
            natures.Add("Lax", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Special Defense" } });
            natures.Add("Relaxed", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Speed" } });

            natures.Add("Modest", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Attack" } });
            natures.Add("Mild", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Defense" } });
            natures.Add("Bashful", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Special Attack" } });
            natures.Add("Rash", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Special Defense" } });
            natures.Add("Quiet", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Speed" } });

            natures.Add("Calm", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Attack" } });
            natures.Add("Gentle", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Defense" } });
            natures.Add("Careful", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Special Attack" } });
            natures.Add("Quirky", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Special Defense" } });
            natures.Add("Sassy", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Speed" } });

            natures.Add("Timid", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Attack" } });
            natures.Add("Hasty", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Defense" } });
            natures.Add("Jolly", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Special Attack" } });
            natures.Add("Naive", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Special Defense" } });
            natures.Add("Serious", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Speed" } });
        }
        static void PrintNatures()
        {
            Console.WriteLine("----------------- Natures -----------------");
            foreach (KeyValuePair<string, Dictionary<int, string>> kvp in natures)
            {
                Console.Write(kvp.Key + ": ");
                foreach (KeyValuePair<int, string> entry in kvp.Value)
                {
                    if (entry.Key.Equals(1))
                        Console.Write("Increases " + entry.Value);
                    if (entry.Key.Equals(-1))
                        Console.Write(" / Decreases " + entry.Value + "\n");
                }
            }
        }
        #endregion

        public static Dictionary<TypeName, Type> TYPES = new Dictionary<TypeName, Type>();
        #region Type Creation
        // public static Type NORMAL = new Type(TypeName.Normal, new TypeName[] { }, new TypeName[] { TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Ghost }, new TypeName[] { }, new TypeName[] { TypeName.Fighting }, new TypeName[] { TypeName.Ghost }));
        static void CreateTypes()
        {
            types.Add(TypeName.Normal, new Type(TypeName.Normal, new TypeName[] { }, new TypeName[] { TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Ghost }, new TypeName[] { }, new TypeName[] { TypeName.Fighting }, new TypeName[] { TypeName.Ghost }));
            types.Add(TypeName.Fire, new Type(TypeName.Fire, new TypeName[] { TypeName.Grass, TypeName.Ice, TypeName.Bug, TypeName.Steel }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Rock, TypeName.Dragon }, new TypeName[] { }, new TypeName[] { TypeName.Fire, TypeName.Grass, TypeName.Ice, TypeName.Bug, TypeName.Steel, TypeName.Fairy }, new TypeName[] { TypeName.Water, TypeName.Ground, TypeName.Rock }, new TypeName[] { }));
            types.Add(TypeName.Water, new Type(TypeName.Water, new TypeName[] { TypeName.Fire, TypeName.Ground, TypeName.Rock }, new TypeName[] { TypeName.Water, TypeName.Grass, TypeName.Dragon }, new TypeName[] { }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Ice, TypeName.Steel }, new TypeName[] { TypeName.Electric, TypeName.Grass }, new TypeName[] { }));
            types.Add(TypeName.Electric, new Type(TypeName.Electric, new TypeName[] { TypeName.Water, TypeName.Flying }, new TypeName[] { TypeName.Electric, TypeName.Grass, TypeName.Dragon }, new TypeName[] { TypeName.Ground }, new TypeName[] { TypeName.Electric, TypeName.Flying, TypeName.Steel }, new TypeName[] { TypeName.Ground }, new TypeName[] { }));
            types.Add(TypeName.Grass, new Type(TypeName.Grass, new TypeName[] { TypeName.Water, TypeName.Ground, TypeName.Rock }, new TypeName[] { TypeName.Fire, TypeName.Grass, TypeName.Poison, TypeName.Flying, TypeName.Bug, TypeName.Dragon, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Water, TypeName.Electric, TypeName.Grass, TypeName.Ground }, new TypeName[] { TypeName.Fire, TypeName.Ice, TypeName.Poison, TypeName.Flying, TypeName.Bug }, new TypeName[] { }));
            types.Add(TypeName.Ice, new Type(TypeName.Ice, new TypeName[] { TypeName.Grass, TypeName.Ground, TypeName.Flying, TypeName.Dragon }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Ice, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Ice }, new TypeName[] { TypeName.Fire, TypeName.Fighting, TypeName.Rock, TypeName.Steel }, new TypeName[] { }));
            types.Add(TypeName.Fighting, new Type(TypeName.Fighting, new TypeName[] { TypeName.Normal, TypeName.Ice, TypeName.Rock, TypeName.Dark, TypeName.Steel }, new TypeName[] { TypeName.Poison, TypeName.Flying, TypeName.Psychic, TypeName.Bug, TypeName.Fairy }, new TypeName[] { TypeName.Ghost }, new TypeName[] { TypeName.Bug, TypeName.Rock, TypeName.Dark }, new TypeName[] { TypeName.Flying, TypeName.Psychic, TypeName.Fairy }, new TypeName[] { }));
            types.Add(TypeName.Poison, new Type(TypeName.Poison, new TypeName[] { TypeName.Grass, TypeName.Fairy }, new TypeName[] { TypeName.Poison, TypeName.Ground, TypeName.Rock, TypeName.Ghost }, new TypeName[] { TypeName.Steel }, new TypeName[] { TypeName.Grass, TypeName.Fighting, TypeName.Poison, TypeName.Bug, TypeName.Fairy }, new TypeName[] { TypeName.Ground, TypeName.Psychic }, new TypeName[] { }));
            types.Add(TypeName.Ground, new Type(TypeName.Ground, new TypeName[] { TypeName.Fire, TypeName.Electric, TypeName.Poison, TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Grass, TypeName.Bug }, new TypeName[] { TypeName.Flying }, new TypeName[] { TypeName.Poison, TypeName.Rock }, new TypeName[] { TypeName.Water, TypeName.Grass, TypeName.Ice }, new TypeName[] { TypeName.Electric }));
            types.Add(TypeName.Flying, new Type(TypeName.Flying, new TypeName[] { TypeName.Grass, TypeName.Bug, TypeName.Fighting }, new TypeName[] { TypeName.Electric, TypeName.Rock, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Grass, TypeName.Fighting, TypeName.Bug }, new TypeName[] { TypeName.Electric, TypeName.Ice, TypeName.Rock }, new TypeName[] { TypeName.Ground }));
            types.Add(TypeName.Psychic, new Type(TypeName.Psychic, new TypeName[] { TypeName.Fighting, TypeName.Poison }, new TypeName[] { TypeName.Psychic, TypeName.Steel }, new TypeName[] { TypeName.Dark }, new TypeName[] { TypeName.Fighting, TypeName.Psychic }, new TypeName[] { TypeName.Bug, TypeName.Ghost, TypeName.Dark }, new TypeName[] { }));
            types.Add(TypeName.Bug, new Type(TypeName.Bug, new TypeName[] { TypeName.Grass, TypeName.Psychic, TypeName.Dark }, new TypeName[] { TypeName.Fire, TypeName.Fighting, TypeName.Poison, TypeName.Flying, TypeName.Ghost, TypeName.Steel, TypeName.Fairy }, new TypeName[] { }, new TypeName[] { TypeName.Grass, TypeName.Fighting, TypeName.Ground }, new TypeName[] { TypeName.Fire, TypeName.Flying, TypeName.Rock }, new TypeName[] { }));
            types.Add(TypeName.Rock, new Type(TypeName.Rock, new TypeName[] { TypeName.Fire, TypeName.Ice, TypeName.Flying, TypeName.Bug }, new TypeName[] { TypeName.Fighting, TypeName.Ground, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Normal, TypeName.Fire, TypeName.Poison, TypeName.Flying }, new TypeName[] { TypeName.Water, TypeName.Grass, TypeName.Fighting, TypeName.Ground, TypeName.Steel }, new TypeName[] { }));
            types.Add(TypeName.Ghost, new Type(TypeName.Ghost, new TypeName[] { TypeName.Psychic, TypeName.Ghost }, new TypeName[] { TypeName.Dark }, new TypeName[] { TypeName.Normal }, new TypeName[] { TypeName.Poison, TypeName.Bug }, new TypeName[] { TypeName.Ghost, TypeName.Dark }, new TypeName[] { TypeName.Normal, TypeName.Fighting }));
            types.Add(TypeName.Dragon, new Type(TypeName.Dragon, new TypeName[] { TypeName.Dragon }, new TypeName[] { TypeName.Steel }, new TypeName[] { TypeName.Fairy }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Electric, TypeName.Grass }, new TypeName[] { TypeName.Ice, TypeName.Dragon, TypeName.Fairy }, new TypeName[] { }));
            types.Add(TypeName.Dark, new Type(TypeName.Dark, new TypeName[] { TypeName.Psychic, TypeName.Ghost }, new TypeName[] { TypeName.Fighting, TypeName.Dark, TypeName.Fairy }, new TypeName[] { }, new TypeName[] { TypeName.Ghost, TypeName.Dark }, new TypeName[] { TypeName.Fighting, TypeName.Bug, TypeName.Fairy }, new TypeName[] { TypeName.Psychic }));
            types.Add(TypeName.Steel, new Type(TypeName.Steel, new TypeName[] { TypeName.Ice, TypeName.Rock, TypeName.Fairy }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Electric, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Normal, TypeName.Grass, TypeName.Ice, TypeName.Flying, TypeName.Psychic, TypeName.Bug, TypeName.Rock, TypeName.Dragon, TypeName.Steel, TypeName.Fairy }, new TypeName[] { TypeName.Fire, TypeName.Fighting, TypeName.Ground }, new TypeName[] { TypeName.Poison }));
            types.Add(TypeName.Fairy, new Type(TypeName.Fairy, new TypeName[] { TypeName.Fighting, TypeName.Dragon, TypeName.Dark }, new TypeName[] { TypeName.Fire, TypeName.Poison, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Fighting, TypeName.Bug, TypeName.Dark }, new TypeName[] { TypeName.Poison, TypeName.Steel }, new TypeName[] { TypeName.Dragon }));
        }

        static void PrintTypes(Dictionary<TypeName, Type> types)
        {
            Console.WriteLine("----------------- Types -----------------");
            foreach (KeyValuePair<TypeName, Type> kvp in types)
            {
                Console.Write(kvp.Key.ToString());
                Type currentType = kvp.Value;

                Console.Write("\n  Effective against: ");
                foreach (TypeName type in currentType.EffectiveAgainst) { Console.Write(type.ToString() + " "); }

                Console.Write("\n  Weak against: ");
                foreach (TypeName type in currentType.WeakAgainst) { Console.Write(type.ToString() + " "); }

                Console.Write("\n  No effect on: ");
                foreach (TypeName type in currentType.NoEffectOn) { Console.Write(type.ToString() + " "); }

                Console.Write("\n  Resistant to: ");
                foreach (TypeName type in currentType.ResistantTo) { Console.Write(type.ToString() + " "); }

                Console.Write("\n  Weak to: ");
                foreach (TypeName type in currentType.WeakTo) { Console.Write(type.ToString() + " "); }

                Console.Write("\n  No effect from: ");
                foreach (TypeName type in currentType.NoEffectFrom) { Console.Write(type.ToString() + " "); }

                Console.WriteLine("\n");
            }
        }

        static void TestTypeClass(Dictionary<TypeName, Type> types)
        {
            Console.WriteLine("----------------- Type Testing -----------------");
            Type defendingType, attackingType;
            Type[] defendingDualType;

            attackingType = types[TypeName.Electric];
            defendingType = types[TypeName.Water];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingType = types[TypeName.Grass];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingType = types[TypeName.Fire];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingType = types[TypeName.Ground];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingDualType = new Type[] { types[TypeName.Ice], types[TypeName.Bug] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { types[TypeName.Dragon], types[TypeName.Poison] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { types[TypeName.Water], types[TypeName.Flying] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { types[TypeName.Psychic], types[TypeName.Flying] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { types[TypeName.Grass], types[TypeName.Electric] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { types[TypeName.Dark], types[TypeName.Ground] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");

            attackingType = types[TypeName.Fairy];
            defendingType = types[TypeName.Poison];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            attackingType = types[TypeName.Dragon];
            defendingDualType = new Type[] { types[TypeName.Ice], types[TypeName.Bug] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");

            //bool isTesting = true;
            //while (isTesting)
            //{
            //    Console.WriteLine(" ");


            //    if (Console.ReadLine() == "stop")
            //    {
            //        isTesting = false;
            //        break;
            //    }
            //}
        }
        #endregion

        #region Moves
        static Move? move_flamethrower;
        static void CreateMoves()
        {

        }
        #endregion

        #region Species
        static Species? species_bulbasaur;
        static void CreateSpecies()
        {

        }
        #endregion
    }
}