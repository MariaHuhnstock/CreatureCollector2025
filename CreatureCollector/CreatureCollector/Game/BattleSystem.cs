using CreatureCollector.Models;

namespace CreatureCollector.Game
{
    public class BattleSystem
    {
        private Player _player;
        private object _enemy; // Could be Creature or Enemy

        public BattleSystem(Player player, object enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        // Start the battle loop
        public void StartBattle()
        {
            // TODO: Fight logic loop
        }

        // Player takes a turn
        private void PlayerTurn()
        {
            // TODO: Player actions
        }

        // Enemy takes a turn
        private void EnemyTurn()
        {
            // TODO: Enemy actions
        }
    }
}
