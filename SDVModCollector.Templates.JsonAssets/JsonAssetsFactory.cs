using System.Collections.Generic;
using System.IO;
using System.Linq;
using SDVModCollector.JSONHelper;
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
          Helper.DeserializeObject<Object>(jsonPath).AddPath(jsonPath)),
        ("crop.json", "crops") => ("crop",
          Helper.DeserializeObject<Crop>(jsonPath).AddPath(jsonPath)),
        ("tree.json", "fruittrees") => ("tree",
          Helper.DeserializeObject<FruitTree>(jsonPath).AddPath(jsonPath)),
        ("big-craftable.json", "bigcraftables") => ("big-craftable",
          Helper.DeserializeObject<BigCraftable>(jsonPath).AddPath(jsonPath)),
        ("hat.json", "hats") => ("hat",
          Helper.DeserializeObject<Hat>(jsonPath).AddPath(jsonPath)),
        ("weapon.json", "weapons") => ("weapon",
          Helper.DeserializeObject<Weapon>(jsonPath).AddPath(jsonPath)),
        ("shirt.json", "shirts") => ("shirt",
          Helper.DeserializeObject<Shirt>(jsonPath).AddPath(jsonPath)),
        ("pants.json", "pants") => ("pants",
          Helper.DeserializeObject<Pants>(jsonPath).AddPath(jsonPath)),
        ("recipe.json", "tailoring") => ("tailoring",
          Helper.DeserializeObject<TailoringRecipe>(jsonPath).AddPath(jsonPath)),
        ("boots.json", "boots") => ("boots",
          Helper.DeserializeObject<Boots>(jsonPath).AddPath(jsonPath)),
        ("fence.json", "fences") => ("fence",
          Helper.DeserializeObject<Fence>(jsonPath).AddPath(jsonPath)),
        ("recipe.json", "forge") => ("forge",
          Helper.DeserializeObject<ForgeRecipe>(jsonPath).AddPath(jsonPath)),
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

    public override IEnumerable<string> GetJsonFiles(string modsPath)
    {
      return Directory.EnumerateFiles(modsPath, "*.json", SearchOption.AllDirectories)
        .Where(f => !f.EndsWith("manifest.json"));
    }
  }
}