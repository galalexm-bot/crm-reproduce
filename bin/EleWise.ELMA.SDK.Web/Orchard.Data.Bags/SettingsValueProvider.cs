using System.Web.Mvc;

namespace Orchard.Data.Bags;

public class SettingsValueProvider : IValueProvider
{
	private readonly dynamic _state;

	public SettingsValueProvider(dynamic state)
	{
		_state = state;
	}

	public bool ContainsPrefix(string prefix)
	{
		return true;
	}

	public ValueProviderResult GetValue(string key)
	{
		return (ValueProviderResult)_state[key];
	}
}
