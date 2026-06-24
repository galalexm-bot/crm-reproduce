using NuGet;

namespace EleWise.ELMA.Packaging;

public class ElmaPackageInfo : PackageInfo
{
	public ElmaPackageMetadata ElmaMetadata { get; set; }

	public ElmaPackageInfo()
	{
	}

	public ElmaPackageInfo(IPackage package)
		: base(((IPackageName)package).get_Id(), ((IPackageName)package).get_Version())
	{
		ElmaMetadata = new ElmaPackageMetadata(((IPackageMetadata)package).get_Tags());
	}
}
