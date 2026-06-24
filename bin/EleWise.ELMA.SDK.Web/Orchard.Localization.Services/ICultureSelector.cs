using System.Web;

namespace Orchard.Localization.Services;

public interface ICultureSelector : IDependency
{
	CultureSelectorResult GetCulture(HttpContextBase context);
}
