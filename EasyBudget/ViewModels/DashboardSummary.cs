namespace EasyBudget.ViewModels
{
    public class DashboardSummary
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal Balance => TotalIncome - TotalExpenses;
    }
}
