using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Buttons;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 1)]
public class AddQuestionToCalendarEventButton : IActionItemProvider
{
	public const string ADDQUESTIONBUTTON_GUID = "AddQuestionToEventButton";

	public const string AddCommentGuid = "add-comment";

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || (rootItem != null && (rootItem.Uid != "DefaultActionsToolbar" || !rootItem.Items.Any((IActionItem item) => item is ActionToolbarGroup && item.Uid == "MoreButtonToolbarGroup"))) || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") is ActionToolbarGroup actionToolbarGroup))
		{
			return;
		}
		IActionItem buttons = actionToolbarGroup.Items.FirstOrDefault((IActionItem i) => i.Uid == "more_btn");
		if (buttons == null)
		{
			return;
		}
		IEnumerable<IActionItem> items = GetItems(rootItem, htmlHelper);
		int j;
		for (j = 0; j < buttons.Items.Count; j++)
		{
			if (buttons.Items[j].Uid == "add-comment")
			{
				items.ForEach(delegate(IActionItem a)
				{
					buttons.Items.Insert(j + 1, a);
				});
				break;
			}
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		ICalendarEvent calendarEvent = null;
		long id = 0L;
		IMetadata metadata = null;
		try
		{
			id = long.Parse((string)((ControllerContext)htmlHelper.get_ViewContext()).get_RouteData().Values["id"]);
			calendarEvent = CalendarEventManager.Instance.LoadOrNull(id);
			if (calendarEvent == null)
			{
				yield break;
			}
			metadata = MetadataLoader.LoadMetadata(calendarEvent.GetType());
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message);
		}
		if (calendarEvent == null || metadata == null)
		{
			yield break;
		}
		IActionItem actionItem = new ContentAction
		{
			Id = "AddQuestionToEventButton",
			DescriptionForLocalization = SR.M("Задать вопрос по поводу текущего события"),
			Image24 = "#help.svg",
			NameForLocalization = SR.M("Задать вопрос"),
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.OpenPopup("AddQuestionToEvent")).ToString().PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("AddQuestionToEventPopup", (dynamic d) => html.AddQuestionPopup(new QuestionModel
				{
					PopupId = "AddQuestionToEvent",
					ObjectId = id,
					ObjectTypeUid = metadata.Uid,
					AddQuestionActionUid = CalendarEventActions.AddQuestionGuid,
					RedirectUrl = html.Url().Action("View", "Event", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Calendar",
						id = id,
						selectedTab = "History"
					})
				}));
			}
		}.CreateButton(htmlHelper);
		actionItem.Uid = "AddQuestionToEventButton";
		yield return actionItem;
	}
}
