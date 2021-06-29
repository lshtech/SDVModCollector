// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace SDVModCollector.Templates.FarmTypeManager.Templates
{
  public class Content : ITemplate
  {
    public string Name { get; set; } = "FTM";
    public bool ForageSpawnEnabled { get; set; }
    public bool LargeObjectSpawnEnabled { get; set; }
    public bool OreSpawnEnabled { get; set; }
    public bool MonsterSpawnEnabled { get; set; }
    public ForageSettings Forage_Spawn_Settings { get; set; }
    public LargeObjectSettings Large_Object_Spawn_Settings { get; set; }
    public OreSettings Ore_Spawn_Settings { get; set; }
    public MonsterSettings Monster_Spawn_Settings { get; set; }
    public IEnumerable<int> QuarryTileIndex { get; set; }
    public FileConditions File_Conditions { get; set; }
  }
}
