using AccountingSystem.Core.Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingSystem.Core.Project
{
    public interface IProjectManager
    {
        List<ProjectDetails> GetProjectDeatilsByCustomer(int customerId, DateTime date);
    }
}
