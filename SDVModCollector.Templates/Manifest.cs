using System.Collections.Generic;

namespace SDVModCollector.Templates
{
  public class Manifest
  {
    public string Name { get; set; }
    public string Author { get; set; }
    public string Version { get; set; }
    public string Description { get; set; }
    public string UniqueId { get; set; }
    public ContentPackFor ContentPackFor { get; set; }
    public string EntryDll { get; set; }
    public string MinimumApiVersion { get; set; }
    public IEnumerable<string> UpdateKeys { get; set; }
    public ModUpdater ModUpdater { get; set; }
    public IEnumerable<Dependency> Dependencies { get; set; }
  }

  public struct ContentPackFor
  {
    public string UniqueId { get; set; }
    public string MinimumVersion { get; set; }
  }
  public struct Dependency
  {
    public string UniqueId { get; set; }
    public bool IsRequired { get; set; }
  }

  public struct ModUpdater
  {
    public string Repository { get; set; }
    public string User { get; set; }
    public string Directory { get; set; }
    public string ModFolder { get; set; }
  }
}
