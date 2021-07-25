using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Interfaces;
using GlobalKinetic.Models.Requests;
using GlobalKinetic.Repository.Interfaces;
using GlobalKinetic.Services.Interfaces;
using System.Collections.Generic;

namespace GlobalKinetic.Services.Classes
{
    public class CoinJarService : ICoinJarService
    {
        private ICoinJarRepository _coinJarRepository;

        public CoinJarService(ICoinJarRepository coinJarRepository)
        {
            _coinJarRepository = coinJarRepository;
        }

        public int AddCoin(ICoin coin)
        {
            if (!(coin is USACoin))
            {
                throw new System.Exception("Coin jar only accepts USA Coins");
            }

            decimal totalVolume = _coinJarRepository.GetTotalVolume();

            if ((totalVolume + coin.Volume) > 42)
            {
                throw new System.Exception("Coin jar will exceed its volume of 42 fluid ounces.");
            }

            return _coinJarRepository.AddCoin(new CoinEntity() { Amount = coin.Amount, Volume = coin.Volume });
        }

        public decimal GetTotalAmount()
        {
            return _coinJarRepository.GetTotalAmount();
        }

        public int Reset()
        {
            return _coinJarRepository.Reset();
        }
    }
}