using CreatureCollector.Models;

namespace CreatureCollector.Game
{
    public class World
    {
        // All available locations
        public List<WorldLocation> Locations { get; set; } = new List<WorldLocation>();

        // Current player location
        public LocationType CurrentLocation { get; set; }

        public World()
        {
            // TODO: Initialize world locations
        }

        // Switch to a new location
        public void ChangeLocation(LocationType newLocation)
        {
            // TODO: Logic for changing area
        }
    }
}
