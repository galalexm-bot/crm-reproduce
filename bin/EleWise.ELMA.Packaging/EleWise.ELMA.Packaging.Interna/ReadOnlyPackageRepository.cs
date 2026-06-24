using System.IO;
using NuGet;

namespace EleWise.ELMA.Packaging.Internal.NuGet;

internal class ReadOnlyPackageRepository : LocalPackageRepository
{
	public ReadOnlyPackageRepository(string physicalPath)
		: base(physicalPath)
	{
	}

	protected override IPackage CreatePackage(string path)
	{
		return (IPackage)(object)new ReadOnlyZipPackage(Path.Combine(((PackageRepositoryBase)this).get_Source(), path));
	}
}
