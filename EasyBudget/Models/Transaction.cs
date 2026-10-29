using System.ComponentModel.DataAnnotations;

namespace EasyBudget.Models
{
    public enum TransactionType
    {
        Income,
        Expense
    }

    public class Transaction
    {
        public int Id { get; set; }

        [Range(typeof(decimal), "0,01", "999999999", ErrorMessage = "Amount must be grater than zero")]
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters.")]
        public string Category { get; set; } = string.Empty;
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [StringLength(200, ErrorMessage = "Category cannot exceed 50 characters.")]
        public string? Description { get; set; }
    }
}
