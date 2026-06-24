using System.Web;

namespace Orchard.Localization.Services;

public class SiteCultureSelector : ICultureSelector, IDependency
{
	private readonly IWorkContextAccessor _workContextAccessor;

	public SiteCultureSelector(IWorkContextAccessor workContextAccessor)
	{
		_workContextAccessor = workContextAccessor;
	}

	public CultureSelectorResult GetCulture(HttpContextBase context)
	{
		string siteCulture = _workContextAccessor.GetContext().CurrentSite.SiteCulture;
		if (string.IsNullOrEmpty(siteCulture))
		{
			return null;
		}
		return new CultureSelectorResult
		{
			Priority = -5,
			CultureName = siteCulture
		};
	}
}
