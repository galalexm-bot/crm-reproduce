using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class TaskViewForm : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.BPM.Web.Tasks.ViewForm-Right" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zones.Contains(zoneId) && html.get_ViewData().get_Model() is TaskViewModel taskViewModel && taskViewModel.Entity is ICRMTaskBase iCRMTaskBase)
		{
			if (iCRMTaskBase.Contractor != null)
			{
				html.get_ViewContext().get_Writer().Write(html.Property("Entity.Contractor"));
			}
			if (iCRMTaskBase.Contact != null)
			{
				html.get_ViewContext().get_Writer().Write(html.Property("Entity.Contact"));
			}
			if (iCRMTaskBase.Lead != null)
			{
				html.get_ViewContext().get_Writer().Write(html.Property("Entity.Lead"));
			}
			if (iCRMTaskBase.Sale != null)
			{
				html.get_ViewContext().get_Writer().Write(html.Property("Entity.Sale"));
			}
		}
	}
}
