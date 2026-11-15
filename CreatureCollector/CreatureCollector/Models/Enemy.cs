namespace CreatureCollector.Models
{
    public class Enemy
    {
        // Enemy identity
        public string Name { get; set; }

        // Combat stats
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }

        // Enemy takes damage
        public void TakeDamage(int amount)
        {
            // TODO: Handle damage
        }
    }
}
