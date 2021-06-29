using System.Collections.Generic;

namespace SDVModCollector.Templates.QuestFramework.Templates
{
  public class Offer
  {
    public string QuestName { get; set; }
    public string OfferedBy { get; set; }
    public IDictionary<string, string> OfferDetails { get; set; }
    public IDictionary<string, string> When { get; set; }
  }
}