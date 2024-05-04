namespace BauCuaGame.Game
{
    public class Dice
    {
        private readonly Random _random;

        public Dice(Random random)
        {
            _random = random;
        }

        public FaceDice RollDice()
        {
            int FaceIndex = _random.Next(0, FaceDice.Faces.Length);
            return FaceDice.Faces[FaceIndex];
        }
    }
}