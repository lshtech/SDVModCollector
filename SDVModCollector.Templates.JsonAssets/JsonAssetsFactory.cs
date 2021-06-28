using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SDVModCollector.Templates.JsonAssets.Templates;

namespace SDVModCollector.Templates.JsonAssets
{
  public class JsonAssetsFactory : FactoryAbstract
  {
    public override (string type, ITemplate deserializedObject) CreateTemplate(Manifest manifest, string jsonPath)
    {
      var objectType = GetPathTypes(jsonPath);

      return objectType switch
      {
        ("object.json", "objects") => ("object",
          JsonConvert.DeserializeObject<Object>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("crop.json", "crops") => ("crop",
          JsonConvert.DeserializeObject<Crop>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("tree.json", "fruittrees") => ("tree",
          JsonConvert.DeserializeObject<FruitTree>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("big-craftable.json", "bigcraftables") => ("big-craftable",
          JsonConvert.DeserializeObject<BigCraftable>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("hat.json", "hats") => ("hat",
          JsonConvert.DeserializeObject<Hat>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("weapon.json", "weapons") => ("weapon",
          JsonConvert.DeserializeObject<Weapon>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("shirt.json", "shirts") => ("shirt",
          JsonConvert.DeserializeObject<Shirt>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("pants.json", "pants") => ("pants",
          JsonConvert.DeserializeObject<Pants>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("recipe.json", "tailoring") => ("tailoring",
          JsonConvert.DeserializeObject<TailoringRecipe>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("boots.json", "boots") => ("boots",
          JsonConvert.DeserializeObject<Boots>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("fence.json", "fences") => ("fence",
          JsonConvert.DeserializeObject<Fence>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        ("recipe.json", "forge") => ("forge",
          JsonConvert.DeserializeObject<ForgeRecipe>(File.ReadAllText(jsonPath).Replace('“', '"').Replace('”', '"')).AddPath(jsonPath)),
        _ => (string.Empty, null)
      };
    }

    private (string fileName, string typeDirectory) GetPathTypes(string path)
    {
      var fi = new FileInfo(path);
      var fileName = fi.Name;
      var typeDirectory = fi.Directory?.Parent;
      return typeDirectory is null ? ("", "") : (fileName.ToLower(), typeDirectory.Name.ToLower());
    }

    public override IEnumerable<string> GetJsonFiles(string modsPath) =>
      Directory.EnumerateFiles(modsPath, "*.json", SearchOption.AllDirectories)
        .Where(f => !f.EndsWith("manifest.json"));
  }
}