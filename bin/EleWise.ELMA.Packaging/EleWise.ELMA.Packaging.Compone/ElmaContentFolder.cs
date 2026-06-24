namespace EleWise.ELMA.Packaging.Components;

public class ElmaContentFolder : ElmaMappedFolder
{
	protected override string SourcePath => "ELMA\\Content\\";

	protected override string TargetPath => "";

	public ElmaContentFolder(IElmaComponent component)
		: base(component)
	{
	}
}
