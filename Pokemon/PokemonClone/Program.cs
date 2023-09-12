namespace PokemonClone
{
    enum TypeName
    {
        Normal, Water, Fire, Grass, Electric, Ice, Fighting, Poison, Ground,
        Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
    }

    enum Effectivity { Regular, SuperEffective, NotEffective, NoEffect }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<TypeName, Type> types = new Dictionary<TypeName, Type>();
            CreateTypes(types);
            //CreateMoves();
            //CreateSpecies();

            Dictionary<string, Dictionary<int, string>> natures = new Dictionary<string, Dictionary<int, string>>();
            CreateNatures(natures);

            foreach (KeyValuePair<string, Dictionary<int, string>> kvp in natures)
            {
                Console.WriteLine(kvp.Key);
                foreach (KeyValuePair<int, string> entry in kvp.Value)
                    Console.WriteLine("\n\tKey = {0}, Value = {1}",
                                  entry.Key, entry.Value);
            }

            Console.WriteLine("");
        }

        static void CreateNatures(Dictionary<string, Dictionary<int, string>> a_natures)
        {
            // a 1 int value indicates the corresponding stat is increased by 10%
            // a -1 int value indicates the corresponding stat is decreased by 10%
            a_natures.Add("Hardy", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Attack" } });
            a_natures.Add("Lonely", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Defense" } });
            a_natures.Add("Adamant", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Special Attack" } });
            a_natures.Add("Naughty", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Special Defense" } });
            a_natures.Add("Brave", new Dictionary<int, string> { { 1, "Attack" }, { -1, "Speed" } });

            a_natures.Add("Bold", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Attack" } });
            a_natures.Add("Docile", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Defense" } });
            a_natures.Add("Impish", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Special Attack" } });
            a_natures.Add("Lax", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Special Defense" } });
            a_natures.Add("Relaxed", new Dictionary<int, string> { { 1, "Defense" }, { -1, "Speed" } });

            a_natures.Add("Modest", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Attack" } });
            a_natures.Add("Mild", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Defense" } });
            a_natures.Add("Bashful", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Special Attack" } });
            a_natures.Add("Rash", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Special Defense" } });
            a_natures.Add("Quiet", new Dictionary<int, string> { { 1, "Special Attack" }, { -1, "Speed" } });

            a_natures.Add("Calm", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Attack" } });
            a_natures.Add("Gentle", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Defense" } });
            a_natures.Add("Careful", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Special Attack" } });
            a_natures.Add("Quirky", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Special Defense" } });
            a_natures.Add("Sassy", new Dictionary<int, string> { { 1, "Special Defense" }, { -1, "Speed" } });

            a_natures.Add("Timid", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Attack" } });
            a_natures.Add("Hasty", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Defense" } });
            a_natures.Add("Jolly", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Special Attack" } });
            a_natures.Add("Naive", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Special Defense" } });
            a_natures.Add("Serious", new Dictionary<int, string> { { 1, "Speed" }, { -1, "Speed" } });
        }

        #region Types    
        static void CreateTypes(Dictionary<TypeName, Type> a_types)
        {
            a_types.Add(TypeName.Normal, new Type(TypeName.Normal, new TypeName[] { }, new TypeName[] { TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Ghost }));

            a_types.Add(TypeName.Fire, new Type(TypeName.Fire, new TypeName[] {TypeName.Grass, TypeName.Ice, TypeName.Bug, TypeName.Steel}, new TypeName[] {TypeName.Fire, TypeName.Water, TypeName.Rock, TypeName.Dragon}, new TypeName[] {}));
           
            a_types.Add(TypeName.Water, new Type(TypeName.Water, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Grass, new Type(TypeName.Grass, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Electric, new Type(TypeName.Electric, new TypeName[] {}, new TypeName[] {}, new TypeName[] {TypeName.Ground}));

            a_types.Add(TypeName.Ice, new Type(TypeName.Ice, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Fighting, new Type(TypeName.Fighting, new TypeName[] {}, new TypeName[] {}, new TypeName[] {TypeName.Ghost}));

            a_types.Add(TypeName.Poison, new Type(TypeName.Poison, new TypeName[] {}, new TypeName[] {}, new TypeName[] {TypeName.Steel}));

            a_types.Add(TypeName.Ground, new Type(TypeName.Ground, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Flying, new Type(TypeName.Flying, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Psychic, new Type(TypeName.Psychic, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Bug, new Type(TypeName.Bug, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Rock, new Type(TypeName.Rock, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Ghost, new Type(TypeName.Ghost, new TypeName[] {}, new TypeName[] {}, new TypeName[] {TypeName.Normal}));

            a_types.Add(TypeName.Dragon, new Type(TypeName.Dragon, new TypeName[] {}, new TypeName[] {}, new TypeName[] {TypeName.Fairy}));

            a_types.Add(TypeName.Dark, new Type(TypeName.Dark, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Steel, new Type(TypeName.Steel, new TypeName[] {}, new TypeName[] {}, new TypeName[] {}));

            a_types.Add(TypeName.Fairy, new Type(TypeName.Fairy, new TypeName[] {}, new TypeName[] {TypeName.Fire, TypeName.Ground}, new TypeName[] {}));
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