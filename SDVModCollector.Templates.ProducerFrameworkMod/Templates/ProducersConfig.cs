

using System.Collections.Generic;

namespace SDVModCollector.Templates.ProducerFrameworkMod.Templates
{
  public class ProducersConfig : ITemplate
  {
    public ProducersConfig(IEnumerable<Producer> producers)
    {
      Producers = producers;
    }

    public string Name { get; set; } = "Machine";
    public IEnumerable<Producer> Producers { get; set; }
  }

  public class Producer
  {
    public string ProducerName { get; set; }
    public bool AlternateFrameProducing { get; set; }
    public bool AlternateFrameWhenReady { get; set; }
  }
}
