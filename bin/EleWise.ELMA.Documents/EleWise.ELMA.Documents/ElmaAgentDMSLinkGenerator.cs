namespace EleWise.ELMA.Documents;

public static class ElmaAgentDMSLinkGenerator
{
	public enum DMSVerion
	{
		ReadOnly,
		Edit,
		BlockEdit,
		New,
		NewScan,
		BlockNew
	}

	public enum DMSVersionSetting
	{
		Edit = 2,
		New = 4,
		EditAndBlock = 6,
		NewAndBlock = 8
	}

	public const string DmsLinkStart = "elmadms:";

	private const string DmsVerBlockEdit = "vedbl";

	private const string DmsVerEdit = "ved";

	private const string DmsVerNew = "vnew";

	private const string DmsVerNewScan = "newscan";

	private const string DmsVerReadOnly = "vro";

	private const string DmsVerSeparator = "&";

	private const string DmsVerNewBlock = "vnewbl";

	public const string DmsVerSet = "=";

	private static string GetCommandText(DMSVerion command)
	{
		string result = "";
		switch (command)
		{
		case DMSVerion.ReadOnly:
			result = "vro";
			break;
		case DMSVerion.Edit:
			result = "ved";
			break;
		case DMSVerion.BlockEdit:
			result = "vedbl";
			break;
		case DMSVerion.New:
			result = "vnew";
			break;
		case DMSVerion.NewScan:
			result = "newscan";
			break;
		case DMSVerion.BlockNew:
			result = "vnewbl";
			break;
		}
		return result;
	}

	public static string GetActionName(DMSVersionSetting dmsVersionSetting)
	{
		return dmsVersionSetting switch
		{
			DMSVersionSetting.Edit => SR.T("Редактировать"), 
			DMSVersionSetting.New => SR.T("Новая версия"), 
			DMSVersionSetting.EditAndBlock => SR.T("Блокировать и изменить"), 
			DMSVersionSetting.NewAndBlock => SR.T("Блокировать и создать"), 
			_ => string.Empty, 
		};
	}

	public static string GetVersionLink(long version, DMSVerion mode)
	{
		return GetVersionLink(version.ToString(), mode);
	}

	public static string GetVersionLink(string linkStart, long version, DMSVerion mode)
	{
		string text = "";
		text = ((!string.IsNullOrEmpty(linkStart)) ? (linkStart + "&") : "elmadms:");
		text += GetCommandText(mode);
		return text + "=" + version;
	}

	public static string GetVersionLink(string version, DMSVerion mode)
	{
		string text = "elmadms:";
		text += GetCommandText(mode);
		if (!string.IsNullOrEmpty(version))
		{
			text = text + "=" + version;
		}
		return text;
	}

	public static string GetBlankVersionLink(DMSVerion mode)
	{
		return string.Concat("elmadms:" + GetCommandText(mode), "=");
	}
}
