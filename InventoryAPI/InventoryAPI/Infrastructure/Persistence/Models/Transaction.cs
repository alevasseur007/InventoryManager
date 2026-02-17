namespace InventoryAPI.Infrastructure.Persistence.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public TransactionLine[] TransactionLines { get; set; } = [];
    }
}
