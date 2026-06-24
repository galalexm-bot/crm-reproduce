using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace EleWise.ELMA.Packaging.Components.UpdatingWeb;

[Export(typeof(UpdatingWebComponent))]
[Export(typeof(IElmaComponent))]
public class UpdatingWebComponent : ElmaComponent
{
	public const string ID = "UpdatingWeb";

	public override string Id => "UpdatingWeb";

	public override string Name => SR.T("Веб-сайт с информацией об обновлении");

	public override string RootPackageId => "EleWise.ELMA.Packaging.UpdatingWeb";

	protected override string RelativeComponentRoot => "UpdatingWeb";

	public override void Start()
	{
	}

	public override void Stop()
	{
	}

	public override void Pause()
	{
	}

	public override bool IsStarted()
	{
		return false;
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new UpdatingWebProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[1]
		{
			new UpdatingWebFolder(this)
		};
	}
}
