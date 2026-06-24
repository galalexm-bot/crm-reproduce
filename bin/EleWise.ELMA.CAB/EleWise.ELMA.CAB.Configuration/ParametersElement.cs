using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics.Contracts;

namespace EleWise.ELMA.CAB.Configuration;

public abstract class ParametersElement : ConfigurationElement
{
	private readonly NameValueCollection configAttributes = new NameValueCollection();

	private readonly ConfigurationPropertyCollection dynamicProperties = new ConfigurationPropertyCollection();

	protected internal override ConfigurationPropertyCollection Properties
	{
		protected get
		{
			ConfigurationPropertyCollection properties = base.Properties;
			foreach (ConfigurationProperty dynamicProperty in dynamicProperties)
			{
				properties.Add(dynamicProperty);
			}
			return properties;
		}
	}

	public NameValueCollection Parameters => configAttributes;

	protected override bool OnDeserializeUnrecognizedAttribute(string name, string value)
	{
		__ContractsRuntime.Requires(name != null, null, "name != null");
		ConfigurationProperty configurationProperty = new ConfigurationProperty(name, typeof(string), value);
		dynamicProperties.Add(configurationProperty);
		base[configurationProperty] = value;
		configAttributes.Add(name, value);
		return true;
	}
}
