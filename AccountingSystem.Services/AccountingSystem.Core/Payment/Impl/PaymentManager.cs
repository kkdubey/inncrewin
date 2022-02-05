using AccountingSystem.Core.Payment.Models;
using AccountingSystem.Core.Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingSystem.Core.Payment.Impl
{
    public class PaymentManager : IPaymentManager
    {
        private readonly IProjectManager _projectManager;
        public PaymentManager(IProjectManager projectManager)
        {
            _projectManager = projectManager;
        }
        public bool GetPaymentStatus(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePayment(List<PaymentDetails> paymentDetails)
        {
            
            return true;
        }
    }
}
