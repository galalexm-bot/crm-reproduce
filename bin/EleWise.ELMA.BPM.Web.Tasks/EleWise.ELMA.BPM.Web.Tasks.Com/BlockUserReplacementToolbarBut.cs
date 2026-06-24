using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 30)]
internal sealed class BlockUserReplacementToolbarButton : IActionItemProvider
{
	private const string ReplacementPopupId = "CreateBlockUserReplacementTask";

	private const string CreateTaskReplacementUid = "createTaskReplacement";

	private readonly ReplacementTaskManager replacementTaskManager;

	public BlockUserReplacementToolbarButton(ReplacementTaskManager replacementTaskManager)
	{
		this.replacementTaskManager = replacementTaskManager;
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		IUser userFromModel = htmlHelper.GetUserFromModel();
		if (userFromModel == null || userFromModel.Status != UserStatus.Blocked || replacementTaskManager.GetCountBlockUserTasksForUser(userFromModel) > 0)
		{
			return null;
		}
		string url = htmlHelper.Url().Action("CreateBlockUserReplacementTask", "ReplacementTask", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			id = userFromModel.Id
		});
		return new IActionItem[1]
		{
			new ActionToolbarItem("createTaskReplacement")
			{
				Text = SR.T("Создать задачу назначения заместителей"),
				IconUrl = "#add.svg",
				Click = ((object)htmlHelper.RefreshPopup("CreateBlockUserReplacementTask", url)).ToString(),
				OnRender = delegate(HtmlHelper html)
				{
					html.RegisterContent("CreateReplacementPopup", (dynamic d) => html.PopupWindow("CreateBlockUserReplacementTask", SR.T("Создание задачи назначения заместителей")));
				}
			}
		};
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
