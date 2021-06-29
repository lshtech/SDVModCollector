using System.Collections.Generic;

namespace SDVModCollector.Templates.QuestFramework.Templates
{
  public class QuestsConfig : ITemplate
  {
    public string Name { get; set; } = "QF";
    public IEnumerable<Quest> Quests { get; set; }
    public IEnumerable<Offer> Offers { get; set; }
  }
}
