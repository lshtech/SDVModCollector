using System.Collections.Generic;

namespace SDVModCollector.Templates.JsonAssets.Templates.Shared
{
  public class GiftTastes
  {
    public IList<string> Dislike = new List<string>();
    public IList<string> Hate = new List<string>();
    public IList<string> Like = new List<string>();
    public IList<string> Love = new List<string>();
    public IList<string> Neutral = new List<string>();
  }
}