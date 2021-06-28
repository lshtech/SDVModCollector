using System.IO;
using Newtonsoft.Json;

namespace SDVModCollector.Templates.JsonAssets
{
  public class JsonAssetsFactory : ITemplateFactory
  {
    public ITemplate CreateTemplate(Manifest manifest, string jsonPath)
    {
      var (fileName, typeDirectory) = GetPathTypes(jsonPath);
      if (fileName.ToLower() == "object.json" && typeDirectory.ToLower() == "object")
      {
        return JsonConvert.DeserializeObject<Object>(File.ReadAllText(jsonPath));
      }
      return null;
    }

    private (string fileName, string typeDirectory) GetPathTypes(string path)
    {
      var fi = new FileInfo(path);
      var fileName = fi.Name;
      var typeDirectory = fi.Directory?.Parent;
      return typeDirectory is null ? ("", "") : (fileName, typeDirectory.Name);
    }
  }
}
