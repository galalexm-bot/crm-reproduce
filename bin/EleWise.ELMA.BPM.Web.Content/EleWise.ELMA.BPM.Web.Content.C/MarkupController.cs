using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.BPM.Web.Content.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class MarkupController : BPMController
{
	public PortletManager PortletManager { get; set; }

	[Permission("7EAF9677-6CC3-4E17-A4F6-0B69CC983F22")]
	public ActionResult EditPortlet(string path, Guid instanceId, PersonalizationScope scope)
	{
		string markupText = (((CustomMarkupPortletPersonalization)PortletManager.Create(scope, path).GetPersonalization(CustomMarkupPortlet.UID, instanceId, path)) ?? throw new InvalidOperationException(SR.T("Портлет был удален или нет прав на его редактирование"))).MarkupText;
		return (ActionResult)(object)((Controller)this).View("Edit", (object)new MarkupEditorModel
		{
			PreviewUrl = ((Controller)this).get_Url().Action("PreviewPortlet", "Markup", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				path = path,
				scope = scope,
				instanceId = instanceId
			}),
			Markup = markupText,
			SaveUrl = ((Controller)this).get_Url().Action("SavePortlet", "Markup", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				path = path,
				scope = scope,
				instanceId = instanceId
			})
		});
	}

	[Permission("7EAF9677-6CC3-4E17-A4F6-0B69CC983F22")]
	[HttpPost]
	public ActionResult PreviewPortlet(string path, Guid instanceId, PersonalizationScope scope, string markup)
	{
		PortletViewModel portletViewModel = (from m in PortletManager.Create(scope, path).GetAllPortlets(path)
			where m.Personalization.InstanceId == instanceId
			select m).FirstOrDefault();
		if (portletViewModel == null)
		{
			throw new InvalidOperationException(SR.T("Портлет был удален или нет прав на его редактирование"));
		}
		((CustomMarkupPortletPersonalization)portletViewModel.Personalization).MarkupText = markup;
		return (ActionResult)(object)((Controller)this).PartialView("PreviewPortlet", (object)portletViewModel);
	}

	[Permission("7EAF9677-6CC3-4E17-A4F6-0B69CC983F22")]
	[HttpPost]
	public ActionResult SavePortlet(string path, Guid instanceId, PersonalizationScope scope, string markup)
	{
		PortletManager portletManager = PortletManager.Create(scope, path);
		CustomMarkupPortletPersonalization customMarkupPortletPersonalization = (CustomMarkupPortletPersonalization)portletManager.GetPersonalization(CustomMarkupPortlet.UID, instanceId, path);
		if (customMarkupPortletPersonalization == null)
		{
			throw new InvalidOperationException(SR.T("Портлет был удален или нет прав на его редактирование"));
		}
		customMarkupPortletPersonalization.MarkupText = markup;
		portletManager.SavePersonalization(customMarkupPortletPersonalization, path);
		base.Notifier.Information(SR.T("Изменения сохранены"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("EditPortlet", "Markup", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content",
			path = path,
			scope = scope,
			instanceId = instanceId
		});
	}
}
