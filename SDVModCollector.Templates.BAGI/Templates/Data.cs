using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace SDVModCollector.Templates.BAGI.Templates
{
  public class Data : ITemplate
  {
    [JsonIgnore]
    public string Name { get; set; } = "BetterArtisanGoodIcons";

    [DefaultValue(null)]
    public IEnumerable<string> Fruits { get; set; }
    [DefaultValue(null)]
    public IEnumerable<string> Vegetables { get; set; }
    [DefaultValue(null)]
    public IEnumerable<string> Flowers { get; set; }
    [DefaultValue(null)]
    public string Honey { get; set; }
    [DefaultValue(null)]
    public string Jelly { get; set; }
    [DefaultValue(null)]
    public string Juice { get; set; }
    [DefaultValue(null)]
    public string Pickles { get; set; }
    [DefaultValue(null)]
    public string Wine { get; set; }
  }
}
