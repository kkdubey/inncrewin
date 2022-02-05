using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingSystem.Core.Project.Models
{
    public class ProjectDetails
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int CustomerId { get; set; }
        public ProjectBillingType BillingType { get; set; }
        public double ProjectBillingAmount { get; set; }
        public double ProjectBillingHourlyRate { get; set; }
    }

    public enum ProjectBillingType
    {
        TimeAndMaterial = 1,
        MilestoneBased = 2
    }
}
