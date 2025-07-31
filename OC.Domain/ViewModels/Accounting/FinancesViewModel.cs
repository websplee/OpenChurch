using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Accounting
{
    public class FinancesViewModel
    {
        public double TotalTithes { get; set; }
        public double TotalOffering { get; set; }
        public double TotalDonations { get; set; }
        public double MonthlyBudget { get; set; }
        public double Expenses { get; set; }
        public double MonthlyGrowth { get; set; }
        public double YearlyGrowth { get; set; }
        public List<FinancialCategoryVIewModel> Categories { get; set; }
    }
}
