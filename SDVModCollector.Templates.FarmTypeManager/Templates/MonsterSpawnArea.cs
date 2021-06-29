using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class MonsterSpawnArea : SpawnArea
  {
    public IEnumerable<MonsterType> MonsterTypes { get; set; }
    public IDictionary<string, object> Settings { get; set; }
  }
}