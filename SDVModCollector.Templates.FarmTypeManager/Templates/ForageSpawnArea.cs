using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class ForageSpawnArea : SpawnArea
  {
    public IEnumerable<object> SpringItemIndex { get; set; } 
    public IEnumerable<object> SummerItemIndex { get; set; }
    public IEnumerable<object> FallItemIndex { get; set; } 
    public IEnumerable<object> WinterItemIndex { get; set; } 
  }
}