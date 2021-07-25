using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Models.Interfaces
{
    public interface ICoinEntity
    {
        public Decimal Amount { get; set; }
        public Decimal Volume { get; set; }
    }
}
