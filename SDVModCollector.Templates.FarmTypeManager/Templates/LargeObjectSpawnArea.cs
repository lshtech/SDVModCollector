using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class LargeObjectSpawnArea : SpawnArea
  {

    public IEnumerable<string> ObjectTypes { get; set; }
    public bool FindExistingObjectLocations { get; set; }
    public int PercentExtraSpawnsPerSkillLevel { get; set; } 
    public string RelatedSkill { get; set; } 
  }
}