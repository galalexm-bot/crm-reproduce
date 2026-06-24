using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = 20)]
internal sealed class ChangeCalendarToolbarButton : IActionItemProvider
{
	private const string ChangeCalendarUid = "changeCalendarUid";

	private readonly ISecurityService securityService;

	public ChangeCalendarToolbarButton(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (securityService.HasPermission(EleWise.ELMA.Calendar.PermissionProvider.ProductionSchedulePermission))
		{
			EleWise.ELMA.Security.Models.IUser userFromModel = htmlHelper.GetUserFromModel();
			if (userFromModel != null)
			{
				yield return new ActionToolbarItem("changeCalendarUid")
				{
					Text = SR.T("Изменить календарь"),
					IconUrl = "#change.svg",
					Url = htmlHelper.Url().Action("EditUserSetting", "ProductionSchedule", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Calendar",
						userId = userFromModel.Id
					})
				};
			}
		}
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar" || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup") is ActionToolbarGroup) || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") is ActionToolbarGroup actionToolbarGroup))
		{
			return;
		}
		IActionItem additionalButton = actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "more_btn");
		if (additionalButton != null)
		{
			GetItems(additionalButton, htmlHelper).ForEach(delegate(IActionItem item)
			{
				additionalButton.Items.Add(item);
			});
		}
	}
}
