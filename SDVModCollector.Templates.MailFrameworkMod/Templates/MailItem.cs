using System.Collections.Generic;

namespace SDVModCollector.Templates.MailFrameworkMod.Templates
{
  public class MailItem
  {
    public string Id { get; set; }
    public string GroupId { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string Recipe { get; set; }
    public IEnumerable<Attachment> Attachments { get; set; }
    public string LetterBG { get; set; }
    public int WhichBG { get; set; }
    public int? TextColor { get; set; }
    public string UpperRightCloseButton { get; set; }
    public bool Repeatable { get; set; }
    public string Date { get; set; }
    public IEnumerable<int> Days { get; set; }
    public IEnumerable<string> Seasons { get; set; }
    public string Weather { get; set; }
    public IEnumerable<FriendshipCondition> FriendshipConditions { get; set; }
    public IEnumerable<SkillCondition> SkillConditions { get; set; }
    public IEnumerable<StatsCondition> StatsConditions { get; set; }
    public IEnumerable<CollectionCondition> CollectionConditions { get; set; }
    public double? RandomChance { get; set; }
    public IEnumerable<string> Buildings { get; set; }
    public bool RequireAllBuildings { get; set; }
    public IEnumerable<string> MailReceived { get; set; }
    public bool RequireAllMailReceived { get; set; }
    public IEnumerable<string> MailNotReceived { get; set; }
    public IEnumerable<int> EventsSeen { get; set; }
    public bool RequireAllEventsSeen { get; set; }
    public IEnumerable<int> EventsNotSeen { get; set; }
    public IEnumerable<string> RecipeKnown { get; set; }
    public bool RequireAllRecipeKnown { get; set; }
    public IEnumerable<string> RecipeNotKnown { get; set; }
    public bool AutoOpen { get; set; }
  }
}