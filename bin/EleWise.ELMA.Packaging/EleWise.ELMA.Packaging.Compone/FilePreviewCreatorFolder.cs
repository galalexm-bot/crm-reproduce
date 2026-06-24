namespace EleWise.ELMA.Packaging.Components.FilePreviewCreator;

public class FilePreviewCreatorFolder : ElmaMappedFolder
{
	protected override string SourcePath => "ELMA\\FilePreviewCreator\\";

	protected override string TargetPath => "";

	public FilePreviewCreatorFolder(IElmaComponent component)
		: base(component)
	{
	}
}
