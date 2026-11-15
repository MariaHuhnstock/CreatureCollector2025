namespace CreatureCollector.Models.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Every item must implement its own effect
        public abstract void Use(Player player);
    }
}
