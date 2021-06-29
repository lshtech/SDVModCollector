using System.Collections.Generic;

namespace SDVModCollector.Templates.ProducerFrameworkMod.Templates
{
  public class ProducerRules : ITemplate
  {
    public ProducerRules(IEnumerable<ProducerRule> rules)
    {
      Rules = rules;
    }

    public string Name { get; set; } = "Rule";
    public IEnumerable<ProducerRule> Rules { get; set; }
  }
}
