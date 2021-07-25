using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Models.Interfaces
{
    public interface ICoin
    {
        public Decimal Amount { get; set; }
        public Decimal Volume { get; set; }

    }
}
