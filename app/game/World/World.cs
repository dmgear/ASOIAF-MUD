using System.Text.Json;

namespace TheLongNight.World;

public class WorldManager
{
    private readonly Dictionary<string, Location> _locations = new();

    public Location? StartingLocation { get; private set; }

    public void Load(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException(
                "World file could not be found.",
                filePath
            );
        }

        string json = File.ReadAllText(filePath);

        WorldData? worldData =
            JsonSerializer.Deserialize<WorldData>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

        if (worldData == null)
        {
            throw new InvalidOperationException(
                "World file could not be loaded."
            );
        }

        _locations.Clear();

        foreach (Location location in worldData.Locations)
        {
            RegisterLocation(location);
        }

        // Castle Black Gates is where the player begins.
        StartingLocation = GetLocation("castle_black_gates");
    }

    private void RegisterLocation(Location location)
    {
        _locations[location.Id] = location;

        foreach (Location child in location.Children)
        {
            RegisterLocation(child);
        }
    }

    public Location? GetLocation(string id)
    {
        _locations.TryGetValue(id, out Location? location);

        return location;
    }

    public Location? GetExit(Location currentLocation, string direction)
    {
        if (!currentLocation.Exits.TryGetValue(
                direction,
                out string? destinationId))
        {
            return null;
        }

        return GetLocation(destinationId);
    }

    private class WorldData
    {
        public List<Location> Locations { get; set; } = new();
    }
}