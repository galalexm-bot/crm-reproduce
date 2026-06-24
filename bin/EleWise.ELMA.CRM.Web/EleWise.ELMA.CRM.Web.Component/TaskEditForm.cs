using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class TaskEditForm : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.BPM.Web.Tasks.EditForm" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006d: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0095: Expected O, but got Unknown
		if (zones.Contains(zoneId) && html.get_ViewData().get_Model() is TaskModel taskModel && taskModel.Entity is ICRMTaskBase iCRMTaskBase)
		{
			if (Locator.GetServiceNotNull<CrmSettingsModule>().Settings.Tasks_AllowSelectEntity)
			{
				ViewDataDictionary val = new ViewDataDictionary();
				TemplateInfo val2 = new TemplateInfo();
				val2.set_HtmlFieldPrefix("Entity");
				val.set_TemplateInfo(val2);
				RenderPartialExtensions.RenderPartial(html, "TaskEntitySelector", (object)iCRMTaskBase, val);
			}
			else
			{
				ViewDataDictionary val3 = new ViewDataDictionary();
				TemplateInfo val4 = new TemplateInfo();
				val4.set_HtmlFieldPrefix("Entity");
				val3.set_TemplateInfo(val4);
				RenderPartialExtensions.RenderPartial(html, "TaskEntityDisplay", (object)iCRMTaskBase, val3);
			}
		}
	}
}
