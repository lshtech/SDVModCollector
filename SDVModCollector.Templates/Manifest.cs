using System.Collections.Generic;
using System.IO;

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
    public ModUpdater ModUpdater { get; set; }
    public IEnumerable<Dependency> Dependencies { get; set; }
    public string FilePath { get; set; }
    public string BaseDirectory => new FileInfo(FilePath).DirectoryName;
    public IEnumerable<string> UpdateKeys { get; set; } = new List<string>();
  }
}