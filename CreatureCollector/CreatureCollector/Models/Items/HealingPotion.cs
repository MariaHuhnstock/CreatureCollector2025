namespace CreatureCollector.Models.Items
{
    public class HealingPotion : Item
    {
        public int HealAmount { get; set; }

        public override void Use(Player player)
        {
            // TODO: Restore HP to player or selected creature
        }
    }
}
