namespace EleWise.ELMA.Packaging.Components.Web;

public class WebModuleFolder : ElmaMappedFolder
{
	public const string WebModuleSourcePath = "ELMA\\WebModule";

	public const string WebModuleTargetPath = "Modules";

	public static readonly string[] TemporaryPaths = new string[1] { "App_Data\\Precompiled" };

	protected override string SourcePath => "ELMA\\WebModule\\";

	protected override string TargetPath => "Modules\\";

	public WebModuleFolder(IElmaComponent component)
		: base(component)
	{
	}
}
