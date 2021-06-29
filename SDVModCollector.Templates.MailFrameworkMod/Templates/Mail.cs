using System.Collections.Generic;

namespace SDVModCollector.Templates.MailFrameworkMod.Templates
{
  public class Mail : ITemplate
  {
    public Mail(IEnumerable<MailItem> mailItems)
    {
      MailItems = mailItems;
    }

    public IEnumerable<MailItem> MailItems { get; set; }

    public string Name { get; set; } = "MFM";
  }
}