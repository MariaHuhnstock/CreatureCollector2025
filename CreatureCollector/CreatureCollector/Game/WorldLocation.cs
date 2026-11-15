using CreatureCollector.Models;

namespace CreatureCollector.Game
{
    public class WorldLocation
    {
        // Name of the location
        public string Name { get; set; }

        // Type (Forest, Cave, Volcano)
        public LocationType Type { get; set; }

        // Constructor
        public WorldLocation(string name, LocationType type)
        {
            Name = name;
            Type = type;
        }
    }
}
