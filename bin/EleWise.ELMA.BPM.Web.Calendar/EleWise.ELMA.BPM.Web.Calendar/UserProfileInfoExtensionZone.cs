using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = -250)]
internal class UserProfileInfoExtensionZone : IExtensionZone
{
	public const string ZoneId = "EleWise.ELMA.BPM.Web.Security.Profile.ProfileCommonInfo";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return "EleWise.ELMA.BPM.Web.Security.Profile.ProfileCommonInfo" == zoneId;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if ("EleWise.ELMA.BPM.Web.Security.Profile.ProfileCommonInfo" == zoneId && html.get_ViewData().get_Model() is UserModel userModel && userModel.User != null)
		{
			IResourceCalendar byUser = ResourceCalendarManager.Instance.GetByUser(userModel.User);
			RenderPartialExtensions.RenderPartial(html, "Security/ProductionScheduleInfo", (object)byUser);
		}
	}
}
