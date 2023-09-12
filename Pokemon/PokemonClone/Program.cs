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
            CreateTypes();
            CreateMoves();
            CreateNatures();
            CreateSpecies();
            Console.WriteLine("Hello, World!");
        }


        static void CreateNatures()
        {
            Dictionary<string, int> natureValue = new Dictionary<string, int>();
            natures.Add("NATURE", natureValue);
        }

        static Dictionary<string, Dictionary<string, int>> natures;
        #region Types
        static Type? type_normal;
        #endregion
        static void CreateTypes()
        {

        }

        #region Moves
        static Move? move_flamethrower;
        #endregion
        static void CreateMoves()
        {

        }

        #region Species
        static Species? species_bulbasaur;
        #endregion
        static void CreateSpecies()
        {

        }
    }
}