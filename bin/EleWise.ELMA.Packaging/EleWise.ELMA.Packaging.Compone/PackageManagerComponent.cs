using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace EleWise.ELMA.Packaging.Components.PackageManager;

[Export(typeof(PackageManagerComponent))]
[Export(typeof(IElmaComponent))]
public class PackageManagerComponent : ElmaComponent
{
	public const string ID = "PackageManager";

	public override string Id => "PackageManager";

	public override string Name => SR.T("Менеджер пакетной системы");

	public override string RootPackageId => "EleWise.ELMA.Packaging.Manager";

	protected override string RelativeComponentRoot => "PackageManager";

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new PackageManagerProjectSystem(this)
		{
			UseSafeRemove = true
		};
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[1]
		{
			new PackageManagerFolder(this)
		};
	}
}
