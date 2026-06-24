namespace EleWise.ELMA.Packaging.Components.PackageManager;

public class PackageManagerFolder : ElmaMappedFolder
{
	protected override string SourcePath => "ELMA\\PackageManager\\";

	protected override string TargetPath => "";

	protected override bool DeleteEmptyDirs => false;

	public PackageManagerFolder(IElmaComponent component)
		: base(component)
	{
	}
}
