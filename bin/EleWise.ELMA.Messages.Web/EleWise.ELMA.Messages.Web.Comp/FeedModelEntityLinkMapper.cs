using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(Order = 100000)]
internal class FeedModelEntityLinkMapper : IFeedModelEntityMapper
{
	private static readonly object lockObject = new object();

	private static HttpContext innerHttpContext = null;

	public FeedModel MapEntity(IEntity entity, FeedModel originalModel)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		if (originalModel == null)
		{
			return null;
		}
		HttpContext httpContext = HttpContext.Current ?? innerHttpContext;
		if (httpContext == null)
		{
			if (innerHttpContext == null)
			{
				lock (lockObject)
				{
					if (innerHttpContext == null)
					{
						CommonSettings settings = Locator.GetServiceNotNull<CommonSettingsModule>().Settings;
						HttpRequest request = new HttpRequest("/", settings.ApplicationBaseUrl, "");
						HttpResponse response = new HttpResponse(new StringWriter());
						innerHttpContext = new HttpContext(request, response);
					}
				}
			}
			httpContext = innerHttpContext;
		}
		HttpContextWrapper httpContext2 = new HttpContextWrapper(httpContext);
		RouteData routeData = new RouteData();
		string text2 = (originalModel.Url = UrlExtensions.Entity(new UrlHelper(new RequestContext(httpContext2, routeData)), entity));
		return originalModel;
	}
}
