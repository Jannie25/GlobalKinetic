using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Interfaces;
using GlobalKinetic.Models.Requests;
using System.Collections.Generic;

namespace GlobalKinetic.Services.Interfaces
{
    public interface ICoinJarService
    {
        int AddCoin(ICoin coin);
        decimal GetTotalAmount();
        int Reset();
    }
}
