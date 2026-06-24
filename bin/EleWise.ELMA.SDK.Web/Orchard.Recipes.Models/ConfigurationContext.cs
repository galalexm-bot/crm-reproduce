using System.Xml.Linq;

namespace Orchard.Recipes.Models;

public class ConfigurationContext
{
	public XElement ConfigurationElement { get; set; }

	protected ConfigurationContext(XElement configurationElement)
	{
		ConfigurationElement = configurationElement;
	}
}
