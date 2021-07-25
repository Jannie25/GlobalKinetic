using GlobalKinetic.DataHelper.Interfaces;
using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Requests;
using GlobalKinetic.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GlobalKinetic.Repository.Classes
{
    public class CoinJarRepository : ICoinJarRepository
    {
        private IDapperService _dapperService;

        public CoinJarRepository(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }

        public int AddCoin(CoinEntity coinEntity)
        {
            var p = new
            {
                coinEntity.Amount,
                coinEntity.Volume
            };
            return _dapperService.Execute("usp_InsertCoin", p);
        }

        public decimal GetTotalAmount()
        {
            //return _dapperService.QuerySingle<decimal>("usp_GetTotalAmount", null);
            var coins = GetCoins();

            return coins.Sum<CoinEntity>(x => x.Amount);
        }

        public decimal GetTotalVolume()
        {
            //return _dapperService.QuerySingle<decimal>("usp_GetTotalAmount", null);
            var coins = GetCoins();

            return coins.Sum<CoinEntity>(x => x.Volume);
        }

        private IList<CoinEntity> GetCoins()
        {
            return _dapperService.Query<CoinEntity>("usp_GetCoins", null);
        }

        public int Reset()
        {
            return _dapperService.Execute("usp_ResetCoins", null);
        }
    }
}
