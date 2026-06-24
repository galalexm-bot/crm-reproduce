using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.vCard.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false)]
public class AddLeadBtn : IActionItemProvider
{
	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (htmlHelper.get_ViewData().get_Model() is LeadModel leadModel)
		{
			yield return new ActionToolbarItem
			{
				Url = htmlHelper.Url().Action("GetForLead", "VcardCRM", (object)new
				{
					area = "EleWise.ELMA.vCard.Web",
					id = leadModel.Entity.Uid
				}),
				IconUrl = "#vCard.svg",
				Text = SR.T("Экспорт  vCard")
			};
		}
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar" || !(htmlHelper.get_ViewData().get_Model() is LeadModel) || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "toolbar-group-2") is ActionToolbarGroup actionToolbarGroup) || !(actionToolbarGroup.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "toolbar-button-Actions") is ActionToolbarItem))
		{
			return;
		}
		IActionItem moreButton = rootItem.Items.FirstOrDefault((IActionItem i) => i.Uid == "MoreButtonToolbarGroup")?.Items?.FirstOrDefault((IActionItem i) => i.Uid == "more_btn");
		if (moreButton == null)
		{
			return;
		}
		IActionItem actionItem = moreButton.Items.FirstOrDefault((IActionItem i) => i.Uid == "Lead_delete_btn");
		if (actionItem != null)
		{
			int index = moreButton.Items.IndexOf(actionItem);
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				moreButton.Items.Insert(index, item);
			});
		}
		else
		{
			GetItems(rootItem, htmlHelper).ForEach(delegate(IActionItem item)
			{
				moreButton.Items.Add(item);
			});
		}
	}
}
