using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class OreSettings
  {
    public IEnumerable<OreSpawnArea> Areas { get; set; }
    public int PercentExtraSpawnsPerMiningLevel { get; set; }
    public IDictionary<string, int> MiningLevelRequired { get; set; }
    public IDictionary<string, int> StartingSpawnChance { get; set; }
    public IDictionary<string, int> LevelTenSpawnChance { get; set; }
    public IEnumerable<int> CustomTileIndex { get; set; }
  }
}