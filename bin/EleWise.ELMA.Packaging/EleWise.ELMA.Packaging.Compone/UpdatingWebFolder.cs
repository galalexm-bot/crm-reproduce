namespace EleWise.ELMA.Packaging.Components.UpdatingWeb;

public class UpdatingWebFolder : ElmaMappedFolder
{
	protected override string SourcePath => "ELMA\\UpdatingWeb\\";

	protected override string TargetPath => "";

	public UpdatingWebFolder(IElmaComponent component)
		: base(component)
	{
	}
}
