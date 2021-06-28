using System.IO;

namespace SDVModCollector.Templates.JsonAssets.Templates
{
  public abstract class ObjectAbstract : ITemplate
  {
    internal int id = -1;

    public string EnableWithMod { get; set; }
    public string DisableWithMod { get; set; }

    public string Directory { get; set; }
    public string Name { get; set; }

    internal string GetImage(string imageName)
    {
      var imagePath = Path.Combine(Directory, $"{imageName}.png");
      return File.Exists(imagePath) ? imagePath : string.Empty;
    }
  }
}