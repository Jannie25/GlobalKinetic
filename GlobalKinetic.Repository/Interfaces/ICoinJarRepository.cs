using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Requests;
using System.Collections.Generic;

namespace GlobalKinetic.Repository.Interfaces
{
    public interface ICoinJarRepository
    {
        int AddCoin(CoinEntity coinEntity);
        decimal GetTotalAmount();
        decimal GetTotalVolume();
        int Reset();
    }
}
