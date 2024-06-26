﻿namespace BauCuaGame.Game
{
    public class FaceDice
    {
        public static readonly FaceDice[] Faces = new FaceDice[]
        {
            new FaceDice { id = "Bau", Name="Bầu", ConsoleImage = "░░░░░░░░░░░░░░░░░░░░\n░░░░░░░░░▒▓░░░░░░░░░\n░░░░░░░░░▓█▓░░░░░░░░\n░░░░░░▒░▓███▓░░░░░░░\n░░░░▒▓███▓██████▒░░░\n░░░▒███▓▓▓▓▓▓█▓▓▓░░░\n░░░░▒█▓▓███████▓░░░░\n░░░░░▓▓▓██████▓░░░░░\n░░░░░░░▒▒▓▓▓▒▒░░░░░░\n" },
            new FaceDice { id = "Cua", Name = "Cua", ConsoleImage = "░░░░░░░░░░░░░░░░░░░░\n░░░░░░░░░░░░▒▒░░░░░░\n░░░░░░░░░░░░░▓▓░░░░░\n░░░▓▒░░░░░░░░▓▓░░░░░\n░░░▓▓░░▒▒▒▓▓▒▓▓▒▒░░░\n░░░░▓▓▒▓▓▓▓▓▓▓▓▒▒░░░\n░░▒▒░▒▓▓▓▓▓▓▓▓▒░░▒░░\n░░░░▒▒░▒▒▒▒░░░░▒░░░░\n░░░░░░░▒░░░░░░░░░░░░\n" },
            new FaceDice { id = "Ca", Name = "Cá", ConsoleImage = "░░░░░░░░░░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░\n▒▓▓▓▓▓▒░░░░░░░░░░░░░\n░▒▒▒▒▓▓▓▓▓▒░░░░░░░░░\n░░░▒▒▒▒▓▓▓▓▒▒░░░░░░░\n░░░░░▒▒▒▒▒▓▓▓▒▒▒░░░░\n░░░░░░░░░░▒▒▒▓▓▒▒▒░░\n░░░░░░░░░░░░▒░▒▒▒▒▒░\n░░░░░░░░░░░░░░░░░░░░\n" },
            new FaceDice { id = "Ga", Name = "Gà", ConsoleImage = "░░░░░░░░░░░░░░▒░░░░░\n░░░░░░░░░░░░░▓▓█▒░░░\n░░░░░░░░░░░░▓██▓░░░░\n░░░▒░░░░░░░▒▓▓▒▒░░░░\n░░░░░▒░░░░▒▒▒▒▒▒░░░░\n░░░░▒▒▒▒▒▓▒▓▓▒▒▒░░░░\n░░░░░▒▒▓▓█▓▓▓▓▒░░░░░\n░░░░░░░░░░▓▓░░░░░░░░\n░░░░░░░░░░░▒░░░░░░░░\n" },
            new FaceDice { id = "Nai", Name = "Nai", ConsoleImage = "░░░░░░░░░░░▒▒░░░░░░░\n░░░░░░░░░░░▒▓▒▒░░░░░\n░░░░░░▒▒░░░░▒▒▒▒░░░░\n░░░░░░▓▓▓▓▓▒▓▒▒░░░░░\n░░░░░░▓▒▓▓▓▓▓▓▒░░░░░\n░░░░░░▒▒▒▒░▒▓▒▒▒░░░░\n░░░░░▒▓▒▒░░░▒▒░▒▒░░░\n░░░░▒▒▒░░░░░░▒░▒░░░░\n░░░░▒▒▒░░░░░░▒▒░░░░░\n" },
            new FaceDice { id = "Tom", Name = "Tôm",ConsoleImage = "░░░░░░░░░░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░▒░░\n░░░░░░░░░░░░░▒▓▒░░░░\n░░░░░▒▒▒▓▓▓█▓▒░░░░░░\n░░▒▓▓▓▓▓▓▓▓█▓▒░░░░░░\n░▓▓▓██▓▓▒▒▓▓▒░░░░░░░\n░▓█▓▓▒▒░░░░░░░░░░░░░\n░▒▓▓▒▒░░░░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░\n" }
        };
        public required string id { get; init; }
        public required string Name { get; init; }
        public required string ConsoleImage { get; init; }
    }
}