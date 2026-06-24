namespace EleWise.ELMA.Packaging.Components.Web;

public class WebFolder : ElmaMappedFolder
{
	public static readonly string[] TemporaryPaths = new string[5] { "App_Data\\Dependencies", "App_Data\\DesignerInstaller", "App_Data\\Precompiled", "App_Data\\Proxies", "App_Data\\XmlSerializers" };

	protected override string SourcePath => "ELMA\\Web\\";

	protected override string TargetPath => "";

	public WebFolder(IElmaComponent component)
		: base(component)
	{
	}
}
