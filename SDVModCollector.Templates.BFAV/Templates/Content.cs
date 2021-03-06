using System.Collections.Generic;

namespace SDVModCollector.Templates.BFAV.Templates
{
  public class Content : ITemplate
  {
    public string Name { get; set; } = "Content";
    public string Format { get; set; }
    public IEnumerable<CategoryObject> Categories { get; set; }
  }
}
