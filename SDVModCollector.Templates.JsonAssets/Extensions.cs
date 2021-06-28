using System.IO;
using SDVModCollector.Templates.JsonAssets.Templates;

namespace SDVModCollector.Templates.JsonAssets
{
  internal static class Extensions
  {
    internal static ObjectAbstract AddPath(this ObjectAbstract item, string filePath)
    {
      item.Directory = new FileInfo(filePath).DirectoryName;
      return item;
    }
  }
}