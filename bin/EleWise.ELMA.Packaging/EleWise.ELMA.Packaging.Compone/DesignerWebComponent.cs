using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Packaging.Components.Web;
using NuGet;

namespace EleWise.ELMA.Packaging.Components.DesignerWeb;

[Export(typeof(DesignerWebComponent))]
[Export(typeof(IElmaComponent))]
public class DesignerWebComponent : ElmaComponent
{
	public const string ID = "DesignerWeb";

	private WebComponent _webComponent;

	[Import]
	public WebComponent WebComponent
	{
		get
		{
			return _webComponent.GetPropertyNotNull("WebComponent");
		}
		set
		{
			_webComponent = value;
		}
	}

	public override string Id => "DesignerWeb";

	public override string Name => SR.T("Веб-часть для дизайнера");

	public override string RootPackageId => "EleWise.ELMA.BPM";

	protected override string RelativeComponentRoot => "Designer\\Web";

	public override void Install(IEnumerable<string> packages)
	{
		if ((packages == null || !packages.Any()) && base.Helper.LocalRepository != null)
		{
			packages = base.Helper.LocalRepository.GetPackages().Where((Expression<Func<IPackage, bool>>)((IPackage p) => new ElmaPackageMetadata(((IPackageMetadata)p).get_Tags()).Default)).Select((Expression<Func<IPackage, string>>)((IPackage p) => ((IPackageName)p).get_Id()))
				.ToArray();
		}
		base.Install(packages);
	}

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new WebProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[2]
		{
			new WebFolder(this),
			new WebModuleFolder(this)
		};
	}

	public override bool IsCompatible(ElmaPackageMetadata metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (!metadata.Components.Any() || metadata.Components.Any((string c) => c.Equals("Web", StringComparison.CurrentCultureIgnoreCase)))
		{
			return metadata.IsCompatible(base.Settings.Edition);
		}
		return false;
	}
}
