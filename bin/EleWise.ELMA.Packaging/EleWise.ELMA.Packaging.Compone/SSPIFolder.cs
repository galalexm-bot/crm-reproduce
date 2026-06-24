namespace EleWise.ELMA.Packaging.Components.SSPI;

public class SSPIFolder : ElmaMappedFolder
{
	protected override string SourcePath => "ELMA\\SSPI\\";

	protected override string TargetPath => "";

	public SSPIFolder(IElmaComponent component)
		: base(component)
	{
	}
}
