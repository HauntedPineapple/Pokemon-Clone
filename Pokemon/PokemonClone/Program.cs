namespace PokemonClone
{
    enum TypeName
    {
        Normal, Water, Fire, Grass, Electric, Ice, Fighting, Poison, Ground,
        Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
    }

    internal class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        #region Types
        static Type? type_normal;
        #endregion

        #region Moves
        static Move? move_flamethrower;
        #endregion

        #region Species
        static Species? species_bulbasaur;
        #endregion
    }
}