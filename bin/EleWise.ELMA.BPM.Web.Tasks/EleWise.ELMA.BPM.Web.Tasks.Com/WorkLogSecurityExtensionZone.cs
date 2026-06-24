using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 300)]
public class WorkLogSecurityExtensionZone : IExtensionZone
{
	public const string ZoneId = "EleWise.ELMA.Security-TaskPersonalEditor";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return "EleWise.ELMA.Security-TaskPersonalEditor" == zoneId;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006c: Expected O, but got Unknown
		if ("EleWise.ELMA.Security-TaskPersonalEditor" == zoneId)
		{
			TaskControlSettingsModel taskControlSettingsModel = ((html.get_ViewData().get_Model() is IUser user) ? PersonalizationAdministration.LoadState<TaskControlSettingsModel>(user.UserName, "UserTaskControlSettings") : null);
			if (taskControlSettingsModel == null)
			{
				taskControlSettingsModel = new TaskControlSettingsModel
				{
					AutomaticSendingOfWorkLog = false
				};
			}
			TaskControlSettingsModel taskControlSettingsModel2 = taskControlSettingsModel;
			ViewDataDictionary val = new ViewDataDictionary();
			TemplateInfo val2 = new TemplateInfo();
			val2.set_HtmlFieldPrefix("Settings.TaskControlSettings");
			val.set_TemplateInfo(val2);
			RenderPartialExtensions.RenderPartial(html, "Security/WorkLogControlSettingsEditor", (object)taskControlSettingsModel2, val);
		}
	}
}
