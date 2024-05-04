namespace BauCuaGame.Game
{
    public static class ValidBet
    {
        public static bool Test(string text, out List<BetFace> validBetList)
        {
            validBetList = new List<BetFace>();
            int totalBetMoney = 0;
            var splitSpace = text.Trim().Split(' ');
            foreach(var word in splitSpace)
            {
                var betStringArr = word.Split('-');
                if (betStringArr.Length < 2)
                {
                    Console.WriteLine("Vui lòng nhập đúng cú pháp");
                    return false;
                }

                string betName = betStringArr[0].Trim();
                string betMoney = betStringArr[1].Trim();
                if (!CheckName(betName, out FaceDice validFace) || !CheckMoney(betMoney))
                {
                    return false;
                }

                totalBetMoney = totalBetMoney + int.Parse(betMoney);
                if(totalBetMoney > Player.Money)
                {
                    Console.WriteLine("Bạn không đủ tiền để cược");
                    return false;
                }

                int duplicateIndex = validBetList.FindIndex(item => item.Face.id == validFace.id);
                if (duplicateIndex < 0)
                {
                    validBetList.Add(new BetFace { Face = validFace, Money = int.Parse(betMoney) });
                }
                else
                {
                    BetFace duplicateBetItem = validBetList[duplicateIndex];
                    duplicateBetItem.Money = duplicateBetItem.Money + int.Parse(betMoney);
                }
            }
            return true;
        }

        private static bool CheckName(string name, out FaceDice validFace)
        {
            FaceDice faceFound= Array.Find(FaceDice.Faces, face => face.id.Equals(name, StringComparison.OrdinalIgnoreCase));
            validFace = faceFound;
            if (faceFound == null)
            {
                Console.WriteLine("Vui Lòng đặt đúng tên con vật cần cược\n" +
                                string.Join(", ", FaceDice.Faces.Select(face => face.id)));
                return false;
            }
            return true;
        }
        private static bool CheckMoney(string money)
        {
            bool isValid =  int.TryParse(money, out int outMoney);
            if(isValid)
            {
                if(outMoney <= 0)
                {
                    Console.WriteLine("Vui Lòng cược số tiền lớn hơn 0$");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Số tiền bạn nhập có cú pháp sai");
            }
            return isValid;
        }
    }
}