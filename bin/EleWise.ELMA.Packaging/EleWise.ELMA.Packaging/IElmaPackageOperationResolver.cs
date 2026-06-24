using System.Collections.Generic;
using NuGet;

namespace EleWise.ELMA.Packaging;

internal interface IElmaPackageOperationResolver : IPackageOperationResolver
{
	IEnumerable<PackageOperation> ResolveOperations(IEnumerable<IPackage> packages);
}
