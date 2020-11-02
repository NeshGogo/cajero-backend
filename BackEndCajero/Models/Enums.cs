using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCajero.Models
{
    public enum TransactionTypeEnum
    {
        Withdraw,
        Deposit,
    }
    public enum TransactionDestinationEnum
    {
        Own,
        Other,
    }
}
