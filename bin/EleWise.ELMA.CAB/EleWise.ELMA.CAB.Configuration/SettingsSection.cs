using System.Configuration;

namespace EleWise.ELMA.CAB.Configuration;

public class SettingsSection : ConfigurationSection
{
	public const string SectionName = "CompositeUI";

	[ConfigurationProperty("services", IsRequired = true)]
	public ServiceElementCollection Services => (ServiceElementCollection)base["services"];

	[ConfigurationProperty("visualizer", IsRequired = false)]
	public VisualizationElementCollection Visualizer => (VisualizationElementCollection)base["visualizer"];
}
