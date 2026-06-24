using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component(Order = 100)]
public class SecurityExtensionZone : IExtensionZone
{
	public const string ZoneId = "EleWise.ELMA.Security-TaskPersonalEditor";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return "EleWise.ELMA.Security-TaskPersonalEditor" == zoneId;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0065: Expected O, but got Unknown
		if ("EleWise.ELMA.Security-TaskPersonalEditor" == zoneId)
		{
			WorkflowTasksSettingsModel workflowTasksSettingsModel = ((html.get_ViewData().get_Model() is IUser user) ? PersonalizationAdministration.LoadState<WorkflowTasksSettingsModel>(user.UserName, "UserWorkflowTasksSettings") : null);
			if (workflowTasksSettingsModel == null)
			{
				workflowTasksSettingsModel = new WorkflowTasksSettingsModel();
			}
			WorkflowTasksSettingsModel workflowTasksSettingsModel2 = workflowTasksSettingsModel;
			ViewDataDictionary val = new ViewDataDictionary();
			TemplateInfo val2 = new TemplateInfo();
			val2.set_HtmlFieldPrefix("Settings.Tasks");
			val.set_TemplateInfo(val2);
			RenderPartialExtensions.RenderPartial(html, "Security/WorkflowTasksSettingsEditor", (object)workflowTasksSettingsModel2, val);
		}
	}
}
