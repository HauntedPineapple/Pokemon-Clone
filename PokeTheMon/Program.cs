using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTheMon
{
    class Program
    {
        static void Main(string[] args)
        {
            createTypes();
            createMoves();
            makePokemon();

            Brick_Break.ToString();
            Console.WriteLine();
            Grass.ToString();
            Console.WriteLine();
            Mimikyu.ToString();
            Console.WriteLine();
            Blaziken.ToString();

            Console.ReadLine();
        }
        #region Types
        static Type Fighting, Fairy, Dragon, Steel, Electric;
        static Type Fire, Water, Grass, Bug, Ground, Rock, Poison;
        static Type Psychic, Dark, Normal, Ice, Flying, Ghost;
        #endregion
        static void createTypes()
        {
            List<String> w = new List<string> { "Fairy", "Psychic", "Flying" };
            List<String> r = new List<string> { "Dark", "Rock", "Bug" };
            List<String> e = new List<string> { "Normal", "Dark", "Steel", "Ice", "Rock" };
            Fighting = new Type("Fighting", w, r, e);
            w = new List<string> { "Poison", "Steel" };
            r = new List<string> { "Fighting", "Dark", "Bug" };
            e = new List<string> { "Dragon", "Dark", "Fighting" };
            Fairy = new Type("Fairy", w, r, e);
            w = new List<string> { "Fire", "Fighting", "Ground" };
            r = new List<string> { "Ice", "Normal", "Grass", "Flying", "Rock", "Psychic", "Dragon", "Fairy", "Steel", "Bug" };
            e = new List<string> { "Fairy", "Rock", "Ice" };
            Steel = new Type("Steel", w, r, e);
            w = new List<string> { "Fighting" };
            r = new List<string> { "None" };
            e = new List<string> { "None" };
            Normal = new Type("Normal", w, r, e);
            w = new List<string> { "Water", "Ground", "Rock" };
            r = new List<string> { "Steel", "Fairy", "Fire", "Grass", "Ice", "Bug" };
            e = new List<string> { "Grass", "Bug", "Steel", "Ice" };
            Fire = new Type("Fire", w, r, e);
            w = new List<string> { "Grass", "Electric" };
            r = new List<string> { "Fire", "Water", "Ice", "Steel" };
            e = new List<string> { "Fire", "Ground", "Rock" };
            Water = new Type("Water", w, r, e);
            w = new List<string> { "Ground" };
            r = new List<string> { "Electric", "Flying", "Steel" };
            e = new List<string> { "Water", "Flying" };
            Electric = new Type("Electric", w, r, e);
            w = new List<string> { "Electric", "Rock", "Ice" };
            r = new List<string> { "Grass", "Fighting", "Bug" };
            e = new List<string> { "Grass", "Fighting", "Bug" };
            Flying = new Type("Flying", w, r, e);
            w = new List<string> { "Water", "Grass", "Ice" };
            r = new List<string> { "Rock", "Poison" };
            e = new List<string> { "Fire", "Electric", "Rock", "Poison", "Steel" };
            Ground = new Type("Ground", w, r, e);
            w = new List<string> { "Water", "Grass", "Ground", "Fighting", "Steel" };
            r = new List<string> { "Poison", "Normal", "Fire", "Flying" };
            e = new List<string> { "Fire", "Flying", "Ice", "Bug" };
            Rock = new Type("Rock", w, r, e);
            w = new List<string> { "Fire", "Rock", "Fighting", "Steel" };
            r = new List<string> { "Ice" };
            e = new List<string> { "Grass", "Flying", "Ground", "Dragon" };
            Ice = new Type("Ice", w, r, e);
            w = new List<string> { "Psychic", "Ground" };
            r = new List<string> { "Poison", "Bug", "Fairy", "Fighting", "Grass" };
            e = new List<string> { "Grass", "Fairy" };
            Poison = new Type("Poison", w, r, e);
            w = new List<string> { "Fire", "Flying", "Rock" };
            r = new List<string> { "Fighting", "Grass", "Ground" };
            e = new List<string> { "Grass", "Dark", "Psychic" };
            Bug = new Type("Bug", w, r, e);
            w = new List<string> { "Ghost", "Dark" };
            r = new List<string> { "Poison", "Bug" };
            e = new List<string> { "Ghost", "Psychic" };
            Ghost = new Type("Ghost", w, r, e);
            w = new List<string> { "Bug", "Ghost", "Dark" };
            r = new List<string> { "Psychic", "Fighting" };
            e = new List<string> { "Fighting", "Poison" };
            Psychic = new Type("Psychic", w, r, e);
            w = new List<string> { "Ice", "Dragon", "Fairy" };
            r = new List<string> { "Electric", "Fire", "Water", "Grass" };
            e = new List<string> { "Dragon" };
            Dragon = new Type("Dragon", w, r, e);
            w = new List<string> { "Fighting", "Bug", "Fairy" };
            r = new List<string> { "Dark", "Ghost" };
            e = new List<string> { "Ghost", "Psychic" };
            Dark = new Type("Dark", w, r, e);
            w = new List<string> { "Bug", "Fire", "Flying", "Ice", "Poison" };
            r = new List<string> { "Electric", "Grass", "Ground", "Water" };
            e = new List<string> { "Ground", "Rock", "Water" };
            Grass = new Type("Grass", w, r, e);
        }

        #region Moves
        static Move Acid, Blizzard, Razor_Leaf, Bulldoze, Dragon_Breath, Rock_Slide;
        static Move Aqua_Tail, Blaze_Kick, Tackle, Shadow_Ball, X_Scissor, Zen_Headbutt;
        static Move Dark_Pulse, Thunder, Moonblast, Brick_Break, Drill_Peck, Iron_Tail;
        static Move Stone_Edge, Swords_Dance, Focus_Blast, Fire_Punch;
        static Move Shadow_Claw, Play_Rough, Shadow_Sneak;
        #endregion
        static void createMoves()
        {
            Acid = new Move("Acid", Poison, true, false, 30, 40, 100, "The opposing Pokémon are attacked with a spray of harsh acid. This may also lower their Sp. Def stats.");
            Aqua_Tail = new Move("Aqua tail", Water, true, true, 10, 90, 90, "The user attacks by swinging its tail as if it were a vicious wave in a raging storm.");
            Blaze_Kick = new Move("Blaze Kick", Fire, true, true, 10, 85, 90, "The user launches a kick with a high critical-hit ratio. It may also leave the target with a burn.");
            Blizzard = new Move("Blizzard", Ice, true, false, 5, 110, 70, "A howling blizzard is summoned to strike the foe. It may also freeze the target solid.");
            Brick_Break = new Move("Brick Break", Fighting, true, true, 15, 75, 10, "The user attacks with a swift chop. It can also break barriers, such as Light Screen and Reflect.");
            Bulldoze = new Move("Bulldoze", Ground, true, true, 20, 60, 100, "The user strikes everything around it by stomping down on the ground. This lowers the Speed stat of those hit.");
            Dark_Pulse = new Move("Dark Pulse", Dark, true, false, 15, 80, 100, "The user releases a horrible aura imbued with dark thoughts. This may also make the target flinch.");
            Dragon_Breath = new Move("Dragon Breath", Dragon, true, false, 20, 60, 100, "The user exhales a mighty gust that inflicts damage. It may also paralyze the target.");
            Drill_Peck = new Move("Drill Peck", Flying, true, true, 20, 80, 100, "A corkscrewing attack with the sharp beak acting as a drill.");
            Iron_Tail = new Move("Iron Tail", Steel, true, true, 15, 100, 75, "The foe is slammed with a steel-hard tail. It may also lower the target's Defense stat.");
            Moonblast = new Move("Moonblast", Fairy, true, false, 15, 95, 100, "Borrowing the power of the moon, the user attacks the target. This may also lower the target's Sp. Atk stat.");
            Razor_Leaf = new Move("Razor Leaf", Grass, true, true, 25, 55, 95, "Sharp-edged leaves are launched to slash at the opposing team. Critical hits land more easily.");
            Rock_Slide = new Move("Rock Slide", Rock, true, true, 10, 75, 90, "Large boulders are hurled at the opposing Pokémon to inflict damage. This may also make the opposing Pokémon flinch.");
            Shadow_Ball = new Move("Shadow Ball", Ghost, true, false, 15, 80, 100, "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.");
            Tackle = new Move("Tackle", Normal, true, true, 35, 40, 100, "A physical attack in which the user charges and slams into the foe with its whole body.");
            Thunder = new Move("Thunder", Electric, true, false, 10, 110, 70, "A wicked thunderbolt is dropped on the target to inflict damage. It may also leave the target with paralysis.");
            X_Scissor = new Move("X-Scissor", Bug, true, true, 15, 80, 10, "The user slashes at the target by crossing its scythes or claws as if they were a pair of scissors");
            Zen_Headbutt = new Move("Zen Headbutt", Psychic, true, true, 15, 80, 90, "The user focuses its willpower to its head and attacks the target. This may also make the target flinch.");

            Stone_Edge = new Move("Stone Edge", Rock, true, true, 5, 100, 80, "The user stabs the target with sharpened stones from below. Critical hits land more easily.");
            Swords_Dance = new Move("Swords Dance", Normal, false, false, 20, 0, 0, "A frenetic dance to uplift the fighting spirit. It sharply raises the user's Attack stat.");
            Focus_Blast = new Move("Focus Blast", Fighting, true, false, 5, 120, 70, "The user heightens its mental focus and unleashes its power. This may also lower the target's Sp. Def.");
            Fire_Punch = new Move("Fire Punch", Fire, true, true, 15, 75, 100, "The target is punched with a fiery fist. It may also leave the target with a burn.");

            Shadow_Claw = new Move("Shadow Claw", Ghost, true, true, 15, 70, 100, "The user slashes with a sharp claw made from shadows. It has a high critical-hit ratio.");
            Play_Rough = new Move("Play Rough", Fairy, true, true, 10, 90, 90, "The user plays rough with the target and attacks it. This may also lower the target's Attack stat.");
            Shadow_Sneak = new Move("Shadow Sneak", Ghost, true, true, 30, 40, 100, "The user extends its shadow and attacks the target from behind. This move always goes first.");

        }

        #region Pokemon
        static Pokemon Abomasnow, Absol, Aegislash, Aerodactyl, Aggron, Alakazam, Ampharos, Arcanine;
        static Pokemon Banette, Barbaracle, Beedrill, Blaziken, Bronzong;
        static Pokemon Camerupt, Carracosta, Celesteela, Chandelure, Cloyster, Cofragrigus, Cresselia;
        static Pokemon Delphox, Dhelmise, Dialga, Dragalge, Drapion, Durant, Dusknoir;
        static Pokemon Electross, Empoleon, Escavalier, Espeon;
        static Pokemon Flareon, Froslass;
        static Pokemon Gallade, Garchomp, Gardevoir, Gengar, Glaceon, Glalie, Golisopod, Golurk, Gyarados;
        static Pokemon Haxorus, Heracross, Honchkrow, Hydreigon;
        static Pokemon Incineroar, Inteleon;
        static Pokemon Jirachi, Jolteon;
        static Pokemon Kingdra, Kommo_O, Krookodile, Kyurem;
        static Pokemon Leafeon, Lucario, Luxray, Lycanroc;
        static Pokemon Magearna, Magnezone, Marowak, Mawile, Metagross, Mimikyu, Mismagius, Mudsdale;
        static Pokemon Naganadel, Noivern;
        static Pokemon Oricorio;
        static Pokemon Palkia, Pangoro, Pheromosa, Pinsir;
        static Pokemon Quagsire;
        static Pokemon Rayquaza, Relicanth, Reshiram, Rhyperior;
        static Pokemon Salamence, Scizor, Scolipede, Scyther, Sharpedo, Stakataka, Steelix, Sylveon;
        static Pokemon Tapu_Fini, Tapu_Lele, Torkoal, Trevenant, Typhlosion;
        static Pokemon Umbreon, Uxie;
        static Pokemon Vaporeon, Vikavolt, Volcarona;
        static Pokemon Weavile;
        static Pokemon Xerneas, Xurkitree;
        static Pokemon Yanmega, Yveltal;
        static Pokemon Zebstrika, Zekrom, Zygarde;
        #endregion
        static void makePokemon()
        {
            MoveSet moves = new MoveSet(Stone_Edge, Swords_Dance, Focus_Blast, Fire_Punch);
            Blaziken = new Pokemon("Blaziken", 80, 120, 110, 70, 70, 80, moves, Fire, Fighting, "Speed Boost");
            moves = new MoveSet(Swords_Dance, Shadow_Claw, Play_Rough, Shadow_Sneak);
            Mimikyu = new Pokemon("Mimikyu", 55, 90, 50, 60, 105, 96, moves, Ghost, Fairy, "Disguise");


        }
    }
}
