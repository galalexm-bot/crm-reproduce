using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;

namespace EleWise.ELMA.CAB.Configuration;

[ConfigurationCollection(typeof(ServiceElement))]
public class ServiceElementCollection : ConfigurationElementCollection, IEnumerable<ServiceElement>, IEnumerable
{
	public ServiceElement this[Type serviceType]
	{
		get
		{
			return (ServiceElement)BaseGet(serviceType);
		}
		set
		{
			if (BaseGet(serviceType) != null)
			{
				BaseRemove(serviceType);
			}
			base.BaseAdd(value);
		}
	}

	public new IEnumerator<ServiceElement> GetEnumerator()
	{
		_003CGetEnumerator_003Ed__0 _003CGetEnumerator_003Ed__ = new _003CGetEnumerator_003Ed__0(0);
		_003CGetEnumerator_003Ed__._003C_003E4__this = this;
		IEnumerator<ServiceElement> enumerator = _003CGetEnumerator_003Ed__;
		IEnumerator<ServiceElement> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	protected override ConfigurationElement CreateNewElement()
	{
		ConfigurationElement configurationElement = new ServiceElement();
		ConfigurationElement configurationElement2 = configurationElement;
		__ContractsRuntime.Ensures(configurationElement2 != null, null, "Contract.Result<ConfigurationElement>() != null");
		return configurationElement2;
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		__ContractsRuntime.Requires(element != null, null, "element != null");
		object serviceType = ((ServiceElement)element).ServiceType;
		object obj = serviceType;
		__ContractsRuntime.Ensures(obj != null, null, "Contract.Result<object>() != null");
		return obj;
	}

	public void Add(ServiceElement service)
	{
		base.BaseAdd(service);
	}

	public void Remove(Type serviceType)
	{
		BaseRemove(serviceType);
	}
}
