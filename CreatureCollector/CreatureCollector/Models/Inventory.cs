using CreatureCollector.Models.Items;

namespace CreatureCollector.Models
{
    public class Inventory
    {
        // List of all items the player owns
        public List<Item> Items { get; set; } = new List<Item>();

        // Add item to inventory
        public void Add(Item item)
        {
            // TODO: Add logic
        }

        // Remove item from inventory
        public void Remove(Item item)
        {
            // TODO: Remove logic
        }

        // Use item by name
        public void UseItem(string itemName, Player player)
        {
            // TODO: Use an item
        }
    }
}
