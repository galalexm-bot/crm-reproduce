using System.Collections.Generic;
using System.ComponentModel.Composition;
using NuGet;

namespace EleWise.ELMA.Packaging.Components.SSPI;

[Export(typeof(SSPIComponent))]
[Export(typeof(IElmaComponent))]
public class SSPIComponent : ElmaComponent
{
	public const string ID = "SSPI";

	public override string Id => "SSPI";

	public override string Name => SR.T("SSPI");

	public override string RootPackageId => "EleWise.ELMA.SSPI.Web";

	protected override string RelativeComponentRoot => "Web\\SSPI";

	public override void Install(IEnumerable<string> packages)
	{
		if (PackageRepositoryExtensions.FindPackage(base.Helper.LocalRepository, RootPackageId) != null)
		{
			base.Install(packages);
		}
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new SSPIProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[1]
		{
			new SSPIFolder(this)
		};
	}
}
