using System.Collections.Generic;

namespace SDVModCollector.Templates.TMXLoader.Templates
{
  public class NPCPlacement
  {
    public string name { get; set; } 
    public string map { get; set; } 
    public IEnumerable<int> position { get; set; } 
    public IEnumerable<int> position2 { get; set; }
    public int direction { get; set; } 
    public int direction2 { get; set; } 
    public bool datable { get; set; }
    public string conditions { get; set; } 
  }
}