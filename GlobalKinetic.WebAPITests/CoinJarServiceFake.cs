using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Interfaces;
using GlobalKinetic.Services.Interfaces;

namespace GlobalKinetic.WebAPITests
{
    public class CoinJarServiceFake : ICoinJarService
    {

        public int AddCoin(ICoin coin)
        {
            if (!(coin is USACoin))
            {
                throw new System.Exception("Coin jar only accepts USA Coins");
            }

            decimal totalVolume = this.GetTotalVolume();

            if ((totalVolume + coin.Volume) > 42)
            {
                throw new System.Exception("Coin jar will exceed its volume of 42 fluid ounces.");
            }

            return 1;
        }

        public decimal GetTotalAmount()
        {
            return 100;
        }

        public decimal GetTotalVolume()
        {
            return 10;
        }

        public int Reset()
        {
            return 1;
        }
    }
}