using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;

namespace EleWise.ELMA.Packaging.Components.FilePreviewCreator;

[Export(typeof(FilePreviewCreatorComponent))]
[Export(typeof(IElmaComponent))]
public class FilePreviewCreatorComponent : ElmaComponent
{
	public const string ID = "FilePreviewCreator";

	public override string Id => "FilePreviewCreator";

	public override string Name => SR.T("Внешний генератор файлов предпросмотра");

	public override string RootPackageId => "";

	protected override string RelativeComponentRoot => "FilePreviewCreator";

	protected override IElmaProjectSystem CreateProjectSystem()
	{
		return new FilePreviewCreatorProjectSystem(this);
	}

	protected override IEnumerable<IElmaFolder> CreateFolders()
	{
		return new IElmaFolder[1]
		{
			new FilePreviewCreatorFolder(this)
		};
	}

	public override bool IsInstalled()
	{
		return Directory.Exists(ComponentRoot);
	}
}
