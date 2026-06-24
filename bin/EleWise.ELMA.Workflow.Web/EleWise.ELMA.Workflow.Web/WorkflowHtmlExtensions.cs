using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Workflow.Web;

public static class WorkflowHtmlExtensions
{
	public static void AddCommentTab(this HtmlHelper html, TabPanelItemsBuilder tabs, int count, int selectedTab, long id)
	{
		TabPanelItem tabPanelItem = new TabPanelItem();
		((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(SR.T("Комментарии"));
		((TabStripItem)tabPanelItem).set_Counter((long?)count);
		((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Selected(selectedTab == 1);
		((TabStripItem)tabPanelItem).set_ContentUrl(html.Url().Action("Comments", "WorkflowTask", (object)new
		{
			area = "EleWise.ELMA.Workflow.Web",
			taskId = id
		}));
		tabs.Add(tabPanelItem);
	}

	public static void AddQuestionTab(this HtmlHelper html, TabPanelItemsBuilder tabs, int count, int selectedTab, long id)
	{
		TabPanelItem tabPanelItem = new TabPanelItem();
		((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(SR.T("Вопросы"));
		((TabStripItem)tabPanelItem).set_Counter((long?)count);
		((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Selected(selectedTab == 2);
		((TabStripItem)tabPanelItem).set_ContentUrl(html.Url().Action("Questions", "WorkflowTask", (object)new
		{
			area = "EleWise.ELMA.Workflow.Web",
			taskId = id
		}));
		tabs.Add(tabPanelItem);
	}
}
