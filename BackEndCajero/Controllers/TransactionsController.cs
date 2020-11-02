using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndCajero.Data;
using BackEndCajero.Models;

namespace BackEndCajero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly BackEndCajeroContext _context;

        public TransactionsController(BackEndCajeroContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransaction()
        {
            return await _context.Transaction.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Transaction>> GetTransaction(int id)
        {
            var transaction = await _context.Transaction.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return transaction;
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> PostTransaction(Transaction transaction)
        {
            var _accountOrigen = await _context.Account.FindAsync(transaction.AccountOrigen);
            var _accountDestination = transaction.TransactionDestination == TransactionDestinationEnum.Other ?
                await _context.Account.FindAsync(transaction.AccountDestination)
                : null ;
            switch (transaction.TransactionType)
            {
                case TransactionTypeEnum.Withdraw:
                    _accountOrigen.Balance -= transaction.Amount;
                    transaction.CurrentBalance = _accountOrigen.Balance;
                    _context.Account.Update(_accountOrigen);
                    if (transaction.TransactionDestination == TransactionDestinationEnum.Other)
                    {
                        _accountDestination.Balance += transaction.Amount;
                        _context.Account.Update(_accountDestination);
                    }
                    break;
                case TransactionTypeEnum.Deposit:
                    _accountOrigen.Balance +=  transaction.Amount;
                    transaction.CurrentBalance = _accountOrigen.Balance;
                    _context.Account.Update(_accountOrigen);
                    break;
            }
            _context.Transaction.Add(transaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransaction", new { id = transaction.Id }, transaction);
        }

        private bool TransactionExists(int id)
        {
            return _context.Transaction.Any(e => e.Id == id);
        }
    }
}
