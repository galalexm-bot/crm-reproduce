using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(Order = -750)]
public class UserProfileInfoExtensionZone : IExtensionZone
{
	private const string ProfileCommonInfoZoneId = "EleWise.ELMA.BPM.Web.Security.Profile.ProfileCommonInfo";

	private const string ProfileSimpleInfoZoneId = "EleWise.ELMA.BPM.Web.Security.Profile.SimpleProfileInfo";

	private const string ProfileEditorZoneId = "EleWise.ELMA.BPM.Web.Security.ProfileEditor.Table";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		if (!(zoneId == "EleWise.ELMA.BPM.Web.Security.Profile.ProfileCommonInfo") && !(zoneId == "EleWise.ELMA.BPM.Web.Security.ProfileEditor.Table"))
		{
			return zoneId == "EleWise.ELMA.BPM.Web.Security.Profile.SimpleProfileInfo";
		}
		return true;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.BPM.Web.Security.Profile.ProfileCommonInfo" || zoneId == "EleWise.ELMA.BPM.Web.Security.Profile.SimpleProfileInfo")
		{
			RenderPartialExtensions.RenderPartial(html, "WorkPlace/UserProfileInfo");
		}
		if (zoneId == "EleWise.ELMA.BPM.Web.Security.ProfileEditor.Table")
		{
			RenderPartialExtensions.RenderPartial(html, "WorkPlace/UserProfileEdit");
		}
	}
}
