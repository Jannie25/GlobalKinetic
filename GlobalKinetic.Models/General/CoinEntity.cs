using GlobalKinetic.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Models.General
{
    public class CoinEntity : ICoinEntity
    {
        public Decimal Amount { get; set; }
        public Decimal Volume { get; set; }
    }
}
