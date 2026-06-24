using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

internal sealed class CreateTaskProfileToobarButton : ActionToolbarItem
{
	public const string GUID = "Tasks_CreateTaskUserProfileToobarButton";

	public const string CREATETASK_GUID = "Tasks_CreateTaskUserProfileToobarButton_Task";

	public CreateTaskProfileToobarButton(HtmlHelper htmlHelper)
		: base("Tasks_CreateTaskUserProfileToobarButton")
	{
		IsMainAction = true;
		UrlHelper val = htmlHelper.Url();
		Text = SR.Create;
		IconUrl = "#add.svg";
		IUser userFromModel = htmlHelper.GetUserFromModel();
		if (userFromModel != null)
		{
			Items.Add(new ActionToolbarItem("Tasks_CreateTaskUserProfileToobarButton_Task")
			{
				Text = SR.T("Задачу"),
				IconUrl = "#add_task.svg",
				Url = val.Action("Create", "Task", new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
					{ "idUsers[0]", userFromModel.Id }
				})
			});
		}
	}
}
