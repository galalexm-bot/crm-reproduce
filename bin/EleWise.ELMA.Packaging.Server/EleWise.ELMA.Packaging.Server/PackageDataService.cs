using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using EleWise.ELMA.Packaging.Server.Infrastructure;
using NuGet;

namespace EleWise.ELMA.Packaging.Server.DataServices;

[ServiceBehavior(IncludeExceptionDetailInFaults = true, Name = "Packages")]
public class PackageDataService : DataService<PackageContext>, IDataServiceStreamProvider, IServiceProvider
{
	private IServerPackageRepository Repository => ServerPackageRepository.Instance;

	public static Func<IEnumerable<ElmaPackageInfo>> InstalledPackagesFunc { get; set; }

	public int StreamBufferSize => 64000;

	public static void InitializeService(DataServiceConfiguration config)
	{
		config.SetEntitySetAccessRule("Packages", EntitySetRights.AllRead);
		config.SetEntitySetPageSize("Packages", 100);
		config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
		config.UseVerboseErrors = true;
		config.SetEntitySetAccessRule("InstalledPackages", EntitySetRights.AllRead);
		config.SetEntitySetPageSize("InstalledPackages", 100);
		RegisterServices(config);
	}

	internal static void RegisterServices(IDataServiceConfiguration config)
	{
		config.SetServiceOperationAccessRule("Search", ServiceOperationRights.AllRead);
		config.SetServiceOperationAccessRule("FindPackagesById", ServiceOperationRights.AllRead);
		config.SetServiceOperationAccessRule("GetUpdates", ServiceOperationRights.AllRead);
	}

	protected override PackageContext CreateDataSource()
	{
		return new PackageContext(Repository, InstalledPackagesFunc);
	}

	public void DeleteStream(object entity, DataServiceOperationContext operationContext)
	{
		throw new NotSupportedException();
	}

	public Stream GetReadStream(object entity, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
	{
		throw new NotSupportedException();
	}

	public Uri GetReadStreamUri(object entity, DataServiceOperationContext operationContext)
	{
		Package package = (Package)entity;
		string rootUrl = PackageServerSettings.Current.RootUrl;
		string uriString = ((!string.IsNullOrWhiteSpace(rootUrl)) ? rootUrl : HttpContext.Current.Request.Url.GetComponents(UriComponents.SchemeAndServer, UriFormat.Unescaped));
		return new Uri(relativeUri: PackageUtility.GetPackageDownloadUrl(package), baseUri: new Uri(uriString));
	}

	public string GetStreamContentType(object entity, DataServiceOperationContext operationContext)
	{
		return "application/zip";
	}

	public string GetStreamETag(object entity, DataServiceOperationContext operationContext)
	{
		return null;
	}

	public Stream GetWriteStream(object entity, string etag, bool? checkETagForEquality, DataServiceOperationContext operationContext)
	{
		throw new NotSupportedException();
	}

	public string ResolveType(string entitySetName, DataServiceOperationContext operationContext)
	{
		throw new NotSupportedException();
	}

	public object GetService(Type serviceType)
	{
		if (serviceType == typeof(IDataServiceStreamProvider))
		{
			return this;
		}
		return null;
	}

	[WebGet]
	public IQueryable<Package> Search(string searchTerm, string targetFramework, bool includePrerelease)
	{
		return ((IServiceBasedRepository)Repository).Search(searchTerm, (IEnumerable<string>)null, includePrerelease).Select((Expression<Func<IPackage, Package>>)((IPackage package) => Repository.GetMetadataPackage(package)));
	}

	[WebGet]
	public IQueryable<Package> FindPackagesById(string id)
	{
		return PackageRepositoryExtensions.FindPackagesById((IPackageRepository)Repository, id).Select(Repository.GetMetadataPackage).AsQueryable();
	}

	[WebGet]
	public IQueryable<Package> GetUpdates(string packageIds, string versions, bool includePrerelease, bool includeAllVersions, string targetFrameworks)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c6: Expected O, but got Unknown
		if (string.IsNullOrEmpty(packageIds) || string.IsNullOrEmpty(versions))
		{
			return Enumerable.Empty<Package>().AsQueryable();
		}
		string[] array = packageIds.Trim().Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
		string[] array2 = versions.Trim().Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
		List<FrameworkName> list = (string.IsNullOrEmpty(targetFrameworks) ? null : ((IEnumerable<string>)targetFrameworks.Split('|')).Select((Func<string, FrameworkName>)VersionUtility.ParseFrameworkName).ToList());
		if (array.Length == 0 || array.Length != array2.Length)
		{
			return Enumerable.Empty<Package>().AsQueryable();
		}
		List<IPackageMetadata> list2 = new List<IPackageMetadata>();
		for (int i = 0; i < array.Length; i++)
		{
			PackageBuilder val = new PackageBuilder();
			val.set_Id(array[i]);
			val.set_Version(new SemanticVersion(array2[i]));
			list2.Add((IPackageMetadata)val);
		}
		return PackageRepositoryExtensions.GetUpdatesCore((IPackageRepository)Repository, (IEnumerable<IPackageName>)list2, includePrerelease, includeAllVersions, (IEnumerable<FrameworkName>)list, (IEnumerable<IVersionSpec>)null).AsQueryable().Select((Expression<Func<IPackage, Package>>)((IPackage package) => Repository.GetMetadataPackage(package)));
	}
}
