using System.Collections.Generic;

namespace SDVModCollector.Templates.TMXLoader.Templates
{
  public class MapEdit
  {
    public string name { get; set; }

    public bool addLocation { get; set; }
    public string file { get; set; }
    public IEnumerable<int> sourceArea { get; set; }
    public IEnumerable<int> position { get; set; } 
    public IEnumerable<string> addWarps { get; set; }
    public IEnumerable<string> removeWarps { get; set; }
    public bool retainWarps { get; set; }
    public bool removeEmpty { get; set; }
    public string info { get; set; }
    public string type { get; set; }

    public string conditions { get; set; } 
  }
}