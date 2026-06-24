using NuGet;

namespace EleWise.ELMA.Packaging;

public class PackageInfo
{
	public string Id { get; set; }

	public SemanticVersion Version { get; set; }

	public IPackage Package { get; set; }

	public PackageInfo()
	{
	}

	public PackageInfo(string id)
	{
		Id = id;
	}

	public PackageInfo(string id, SemanticVersion version)
		: this(id)
	{
		Version = version;
	}

	public override string ToString()
	{
		return Id + ((Version != (SemanticVersion)null) ? (" " + Version) : "");
	}
}
