using System;
using System.Configuration.Provider;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public class PersonaliationProviderCollection : ProviderCollection
{
	public new PersonalizationProvider this[string name] => (PersonalizationProvider)base[name];

	public override void Add(ProviderBase provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!(provider is PersonalizationProvider))
		{
			string paramName = typeof(PersonalizationProvider).ToString();
			throw new ArgumentException("Provider must implement PersonalizationProvider type", paramName);
		}
		base.Add(provider);
	}
}
