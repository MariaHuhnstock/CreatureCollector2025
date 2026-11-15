namespace CreatureCollector.Models.Items
{
    public class AttackBuff : Item
    {
        public int BonusAttack { get; set; }
        public int DurationTurns { get; set; }

        public override void Use(Player player)
        {
            // TODO: Apply temporary attack buff
        }
    }
}
