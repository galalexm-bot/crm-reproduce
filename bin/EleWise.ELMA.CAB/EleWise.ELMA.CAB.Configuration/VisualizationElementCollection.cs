using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;

namespace EleWise.ELMA.CAB.Configuration;

[ConfigurationCollection(typeof(VisualizationElement))]
public class VisualizationElementCollection : ConfigurationElementCollection, IEnumerable<VisualizationElement>, IEnumerable
{
	public new IEnumerator<VisualizationElement> GetEnumerator()
	{
		_003CGetEnumerator_003Ed__0 _003CGetEnumerator_003Ed__ = new _003CGetEnumerator_003Ed__0(0);
		_003CGetEnumerator_003Ed__._003C_003E4__this = this;
		IEnumerator<VisualizationElement> enumerator = _003CGetEnumerator_003Ed__;
		IEnumerator<VisualizationElement> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	protected override ConfigurationElement CreateNewElement()
	{
		ConfigurationElement configurationElement = new VisualizationElement();
		ConfigurationElement configurationElement2 = configurationElement;
		__ContractsRuntime.Ensures(configurationElement2 != null, null, "Contract.Result<ConfigurationElement>() != null");
		return configurationElement2;
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		__ContractsRuntime.Requires(element != null, null, "element != null");
		object type = ((VisualizationElement)element).Type;
		object obj = type;
		__ContractsRuntime.Ensures(obj != null, null, "Contract.Result<object>() != null");
		return obj;
	}

	public void Add(VisualizationElement element)
	{
		base.BaseAdd(element);
	}
}
