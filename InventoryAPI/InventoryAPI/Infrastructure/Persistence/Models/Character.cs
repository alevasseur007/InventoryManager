using InventoryAPI.Infrastructure.Persistence.Models.Items;

namespace InventoryAPI.Infrastructure.Persistence.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Campaign[] Campaigns { get; set; } = [];
        public Item[] Items { get; set; } = [];
    }
}
