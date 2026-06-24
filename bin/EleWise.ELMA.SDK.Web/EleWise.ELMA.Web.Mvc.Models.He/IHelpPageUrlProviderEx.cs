using System.Web;

namespace EleWise.ELMA.Web.Mvc.Models.Help;

public interface IHelpPageUrlProviderEx : IHelpPageUrlProvider
{
	string FindUrl(HttpContextBase httpContext, string pagePath);
}
