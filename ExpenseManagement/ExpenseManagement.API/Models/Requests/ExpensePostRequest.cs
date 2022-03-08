namespace ExpenseManagement.API.Models.Requests
{
    public class ExpensePostRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
    }
}
