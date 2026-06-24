using EleWise.ELMA.Packaging.Server.DataServices;
using NuGet;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

public interface IServerPackageRepository : IServiceBasedRepository, IPackageRepository
{
	void RemovePackage(string packageId, SemanticVersion version);

	Package GetMetadataPackage(IPackage package);
}
