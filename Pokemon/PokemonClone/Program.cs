namespace PokemonClone
{
    enum TypeName { Normal, Water, Fire, Grass, Electric, Ice, Fighting, Poison, Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy }
    enum Effectivity { Regular, SuperEffective, NotEffective, NoEffect }
    enum StatName { HP, Attack, SpecialAttack, Defense, SpecialDefense, Speed }
    struct Stats
    {
        public int hp;
        public int attack;
        public int specialAttack;
        public int defense;
        public int specialDefense;
        public int speed;

        public Stats(int a_hp, int a_attack, int a_specialAttack, int a_defense, int a_specialDefense, int a_speed)
        {
            hp = a_hp;
            attack = a_attack;
            specialAttack = a_specialAttack;
            defense = a_defense;
            specialDefense = a_specialDefense;
            speed = a_speed;
        }
    }

    struct Nature
    {
        public string name;
        public StatName increasedStat;
        public StatName decreasedStat;

        public Nature(string a_name, StatName a_increasedStat, StatName a_decreasedStat)
        {
            name = a_name;
            increasedStat = a_increasedStat;
            decreasedStat = a_decreasedStat;
        }
    }

    struct Moveset
    {
        public Move? move1 = null;
        public Move? move2 = null;
        public Move? move3 = null;
        public Move? move4 = null;
        public int move1PP = -1;
        public int move2PP = -1;
        public int move3PP = -1;
        public int move4PP = -1;
        public int numMoves = 0;

        public Moveset(Move? a_move1, Move? a_move2, Move? a_move3, Move? a_move4)
        {
            move1 = a_move1;
            if (a_move1 != null)
            {
                move1PP = a_move1.PP;
                numMoves++;
            }
            move2 = a_move2;
            if (a_move2 != null)
            {
                move2PP = a_move2.PP;
                numMoves++;
            }
            move3 = a_move3;
            if (a_move3 != null)
            {
                move3PP = a_move3.PP;
                numMoves++;
            }
            move4 = a_move4;
            if (a_move4 != null)
            {
                move4PP = a_move4.PP;
                numMoves++;
            }
        }

        public void LearnNewMove(Move a_move)
        {
            if (numMoves == 4)
            {

            }
            else
            {
                numMoves++;
            }
        }

        public bool CanUseMove(Move a_move)
        {
            if (43 == 1)
            {

            }
            return true;
        }
    }

    internal class Program
    {
        #region Natures
        public static Nature Hardy = new Nature("Hardy", StatName.Attack, StatName.Attack);
        public static Nature Lonely = new Nature("Lonely", StatName.Attack, StatName.Defense);
        public static Nature Adamant = new Nature("Adamant", StatName.Attack, StatName.SpecialAttack);
        public static Nature Naughty = new Nature("Naughty", StatName.Attack, StatName.SpecialDefense);
        public static Nature Brave = new Nature("Brave", StatName.Attack, StatName.Speed);

        public static Nature Bold = new Nature("Bold", StatName.Defense, StatName.Attack);
        public static Nature Docile = new Nature("Docile", StatName.Defense, StatName.Defense);
        public static Nature Impish = new Nature("Impish", StatName.Defense, StatName.SpecialAttack);
        public static Nature Lax = new Nature("Lax", StatName.Defense, StatName.SpecialDefense);
        public static Nature Relaxed = new Nature("Relaxed", StatName.Defense, StatName.Speed);

        public static Nature Modest = new Nature("Modest", StatName.SpecialAttack, StatName.Attack);
        public static Nature Mild = new Nature("Mild", StatName.SpecialAttack, StatName.Defense);
        public static Nature Bashful = new Nature("Bashful", StatName.SpecialAttack, StatName.SpecialAttack);
        public static Nature Rash = new Nature("Rash", StatName.SpecialAttack, StatName.SpecialDefense);
        public static Nature Quiet = new Nature("Quiet", StatName.SpecialAttack, StatName.Speed);

        public static Nature Calm = new Nature("Calm", StatName.SpecialDefense, StatName.Attack);
        public static Nature Gentle = new Nature("Gentle", StatName.SpecialDefense, StatName.Defense);
        public static Nature Careful = new Nature("Careful", StatName.SpecialDefense, StatName.SpecialAttack);
        public static Nature Quirky = new Nature("Quirky", StatName.SpecialDefense, StatName.SpecialDefense);
        public static Nature Sassy = new Nature("Sassy", StatName.SpecialDefense, StatName.Speed);

        public static Nature Timid = new Nature("Timid", StatName.Speed, StatName.Attack);
        public static Nature Hasty = new Nature("Hasty", StatName.Speed, StatName.Defense);
        public static Nature Jolly = new Nature("Jolly", StatName.Speed, StatName.SpecialAttack);
        public static Nature Naive = new Nature("Naive", StatName.Speed, StatName.SpecialDefense);
        public static Nature Serious = new Nature("Serious", StatName.Speed, StatName.Speed);
        #endregion

        static void Main(string[] args)
        {
            //Dictionary<TypeName, Type> types = new Dictionary<TypeName, Type>();
            CreateTypes();
            PrintTypes();
            TestTypeClass();

            //CreateMoves();
            //CreateSpecies();

            //Console.WriteLine("");
        }



        public static Dictionary<TypeName, Type> TYPES = new Dictionary<TypeName, Type>();
        #region Type Creation
        // public static Type NORMAL = new Type(TypeName.Normal, new TypeName[] { }, new TypeName[] { TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Ghost }, new TypeName[] { }, new TypeName[] { TypeName.Fighting }, new TypeName[] { TypeName.Ghost }));
        static void CreateTypes()
        {
            TYPES.Add(TypeName.Normal, new Type(TypeName.Normal, new TypeName[] { }, new TypeName[] { TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Ghost }, new TypeName[] { }, new TypeName[] { TypeName.Fighting }, new TypeName[] { TypeName.Ghost }));
            TYPES.Add(TypeName.Fire, new Type(TypeName.Fire, new TypeName[] { TypeName.Grass, TypeName.Ice, TypeName.Bug, TypeName.Steel }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Rock, TypeName.Dragon }, new TypeName[] { }, new TypeName[] { TypeName.Fire, TypeName.Grass, TypeName.Ice, TypeName.Bug, TypeName.Steel, TypeName.Fairy }, new TypeName[] { TypeName.Water, TypeName.Ground, TypeName.Rock }, new TypeName[] { }));
            TYPES.Add(TypeName.Water, new Type(TypeName.Water, new TypeName[] { TypeName.Fire, TypeName.Ground, TypeName.Rock }, new TypeName[] { TypeName.Water, TypeName.Grass, TypeName.Dragon }, new TypeName[] { }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Ice, TypeName.Steel }, new TypeName[] { TypeName.Electric, TypeName.Grass }, new TypeName[] { }));
            TYPES.Add(TypeName.Electric, new Type(TypeName.Electric, new TypeName[] { TypeName.Water, TypeName.Flying }, new TypeName[] { TypeName.Electric, TypeName.Grass, TypeName.Dragon }, new TypeName[] { TypeName.Ground }, new TypeName[] { TypeName.Electric, TypeName.Flying, TypeName.Steel }, new TypeName[] { TypeName.Ground }, new TypeName[] { }));
            TYPES.Add(TypeName.Grass, new Type(TypeName.Grass, new TypeName[] { TypeName.Water, TypeName.Ground, TypeName.Rock }, new TypeName[] { TypeName.Fire, TypeName.Grass, TypeName.Poison, TypeName.Flying, TypeName.Bug, TypeName.Dragon, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Water, TypeName.Electric, TypeName.Grass, TypeName.Ground }, new TypeName[] { TypeName.Fire, TypeName.Ice, TypeName.Poison, TypeName.Flying, TypeName.Bug }, new TypeName[] { }));
            TYPES.Add(TypeName.Ice, new Type(TypeName.Ice, new TypeName[] { TypeName.Grass, TypeName.Ground, TypeName.Flying, TypeName.Dragon }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Ice, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Ice }, new TypeName[] { TypeName.Fire, TypeName.Fighting, TypeName.Rock, TypeName.Steel }, new TypeName[] { }));
            TYPES.Add(TypeName.Fighting, new Type(TypeName.Fighting, new TypeName[] { TypeName.Normal, TypeName.Ice, TypeName.Rock, TypeName.Dark, TypeName.Steel }, new TypeName[] { TypeName.Poison, TypeName.Flying, TypeName.Psychic, TypeName.Bug, TypeName.Fairy }, new TypeName[] { TypeName.Ghost }, new TypeName[] { TypeName.Bug, TypeName.Rock, TypeName.Dark }, new TypeName[] { TypeName.Flying, TypeName.Psychic, TypeName.Fairy }, new TypeName[] { }));
            TYPES.Add(TypeName.Poison, new Type(TypeName.Poison, new TypeName[] { TypeName.Grass, TypeName.Fairy }, new TypeName[] { TypeName.Poison, TypeName.Ground, TypeName.Rock, TypeName.Ghost }, new TypeName[] { TypeName.Steel }, new TypeName[] { TypeName.Grass, TypeName.Fighting, TypeName.Poison, TypeName.Bug, TypeName.Fairy }, new TypeName[] { TypeName.Ground, TypeName.Psychic }, new TypeName[] { }));
            TYPES.Add(TypeName.Ground, new Type(TypeName.Ground, new TypeName[] { TypeName.Fire, TypeName.Electric, TypeName.Poison, TypeName.Rock, TypeName.Steel }, new TypeName[] { TypeName.Grass, TypeName.Bug }, new TypeName[] { TypeName.Flying }, new TypeName[] { TypeName.Poison, TypeName.Rock }, new TypeName[] { TypeName.Water, TypeName.Grass, TypeName.Ice }, new TypeName[] { TypeName.Electric }));
            TYPES.Add(TypeName.Flying, new Type(TypeName.Flying, new TypeName[] { TypeName.Grass, TypeName.Bug, TypeName.Fighting }, new TypeName[] { TypeName.Electric, TypeName.Rock, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Grass, TypeName.Fighting, TypeName.Bug }, new TypeName[] { TypeName.Electric, TypeName.Ice, TypeName.Rock }, new TypeName[] { TypeName.Ground }));
            TYPES.Add(TypeName.Psychic, new Type(TypeName.Psychic, new TypeName[] { TypeName.Fighting, TypeName.Poison }, new TypeName[] { TypeName.Psychic, TypeName.Steel }, new TypeName[] { TypeName.Dark }, new TypeName[] { TypeName.Fighting, TypeName.Psychic }, new TypeName[] { TypeName.Bug, TypeName.Ghost, TypeName.Dark }, new TypeName[] { }));
            TYPES.Add(TypeName.Bug, new Type(TypeName.Bug, new TypeName[] { TypeName.Grass, TypeName.Psychic, TypeName.Dark }, new TypeName[] { TypeName.Fire, TypeName.Fighting, TypeName.Poison, TypeName.Flying, TypeName.Ghost, TypeName.Steel, TypeName.Fairy }, new TypeName[] { }, new TypeName[] { TypeName.Grass, TypeName.Fighting, TypeName.Ground }, new TypeName[] { TypeName.Fire, TypeName.Flying, TypeName.Rock }, new TypeName[] { }));
            TYPES.Add(TypeName.Rock, new Type(TypeName.Rock, new TypeName[] { TypeName.Fire, TypeName.Ice, TypeName.Flying, TypeName.Bug }, new TypeName[] { TypeName.Fighting, TypeName.Ground, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Normal, TypeName.Fire, TypeName.Poison, TypeName.Flying }, new TypeName[] { TypeName.Water, TypeName.Grass, TypeName.Fighting, TypeName.Ground, TypeName.Steel }, new TypeName[] { }));
            TYPES.Add(TypeName.Ghost, new Type(TypeName.Ghost, new TypeName[] { TypeName.Psychic, TypeName.Ghost }, new TypeName[] { TypeName.Dark }, new TypeName[] { TypeName.Normal }, new TypeName[] { TypeName.Poison, TypeName.Bug }, new TypeName[] { TypeName.Ghost, TypeName.Dark }, new TypeName[] { TypeName.Normal, TypeName.Fighting }));
            TYPES.Add(TypeName.Dragon, new Type(TypeName.Dragon, new TypeName[] { TypeName.Dragon }, new TypeName[] { TypeName.Steel }, new TypeName[] { TypeName.Fairy }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Electric, TypeName.Grass }, new TypeName[] { TypeName.Ice, TypeName.Dragon, TypeName.Fairy }, new TypeName[] { }));
            TYPES.Add(TypeName.Dark, new Type(TypeName.Dark, new TypeName[] { TypeName.Psychic, TypeName.Ghost }, new TypeName[] { TypeName.Fighting, TypeName.Dark, TypeName.Fairy }, new TypeName[] { }, new TypeName[] { TypeName.Ghost, TypeName.Dark }, new TypeName[] { TypeName.Fighting, TypeName.Bug, TypeName.Fairy }, new TypeName[] { TypeName.Psychic }));
            TYPES.Add(TypeName.Steel, new Type(TypeName.Steel, new TypeName[] { TypeName.Ice, TypeName.Rock, TypeName.Fairy }, new TypeName[] { TypeName.Fire, TypeName.Water, TypeName.Electric, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Normal, TypeName.Grass, TypeName.Ice, TypeName.Flying, TypeName.Psychic, TypeName.Bug, TypeName.Rock, TypeName.Dragon, TypeName.Steel, TypeName.Fairy }, new TypeName[] { TypeName.Fire, TypeName.Fighting, TypeName.Ground }, new TypeName[] { TypeName.Poison }));
            TYPES.Add(TypeName.Fairy, new Type(TypeName.Fairy, new TypeName[] { TypeName.Fighting, TypeName.Dragon, TypeName.Dark }, new TypeName[] { TypeName.Fire, TypeName.Poison, TypeName.Steel }, new TypeName[] { }, new TypeName[] { TypeName.Fighting, TypeName.Bug, TypeName.Dark }, new TypeName[] { TypeName.Poison, TypeName.Steel }, new TypeName[] { TypeName.Dragon }));
        }

        static void PrintTypes()
        {
            Console.WriteLine("----------------- Types -----------------");
            foreach (KeyValuePair<TypeName, Type> kvp in TYPES)
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

        static void TestTypeClass()
        {
            Console.WriteLine("----------------- Type Testing -----------------");
            Type defendingType, attackingType;
            Type[] defendingDualType;

            attackingType = TYPES[TypeName.Electric];
            defendingType = TYPES[TypeName.Water];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingType = TYPES[TypeName.Grass];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingType = TYPES[TypeName.Fire];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingType = TYPES[TypeName.Ground];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            defendingDualType = new Type[] { TYPES[TypeName.Ice], TYPES[TypeName.Bug] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { TYPES[TypeName.Dragon], TYPES[TypeName.Poison] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { TYPES[TypeName.Water], TYPES[TypeName.Flying] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { TYPES[TypeName.Psychic], TYPES[TypeName.Flying] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { TYPES[TypeName.Grass], TYPES[TypeName.Electric] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");
            defendingDualType = new Type[] { TYPES[TypeName.Dark], TYPES[TypeName.Ground] };
            Console.WriteLine(attackingType + " vs. " + defendingDualType[0] + "/" + defendingDualType[1] + " does " + Type.CalculateDamageMultiplier(attackingType, defendingDualType) + "x damage");

            attackingType = TYPES[TypeName.Fairy];
            defendingType = TYPES[TypeName.Poison];
            Console.WriteLine(attackingType + " vs. " + defendingType + " does " + Type.CalculateDamageMultiplier(attackingType, defendingType) + "x damage");
            attackingType = TYPES[TypeName.Dragon];
            defendingDualType = new Type[] { TYPES[TypeName.Ice], TYPES[TypeName.Bug] };
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