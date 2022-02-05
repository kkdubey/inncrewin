using AccountingSystem.Core.Payment.Models;
using AccountingSystem.Core.Project;
using AccountingSystem.Core.Project.Models;
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

        public bool UpdatePayment(List<PaymentDetails> paymentDetails, int customerId)
        {
            DateTime date = paymentDetails[0].TransactionDate;
            List<ProjectDetails> projectDetails = this._projectManager.GetProjectDeatilsByCustomer(customerId, date);
            //write logic- if payment details is single transaction(add amount of allproject details)
            return true;
        }
    }
}
