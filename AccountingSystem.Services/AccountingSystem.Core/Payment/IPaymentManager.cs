using AccountingSystem.Core.Payment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingSystem.Core.Payment
{
    public interface IPaymentManager
    {
        /// <summary>
        /// update payment from status by payment details
        /// </summary>
        /// <param name="paymentDetails"></param>
        /// <returns>return ture if valid amount</returns>
        bool UpdatePayment(List<PaymentDetails> paymentDetails, int customerId);

        /// <summary>
        /// Get payment status by date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>return ture is payment is made for the month</returns>
        bool GetPaymentStatus(DateTime date);
    }
}
