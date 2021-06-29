using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class MonsterSettings
  {
    public IEnumerable<MonsterSpawnArea> Areas { get; set; }
    public IEnumerable<int> CustomTileIndex { get; set; }
  }
}