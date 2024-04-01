namespace Domain.Models;

public class Management
{
    public int Id { get; set; }
    public int AccountNumber { get; set; }
    public AccountType Type { get; set; }
    public decimal Balance { get; set; }
    public int CustomerId { get; set; }
}