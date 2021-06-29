
using System.Collections.Generic;

namespace SDVModCollector.Templates.CCM.Templates
{
  public class CaskData : ITemplate
  {
    public CaskData(IDictionary<string, double> data)
    {
      Data = data;
    }

    public string Name { get; set; } = "CustomCaskMod";
    public IDictionary<string, double> Data { get; set; }
  }
}
