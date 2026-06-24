using System.ComponentModel;

namespace EleWise.ELMA.Packaging.Components.Web.Settings;

public class WebComponentSettings : ElmaComponentSettings
{
	[DefaultValue(HostingType.None)]
	public HostingType HostingType { get; set; }

	public IISHostingSettings IISHosting { get; set; }

	public ShortcutInfo StartMenuShortcut { get; set; }

	public ShortcutInfo DesktopShortcut { get; set; }

	public WebComponentSettings()
	{
		IISHosting = new IISHostingSettings();
	}

	public static WebComponentSettings Load(string fileName)
	{
		return ElmaComponentSettings.Load<WebComponentSettings>(fileName);
	}

	public override void InitByDefault()
	{
		HostingType = HostingType.InternalServer;
	}
}
