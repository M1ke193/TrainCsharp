namespace BauCuaGame.Game
{
    public class Player
    {
        public static int Money { get; private set; } = 100;
        public static void AddMoney(int money)
        {
            Money = Money + money;
        }
        public static void SubMoney(int money)
        {
            Money = Money - money;
        }
    }
}