using System.Collections.Generic;

namespace SDVModCollector.Templates.ContentPatcher.Templates
{
  public class Content : ITemplate
  {
    public string Name { get; set; } = "ContentPatcher";
    public string Format { get; set; }
    public IDictionary<string, ConfigOptions> ConfigSchema { get; set; }
    public IEnumerable<DynamicToken> DynamicTokens { get; set; }
    public IEnumerable<CustomLocation> CustomLocations { get; set; } 
    public IEnumerable<object> Changes { get; set; }
  }

  public class Change
  {
    public string Action { get; set; }
    public string Target { get; set; }

    public string FromFile { get; set; }

    public Area ToArea { get; set; }
    public IDictionary<string, string> When { get; set; }
    public string Update { get; set; }
    public IDictionary<string, string> MapProperties { get; set; }
    public IDictionary<string, object> Entries { get; set; } 
    public IEnumerable<TextOperation> TextOperations { get; set; }
    public string PatchMode { get; set; }
    public IEnumerable<MapTile> MapTiles { get; set; }
  }

  public class MapTile
  {
    public Position Position { get; set; }
    public string Layer { get; set; }
    public IDictionary<string, string> TouchAction { get; set; }
  }

  public class Position
  {
    public int X { get; set; }
    public int Y { get; set; }
  }

  public class TextOperation
  {
    public string Operation { get; set; }
    public IEnumerable<string> Target { get; set; }
    public string Value { get; set; }
    public string Delimiter { get; set; }
  }

  public class Area
  {
    public string X { get; set; }
    public string Y { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
  }

  public class CustomLocation
  {
    public string Name { get; set; }
    public string FromMapFile { get; set; }
    public IEnumerable<string> MigrateLegacyNames { get; set; }
    public IDictionary<string, string> When { get; set; }
  }

  public class DynamicToken
  {
    public string Name { get; set; }
    public string Value { get; set; }
    public IDictionary<string, string> When { get; set; }
  }

  public class ConfigOptions
  {
    public string AllowValues { get; set; }
    public string Default { get; set; }
  }
}
