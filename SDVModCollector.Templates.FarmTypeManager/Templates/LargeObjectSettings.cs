using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class LargeObjectSettings
  {
    public IEnumerable<LargeObjectSpawnArea> Areas { get; set; }
    public IEnumerable<int> CustomTileIndex { get; set; }
  }
}