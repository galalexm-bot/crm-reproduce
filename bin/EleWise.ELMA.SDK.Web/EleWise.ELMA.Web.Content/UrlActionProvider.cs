using System.Web.Routing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Content;

[Service(Scope = ServiceScope.Shell)]
public class UrlActionProvider
{
	public string Id => "UrlLinkTypeProvider";

	public IContentAction Get(string id)
	{
		return new ContentAction
		{
			ReferenceType = "url",
			Id = id,
			LinkTemplate = (RequestContext context) => id
		};
	}
}
