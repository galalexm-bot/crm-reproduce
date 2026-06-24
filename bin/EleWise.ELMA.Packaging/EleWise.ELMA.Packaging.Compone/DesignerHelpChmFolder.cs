namespace EleWise.ELMA.Packaging.Components.Designer;

public class DesignerHelpChmFolder : ElmaMappedFolder
{
	public const string HelpChmSourcePath = "ELMA\\HelpChm";

	protected override string SourcePath => "ELMA\\HelpChm\\";

	protected override string TargetPath => "Help";

	public DesignerHelpChmFolder(IElmaComponent component)
		: base(component)
	{
	}
}
