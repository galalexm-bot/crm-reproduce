using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using NuGet;

namespace EleWise.ELMA.Packaging.Internal.NuGet;

internal class ReadOnlyZipAssemblyReference : IPackageAssemblyReference, IPackageFile, IFrameworkTargetable
{
	private readonly IPackageFile file;

	public string Name => System.IO.Path.GetFileName(Path);

	public string Path => file.get_Path();

	public string EffectivePath => file.get_EffectivePath();

	public FrameworkName TargetFramework => file.get_TargetFramework();

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

	public ReadOnlyZipAssemblyReference(IPackageFile file)
	{
		this.file = file;
	}

	public Stream GetStream()
	{
		return file.GetStream();
	}
}
