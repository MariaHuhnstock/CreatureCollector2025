using CreatureCollector.Models.Items;

namespace CreatureCollector.Models
{
    public class Player
    {
        // Player identity
        public string Name { get; set; }

        // Basic stats
        public int Level { get; set; }
        public int Experience { get; set; }

        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }

        // Player-owned creatures
        public List<Creature> Creatures { get; set; }

        // Player inventory
        public Inventory Inventory { get; set; }

        public Player()
        {
            Creatures = new List<Creature>();
            Inventory = new Inventory();
        }

        // Increase experience and check for level up
        public void GainExperience(int amount)
        {
            // TODO: Add XP logic
        }

        // Increase player level and stats
        public void LevelUp()
        {
            // TODO: Implement level-up effects
        }

        // Restore player's HP
        public void Heal(int amount)
        {
            // TODO: Implement healing logic
        }
    }
}
