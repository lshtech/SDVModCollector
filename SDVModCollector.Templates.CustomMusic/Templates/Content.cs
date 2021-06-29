using System.Collections.Generic;

namespace SDVModCollector.Templates.CustomMusic.Templates
{
  public class Content : ITemplate
  {
    public string Name { get; set; } = "CustomMusic";
    public IEnumerable<Music> Music { get; set; }
  }
}
