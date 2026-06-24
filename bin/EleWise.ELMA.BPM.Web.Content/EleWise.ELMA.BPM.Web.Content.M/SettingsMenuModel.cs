namespace EleWise.ELMA.BPM.Web.Content.Models;

public sealed class SettingsMenuModel
{
	public string Url { get; set; }

	public string Click { get; set; }

	public string Text { get; set; }

	public string IconUrl { get; set; }

	public SettingsMenuModel(string url, string click, string text, string iconUrl)
	{
		Url = url;
		Click = click;
		Text = text;
		IconUrl = iconUrl;
	}
}
