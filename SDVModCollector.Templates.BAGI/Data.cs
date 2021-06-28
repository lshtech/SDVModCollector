using System.Collections.Generic;

namespace SDVModCollector.Templates.BAGI
{
  public class Data : ITemplate
  {
    public string Name { get; set; } = "BAGI";

    public IEnumerable<string> Fruits { get; set; }
    public IEnumerable<string> Vegetables { get; set; }
    public IEnumerable<string> Flowers { get; set; }
    public string Honey { get; set; }
    public string Jelly { get; set; }
    public string Juice { get; set; }
    public string Pickles { get; set; }
    public string Wine { get; set; }
  }
}
