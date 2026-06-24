using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Tasks.ExtensionPoints.API;

public abstract class TaskUpdatePackageServiceBase : IUpdatePackageService
{
	public abstract string ServiceName { get; }

	public abstract Guid ServiceUid { get; }

	public abstract IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider);

	public IEnumerable<PackageBase> CreatePackages(DateTime date)
	{
		yield break;
	}

	public PackageBase[] ConvertPackages(UpdateIdPackage[] updateIdPackages)
	{
		return null;
	}

	public bool PackagesCommit(DateTime serverTime, DateTime now, PackageBase[] packages)
	{
		return true;
	}

	public bool Sync(DateTime now, PackageChangesSyncData[] changes)
	{
		return true;
	}
}
