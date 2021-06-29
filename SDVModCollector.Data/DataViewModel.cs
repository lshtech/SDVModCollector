using System.Collections.Generic;
using System.Linq;
using SDVModCollector.JSONScraper;
using SDVModCollector.Templates;

namespace SDVModCollector.Data
{
  public class DataViewModel
  {
    public DataViewModel(string modPath)
    {
      _modPath = modPath;
      _modCollection = DataLoader.LoadDataFromJson(modPath);
      var items = GetAllObjects();
      var x = items;
    }

    private ModCollection _modCollection;
    private string _modPath;

    public IEnumerable<object> GetAllObjects()
    {
      var jaPacks = _modCollection.ContentPacks.Where(c => c.PackType.ToLower() == Constants.JsonAssets);

      return (from pack in jaPacks from type in pack.Types.Values from obj in type.Templates.Values select obj).ToList();
    }
  }
}
