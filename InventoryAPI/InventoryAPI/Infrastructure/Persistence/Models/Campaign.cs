namespace InventoryAPI.Infrastructure.Persistence.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Character[] Characters { get; set; } = [];
        public Transaction[] Transactions { get; set; } = [];
    }
}
