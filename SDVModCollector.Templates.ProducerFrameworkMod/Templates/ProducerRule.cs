using System.Collections.Generic;

namespace SDVModCollector.Templates.ProducerFrameworkMod.Templates
{
  public class ProducerRule
  {
    public string ProducerName { get; set; }
    public string InputIdentifier { get; set; }
    public int InputStack { get; set; }
    public int MinutesUntilReady { get; set; }
    public IEnumerable<string> Sounds { get; set; }
    public string OutputIdentifier { get; set; }
    public string PlacingAnimation { get; set; }
    public string PlacingAnimationColorName { get; set; }
    public bool KeepInputQuality { get; set; }
    public double OutputPriceMultiplier { get; set; }
    public int OutputPriceIncrement { get; set; }
    public string FuelIdentifier { get; set; }
    public int FuelStack { get; set; }
    public string PreserveType { get; set; }
    public bool KeepInputParentIndex { get; set; }
    public bool InputPriceBased { get; set; }
    public IDictionary<string, string> OutputColorConfig { get; set; }
    public IEnumerable<string> OverrideMod { get; set; }
    public IDictionary<string, int> AdditionalFuel { get; set; }
  }
}