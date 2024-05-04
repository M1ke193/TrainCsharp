using System;

namespace BauCuaGame.Game
{
    public class BauCuaUI
    {
        public static void RenderMenu()
        {
            Console.WriteLine(" ____             _    _    _____  _    _            \r\n|  _ \\     /\\    | |  | |  / ____|| |  | |    /\\     \r\n| |_) |   /  \\   | |  | | | |     | |  | |   /  \\    \r\n|  _ <   / /\\ \\  | |  | | | |     | |  | |  / /\\ \\   \r\n| |_) | / ____ \\ | |__| | | |____ | |__| | / ____ \\  \r\n|____/ /_/    \\_\\ \\____/   \\_____| \\____/ /_/    \\_\\ \r\n                                                     \r\n                                                     \r\n");
            Console.Write("Nhấn P để chơi game ");
            ConsoleHandle.loopInputKey(ConsoleKey.P);
            Console.Clear();
        }
        public static bool RenderStartGame(int startMoney)
        {
            Console.WriteLine("      ::::::::   :::::::::::           :::        :::::::::   ::::::::::: \r\n    :+:    :+:      :+:             :+: :+:      :+:    :+:      :+:      \r\n   +:+             +:+            +:+   +:+     +:+    +:+      +:+       \r\n  +#++:++#++      +#+           +#++:++#++:    +#++:++#:       +#+        \r\n        +#+      +#+           +#+     +#+    +#+    +#+      +#+         \r\n#+#    #+#      #+#           #+#     #+#    #+#    #+#      #+#          \r\n########       ###           ###     ###    ###    ###      ###           \r\n");
            ConsoleHandle.WriteAndClearAll($"\n Bạn sẽ có {startMoney}$ để bắt đầu", 1000);
            return true;
        }

        public static void RenderMoney(int money)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.CursorLeft = 0;
            Console.WriteLine("Money: " + money + "$\n");
        }

        public static void RenderRolDice()
        {
            const string fistRollText = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒\r\n▓▓▓▓▓▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓▓▓▓▓▓\r\n▓▓▓▓▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓▓▓▓▓\r\n▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓▓▓▓\r\n▓▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓█\r\n▒░░▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░▒\r\n▒░░░░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░▓\r\n▓▓▓▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▓██\r\n▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██████\r\n▓▓▓▓█████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓\r\n▓▓████████████████████████████████████▓▓\r\n";
            const string secondRollText = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓\r\n▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▓▓▓▓\r\n▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▓▓▓▓▓\r\n▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓▓▓\r\n▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓\r\n▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒\r\n▓▒░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒\r\n▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓\r\n▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓█\r\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓██\r\n";
            ConsoleHandle.WriteAndClear(fistRollText, 300);
            ConsoleHandle.WriteAndClear(secondRollText, 300);
            Console.WriteLine(fistRollText);
        }

        public static void RederDiceFace(List<FaceDice> rollFaceDices)
        {
            if(rollFaceDices.Count <= 0) { return; }
            Console.Write("\n");
            var currentCusor = Console.CursorTop;
            var widthText = 0;
            for (int i = 0; i< rollFaceDices.Count; i++)
            {
                var lineCursor = currentCusor;
                var rowString = rollFaceDices[i].ConsoleImage.Split("\n");
                Thread.Sleep(700);
                foreach (var row in rowString)
                {
                    Console.SetCursorPosition(widthText, lineCursor);
                    Console.Write(row);
                    lineCursor++;
                }
                Console.CursorTop = lineCursor;
                RederNameBet(rollFaceDices[i].Name);
                widthText += rowString[0].Length+1;
            }
        }
        public static void RederBetList(List<BetFace> BetList)
        {
            ConsoleHandle.ClearChoosenLine(2, Console.CursorTop);
            Console.WriteLine("BẠN ĐÃ CƯỢC");
            foreach (var betFace in BetList)
            {
                Console.WriteLine($"{betFace.Face.Name}: {betFace.Money}$");
            }
        }
        public static void RederResult(int betResult, int playerMoney)
        {
            Thread.Sleep(500);
            Console.WriteLine("\n");
            var currentCursor = Console.CursorTop + 1;
            if (betResult > 0)
            {
                Console.WriteLine($"Chúc Mừng Bạn Đã Thắng {betResult}$");
            }
            else if(betResult < 0)
            {
                Console.WriteLine($"Bạn đã mất {Math.Abs(betResult)}$");
            }
            else {
                Console.WriteLine($"Không ăn mà cũng không mất :D");
            }
            RenderMoney(playerMoney);
            Console.CursorTop = currentCursor;
            Console.Write("\n");

            if(playerMoney > 0)
            {
                Console.WriteLine("Nhấn P để chơi tiếp");
            }
            else
            {
                Console.WriteLine("Bạn đã thua, Nhấn P để chơi lại");
            }
            ConsoleHandle.loopInputKey(ConsoleKey.P);
            Console.Clear();
        }

        private static void RederNameBet(string name)
        {
            Console.Write($"        {name.ToUpper()}");
        }
    }
}