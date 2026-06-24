using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging.Internal.NuGet;

internal class ReadOnlyZipPackageFile : IPackageFile, IFrameworkTargetable
{
	private readonly string packagePhysicalPath;

	public string Path { get; private set; }

	public string EffectivePath { get; private set; }

	public FrameworkName TargetFramework { get; private set; }

	public IEnumerable<FrameworkName> SupportedFrameworks
	{
		get
		{
			if (!(TargetFramework != null))
			{
				return Enumerable.Empty<FrameworkName>();
			}
			return new FrameworkName[1] { TargetFramework };
		}
	}

	public ReadOnlyZipPackageFile(string packagePhysicalPath, string partPath)
	{
		Path = partPath;
		string effectivePath = default(string);
		TargetFramework = VersionUtility.ParseFrameworkNameFromFilePath(partPath, ref effectivePath);
		EffectivePath = effectivePath;
		this.packagePhysicalPath = packagePhysicalPath;
	}

	public Stream GetStream()
	{
		return new ReadOnlyZipStream(packagePhysicalPath, Path);
	}
}
