namespace CreatureCollector.Models
{
    public class Creature
    {
        // Basic identity
        public string Name { get; set; }
        public int Level { get; set; }

        // Combat stats
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Attack { get; set; }

        public Rarity Rarity { get; set; }

        // Apply damage to creature
        public void TakeDamage(int amount)
        {
            // TODO: Damage logic
        }

        // Restore its HP
        public void Heal(int amount)
        {
            // TODO: Healing logic
        }

        // Increase level and stats
        public void LevelUp()
        {
            // TODO: Level-up effects
        }
    }
}
