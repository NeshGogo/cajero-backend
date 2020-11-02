using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCajero.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string AccountOrigen { get; set; }
        public string AccountDestination { get; set; }
        public double Amount { get; set; }
        public TransactionTypeEnum TransactionType { get; set; }
        public TransactionDestinationEnum TransactionDestination { get; set; }
        public double CurrentBalance { get; set; }
    }
}
