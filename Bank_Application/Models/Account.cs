namespace Bank_Application.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? AcccountNumber { get; set; }
        public decimal Balance {  get; set; }
        public int UserId {  get; set; }
        public User? User { get; set; }
        public ICollection<Transactions>? Transactions { get; set; } 

    }
}
