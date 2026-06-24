using System;
using System.Collections.Generic;
using System.Linq;
using NuGet;

namespace EleWise.ELMA.Packaging;

public class PackageDataServiceClient
{
	private IDataServiceContext _context;

	private readonly IHttpClient _httpClient;

	protected IDataServiceContext Context
	{
		private get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			if (_context == null)
			{
				_context = (IDataServiceContext)new DataServiceContextWrapper(_httpClient.get_Uri());
				_context.set_IgnoreMissingProperties(true);
			}
			return _context;
		}
		set
		{
			_context = value;
		}
	}

	public PackageDataServiceClient(Uri uri)
		: this((IHttpClient)new HttpClient(uri))
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)
	//IL_000c: Expected O, but got Unknown


	public PackageDataServiceClient(IHttpClient client)
		: this(client, new PackageDownloader())
	{
	}

	public PackageDataServiceClient(IHttpClient client, PackageDownloader packageDownloader)
	{
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		if (packageDownloader == null)
		{
			throw new ArgumentNullException("packageDownloader");
		}
		_httpClient = client;
		_httpClient.set_AcceptCompression(true);
	}

	public IEnumerable<ElmaPackageInfo> GetInstalledPackages()
	{
		IQueryable<ElmaPackageInfoData> packagesData = GetPackagesData();
		if (packagesData == null)
		{
			return new ElmaPackageInfo[0];
		}
		return (from d in packagesData.ToList()
			select d.ToInfo()).ToArray();
	}

	public virtual IQueryable<ElmaPackageInfoData> GetPackagesData()
	{
		return (IQueryable<ElmaPackageInfoData>)new SmartDataServiceQuery<ElmaPackageInfoData>(Context, "InstalledPackages");
	}

	public IEnumerable<ElmaPackageInfo> GetPackages()
	{
		SmartDataServiceQuery<ElmaPackageInfoData> val = new SmartDataServiceQuery<ElmaPackageInfoData>(Context, "Packages");
		if (val == null)
		{
			return new ElmaPackageInfo[0];
		}
		return (from d in ((IEnumerable<ElmaPackageInfoData>)val).ToList()
			select d.ToInfo()).ToArray();
	}
}
