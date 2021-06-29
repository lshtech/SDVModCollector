using System.Collections.Generic;

namespace SDVModCollector.Templates.QuestFramework.Templates
{
  public class Quest
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Objective { get; set; }
    public int DaysLeft { get; set; }
    public string Reward { get; set; }
    public int RewardAmount { get; set; }
    public string RewardType { get; set; }
    public bool Cancelable { get; set; }
    public string Trigger { get; set; }
    public string ReactionText { get; set; }
    public IDictionary<string, int> FriendshipGain { get; set; }
    public IEnumerable<string> NextQuests { get; set; }
  }
}