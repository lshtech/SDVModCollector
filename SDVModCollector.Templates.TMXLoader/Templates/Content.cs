using System.Collections.Generic;
// ReSharper disable InconsistentNaming

namespace SDVModCollector.Templates.TMXLoader.Templates
{
  public class Content : ITemplate
  {
    public string Name { get; set; } = "TMX";
    public IEnumerable<string> hasMods { get; set; } 

    public IEnumerable<string> hasNotMods { get; set; } 
    public IEnumerable<string> alsoLoad { get; set; } 
    public IEnumerable<MapEdit> addMaps { get; set; }
    public IEnumerable<MapEdit> replaceMaps { get; set; }
    public IEnumerable<MapEdit> mergeMaps { get; set; }

    public IEnumerable<BuildableEdit> buildables { get; set; } 
    public IEnumerable<MapEdit> onlyWarps { get; set; } 
    public IEnumerable<TileShop> shops { get; set; } 
    public IEnumerable<SpouseRoom> spouseRooms { get; set; }
    public IEnumerable<NPCPlacement> festivalSpots { get; set; } 
    public IEnumerable<NPCPlacement> placeNPCs { get; set; } 
    public IEnumerable<string> scripts { get; set; }
    public bool loadLate { get; set; }
  }
}
