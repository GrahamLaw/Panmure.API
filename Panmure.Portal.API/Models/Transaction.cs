using System;

namespace Panmure.Portal.API.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Deposit { get; set; }
        public decimal Withdrawl { get; set; }
        public decimal Balance { get; set; }
    }
}
