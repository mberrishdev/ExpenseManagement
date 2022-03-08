namespace ExpenseManagement.API.Models.Responses
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
    }
}
