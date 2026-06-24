namespace EleWise.ELMA.Packaging.Components.Designer.Settings;

public class DesignerComponentSettings : ElmaComponentSettings
{
	public ShortcutInfo StartMenuShortcut { get; set; }

	public ShortcutInfo DesktopShortcut { get; set; }

	public static DesignerComponentSettings Load(string fileName)
	{
		return ElmaComponentSettings.Load<DesignerComponentSettings>(fileName);
	}
}
