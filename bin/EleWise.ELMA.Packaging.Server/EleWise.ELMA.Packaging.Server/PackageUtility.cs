using System;
using System.Web;
using System.Web.Hosting;
using System.Web.Routing;
using EleWise.ELMA.Packaging.Server.DataServices;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

public class PackageUtility
{
	private static Lazy<string> _packagePhysicalPath = new Lazy<string>(ResolvePackagePath);

	public static string PackagePhysicalPath => _packagePhysicalPath.Value;

	public static string GetPackageDownloadUrl(Package package)
	{
		RouteValueDictionary values = new RouteValueDictionary
		{
			{ "packageId", package.Id },
			{
				"version",
				package.Version.ToString()
			}
		};
		HttpContext current = HttpContext.Current;
		VirtualPathData virtualPath = RouteTable.Routes["DownloadPackage"].GetVirtualPath(current.Request.RequestContext, values);
		return Helpers.EnsureTrailingSlash(current.Request.ApplicationPath) + virtualPath.VirtualPath;
	}

	private static string ResolvePackagePath()
	{
		string packagesPath = PackageServerSettings.Current.PackagesPath;
		if (string.IsNullOrEmpty(packagesPath))
		{
			return HostingEnvironment.MapPath("~/Packages");
		}
		if (packagesPath.StartsWith("~/"))
		{
			return HostingEnvironment.MapPath(packagesPath);
		}
		return packagesPath;
	}
}
