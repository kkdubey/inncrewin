using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingSystem.Core.Payment.Models
{
    public class PaymentDetails
    {
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public double TransactionAmount { get; set; }
    }

    public enum TransactionType
    {
        CREDIT = 1,
        DEBIT = 2
    }
}
