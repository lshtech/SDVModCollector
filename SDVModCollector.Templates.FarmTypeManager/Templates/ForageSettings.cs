using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class ForageSettings
  {
    public IEnumerable<ForageSpawnArea> Areas { get; set; }
    public int PercentExtraSpawnsPerForagingLevel { get; set; }
    public IEnumerable<object> SpringItemIndex { get; set; } 
    public IEnumerable<object> SummerItemIndex { get; set; } 
    public IEnumerable<object> FallItemIndex { get; set; } 
    public IEnumerable<object> WinterItemIndex { get; set; }
    public IEnumerable<int> CustomTileIndex { get; set; }
  }
}