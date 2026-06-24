using System;
using System.Collections.Generic;
using System.Data.Services;
using System.ServiceModel.Activation;
using System.Web.Routing;
using EleWise.ELMA.Packaging.Server.DataServices;
using RouteMagic;

namespace EleWise.ELMA.Packaging.Server;

public static class PackageServerRoutes
{
	public static void MapRoutes(RouteCollection routes, Func<IEnumerable<ElmaPackageInfo>> installedPackagesFunc)
	{
		MapRoutes(routes, installedPackagesFunc, "PackageServer");
	}

	public static void MapRoutes(RouteCollection routes, Func<IEnumerable<ElmaPackageInfo>> installedPackagesFunc, string servicePrefix)
	{
		PackageDataService.InstalledPackagesFunc = installedPackagesFunc;
		RouteExtensions.MapDelegate(routes, "DownloadPackage", "PackageServer/Package/{packageId}/{version}", (object)new
		{
			httpMethod = new HttpMethodConstraint("GET")
		}, (Action<RequestContext>)delegate(RequestContext context)
		{
			CreatePackageService().DownloadPackage(context.HttpContext);
		});
		DataServiceHostFactory serviceHostFactory = new DataServiceHostFactory();
		ServiceRoute serviceRoute = new ServiceRoute(servicePrefix, serviceHostFactory, typeof(PackageDataService));
		serviceRoute.Defaults = new RouteValueDictionary { { "serviceType", "odata" } };
		serviceRoute.Constraints = new RouteValueDictionary { { "serviceType", "odata" } };
		routes.Add("nuget", serviceRoute);
	}

	private static PackageServerService CreatePackageService()
	{
		return PackageServerService.Instance;
	}
}
