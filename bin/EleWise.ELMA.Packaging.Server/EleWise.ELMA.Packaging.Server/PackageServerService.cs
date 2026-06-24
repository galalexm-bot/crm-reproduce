using System.Net;
using System.Web;
using System.Web.Routing;
using EleWise.ELMA.Packaging.Server.DataServices;
using EleWise.ELMA.Packaging.Server.Infrastructure;
using NuGet;

namespace EleWise.ELMA.Packaging.Server;

public class PackageServerService
{
	private const string ApiKeyHeader = "X-NUGET-APIKEY";

	private readonly IServerPackageRepository _serverRepository;

	private readonly IPackageAuthenticationService _authenticationService;

	private static PackageServerService _instance;

	public static PackageServerService Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new PackageServerService();
			}
			return _instance;
		}
		set
		{
			_instance = value;
		}
	}

	public PackageServerService()
		: this(ServerPackageRepository.Instance, PackageAuthenticationService.Instance)
	{
	}

	public PackageServerService(IServerPackageRepository repository, IPackageAuthenticationService authenticationService)
	{
		_serverRepository = repository;
		_authenticationService = authenticationService;
	}

	public void CreatePackage(HttpContextBase context)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		HttpRequestBase request = context.Request;
		string apiKey = request.Headers["X-NUGET-APIKEY"];
		ZipPackage val = new ZipPackage((request.Files.Count > 0) ? request.Files[0].InputStream : request.InputStream);
		if (Authenticate(context, apiKey, ((LocalPackage)val).get_Id()))
		{
			((IPackageRepository)_serverRepository).AddPackage((IPackage)(object)val);
			WriteStatus(context, HttpStatusCode.Created, "");
		}
	}

	public void PublishPackage(HttpContextBase context)
	{
	}

	public void DeletePackage(HttpContextBase context)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		RouteData routeData = GetRouteData(context);
		string apiKey = context.Request.Headers["X-NUGET-APIKEY"];
		string requiredString = routeData.GetRequiredString("packageId");
		SemanticVersion val = new SemanticVersion(routeData.GetRequiredString("version"));
		if (PackageRepositoryExtensions.FindPackage((IPackageRepository)_serverRepository, requiredString, val) == null)
		{
			WritePackageNotFound(context, requiredString, val);
		}
		else if (Authenticate(context, apiKey, requiredString))
		{
			_serverRepository.RemovePackage(requiredString, val);
		}
	}

	public void DownloadPackage(HttpContextBase context)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		RouteData routeData = GetRouteData(context);
		string requiredString = routeData.GetRequiredString("packageId");
		SemanticVersion val = new SemanticVersion(routeData.GetRequiredString("version"));
		IPackage val2 = PackageRepositoryExtensions.FindPackage((IPackageRepository)_serverRepository, requiredString, val);
		if (val2 != null)
		{
			Package metadataPackage = _serverRepository.GetMetadataPackage(val2);
			context.Response.AddHeader("content-disposition", $"attachment; filename={metadataPackage.Path}");
			context.Response.ContentType = "application/zip";
			context.Response.TransmitFile(metadataPackage.FullPath);
		}
		else
		{
			WritePackageNotFound(context, requiredString, val);
		}
	}

	private static void WritePackageNotFound(HttpContextBase context, string packageId, SemanticVersion version)
	{
		WriteStatus(context, HttpStatusCode.NotFound, $"'Package {packageId} {version}' Not found.");
	}

	private bool Authenticate(HttpContextBase context, string apiKey, string packageId)
	{
		if (_authenticationService.IsAuthenticated(context.User, apiKey, packageId))
		{
			return true;
		}
		WriteForbidden(context, packageId);
		return false;
	}

	private static void WriteForbidden(HttpContextBase context, string packageId)
	{
		WriteStatus(context, HttpStatusCode.Forbidden, $"Access denied for package '{packageId}'.");
	}

	private static void WriteStatus(HttpContextBase context, HttpStatusCode statusCode, string body = null)
	{
		context.Response.StatusCode = (int)statusCode;
		if (!string.IsNullOrEmpty(body))
		{
			context.Response.StatusDescription = body;
		}
	}

	private RouteData GetRouteData(HttpContextBase context)
	{
		return RouteTable.Routes.GetRouteData(context);
	}
}
