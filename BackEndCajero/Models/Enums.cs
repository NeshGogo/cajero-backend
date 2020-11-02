using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCajero.Models
{
    public enum TransactionTypeEnum
    {
        Withdraw = 1,
        Deposit = 2,
    }
    public enum TransactionDestinationEnum
    {
        Own = 1,
        Other = 2,
    }
}
