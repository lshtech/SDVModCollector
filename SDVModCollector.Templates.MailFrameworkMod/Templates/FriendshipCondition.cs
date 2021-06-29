using System.Collections.Generic;

namespace SDVModCollector.Templates.MailFrameworkMod.Templates
{
  public class FriendshipCondition
  {
    public string NpcName { get; set; }
    public int FriendshipLevel { get; set; }
    public IEnumerable<string> FriendshipStatus { get; set; }
  }
}