namespace Bank_Application.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date {  get; set; }
        public string? Type {  get; set; }
        public int AccountID { get; set; }
        public Account? Account { get; set; }

    }
}
