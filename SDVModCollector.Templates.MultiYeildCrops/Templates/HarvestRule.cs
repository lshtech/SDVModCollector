using System.Collections.Generic;

namespace SDVModCollector.Templates.MultiYieldCrops.Templates
{
  public class HarvestRule
  {
    public string ExtraYieldItemType { get; set; }
    public string ItemName { get; set; }
    public int minHarvest { get; set; }
    public int maxHarvest { get; set; }
    public float maxHarvestIncreasePerFarmingLevel { get; set; }
    public IEnumerable<string> disableWithMods { get; set; }
  }
}