using InventoryAPI.Infrastructure.Persistence.Models.Items;

namespace InventoryAPI.Infrastructure.Persistence.Models
{
    public class TransactionLine
    {
        public int Id { get; set; }

        public Item Item { get; set; } = new Item();
    }
}
