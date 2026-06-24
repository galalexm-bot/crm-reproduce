using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IUpdatePackageService
{
	string ServiceName { get; }

	Guid ServiceUid { get; }

	IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider);

	IEnumerable<PackageBase> CreatePackages(DateTime date);

	PackageBase[] ConvertPackages(UpdateIdPackage[] updateIdPackages);

	bool PackagesCommit(DateTime serverTime, DateTime now, PackageBase[] packages);

	bool Sync(DateTime now, PackageChangesSyncData[] changes);
}
