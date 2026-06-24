using System;
using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.UIElements;

public class UIElementAdapterFactoryCatalog : IUIElementAdapterFactoryCatalog
{
	private readonly List<IUIElementAdapterFactory> factories = new List<IUIElementAdapterFactory>();

	public IList<IUIElementAdapterFactory> Factories => factories.AsReadOnly();

	public void RegisterFactory(IUIElementAdapterFactory adapterFactory)
	{
		Guard.ArgumentNotNull(adapterFactory, "adapterFactory");
		factories.Add(adapterFactory);
	}

	public IUIElementAdapterFactory GetFactory(object element)
	{
		foreach (IUIElementAdapterFactory factory in factories)
		{
			if (factory.Supports(element))
			{
				return factory;
			}
		}
		throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.NoRegisteredUIElementFactory, new object[1] { element.GetType() }));
	}
}
