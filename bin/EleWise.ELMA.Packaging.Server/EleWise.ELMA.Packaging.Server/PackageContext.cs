using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Packaging.Server.Infrastructure;
using NuGet;

namespace EleWise.ELMA.Packaging.Server.DataServices;

public class PackageContext
{
	private readonly IServerPackageRepository _repository;

	private readonly Func<IEnumerable<ElmaPackageInfo>> _installedPackagesFunc;

	public IQueryable<Package> Packages => ((IPackageRepository)_repository).GetPackages().Select((Expression<Func<IPackage, Package>>)((IPackage p) => _repository.GetMetadataPackage(p)));

	public IQueryable<ElmaPackageInfoData> InstalledPackages
	{
		get
		{
			IEnumerable<ElmaPackageInfo> enumerable = ((_installedPackagesFunc != null) ? _installedPackagesFunc() : null);
			if (enumerable == null)
			{
				return new ElmaPackageInfoData[0].AsQueryable();
			}
			return enumerable.Select((ElmaPackageInfo i) => new ElmaPackageInfoData(i)).ToList().AsQueryable();
		}
	}

	public PackageContext(IServerPackageRepository repository, Func<IEnumerable<ElmaPackageInfo>> installedPackagesFunc)
	{
		_repository = repository;
		_installedPackagesFunc = installedPackagesFunc;
	}
}
