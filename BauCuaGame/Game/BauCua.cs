namespace BauCuaGame.Game
{
    public class BauCua
    {
        private const int diceQuantity = 3;
        private readonly Random _random = new Random();
        public void Play()
        {
            bool isGameStart = false;
            bool isLose = false;
            BauCuaUI.RenderMenu();
            while (true) {
                if(!isGameStart || isLose)
                {
                    isGameStart = BauCuaUI.RenderStartGame(Player.Money);
                    isLose = false;
                }
                BauCuaUI.RenderMoney(Player.Money);
                BauCuaUI.RenderRolDice();
                var rollList = DoRollDice(_random, diceQuantity);
                Console.WriteLine("ĐÃ LẮC XONG, BẠN HÃY CƯỢC\nCách cược như sau: Con vật-Số tiền, ví dụ: Ga-20 Tom-50 Bau-10");
                var betResults = DoBet(rollList);
                BauCuaUI.RederDiceFace(rollList);
                BauCuaUI.RederResult(betResults, Player.Money);
                if (Player.Money <= 0)
                {
                    isLose = true;
                    Player.AddMoney(100);
                }
                Thread.Sleep(200);
            }
        }
        public int DoBet(List<FaceDice> rollList)
        {
            string betInput;
            List<BetFace> BetList;
            int betResults = 0;
            do
            {
                betInput = Console.ReadLine();
            }
            while (!ValidBet.Test(betInput, out BetList));
            BauCuaUI.RederBetList(BetList);

            foreach (BetFace bet in BetList)
            {
                bool existFace = false;
                foreach (FaceDice roll in rollList)
                {
                    if(bet.Face.id == roll.id)
                    {
                        betResults += bet.Money;
                        existFace = true;
                    }
                }
                if (!existFace)
                {
                    betResults -= bet.Money;
                }
            }
            Player.AddMoney(betResults);
            return betResults;
        }

        public List<FaceDice> DoRollDice(Random _random, int diceQuantity)
        {
            List<FaceDice> listRollDice = new List<FaceDice>();
            for(int i = 0; i < diceQuantity; i++)
            {
                listRollDice.Add(new Dice(_random).RollDice());
            }
            return listRollDice;
        }
    }
}