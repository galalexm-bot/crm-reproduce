namespace EleWise.ELMA.Packaging.Components.Designer;

public class DesignerFolder : ElmaMappedFolder
{
	protected override string SourcePath => "ELMA\\Designer\\";

	protected override string TargetPath => "";

	public DesignerFolder(IElmaComponent component)
		: base(component)
	{
	}
}
