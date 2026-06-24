using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypeToolbarItem : ActionItemType
{
	public static readonly Guid Guid = new Guid("{54E70DE1-A0FA-4183-BA2B-C288E794F023}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		if (!(actionItem is ActionToolbarItem actionToolbarItem) || !actionToolbarItem.Visible)
		{
			return;
		}
		IContentActionRegistry serviceNotNull = Locator.GetServiceNotNull<IContentActionRegistry>();
		if (!string.IsNullOrWhiteSpace(actionToolbarItem.ActionTypeProviderId) && !string.IsNullOrWhiteSpace(actionToolbarItem.ActionId))
		{
			IContentAction contentAction = serviceNotNull.Get(actionToolbarItem.ActionTypeProviderId, actionToolbarItem.ActionId);
			if (contentAction != null)
			{
				actionToolbarItem.Url = contentAction.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext());
				contentAction.OnRender(htmlHelper);
			}
		}
		if (actionToolbarItem.Items.Any())
		{
			MvcHtmlString val = htmlHelper.ActionMenu(new ActionMenu(actionToolbarItem.Uid)
			{
				Items = GetMenuItems(actionToolbarItem.Items, serviceNotNull, htmlHelper)
			});
			builder.Append(((HtmlString)(object)val).ToHtmlString());
		}
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/ActionToolbar/ToolbarItem", (object)actionItem));
	}

	private ActionItemList GetMenuItems(IActionItemList list, IContentActionRegistry contentActionRegistry, HtmlHelper htmlHelper)
	{
		ActionItemList actionItemList = new ActionItemList();
		foreach (IActionItem item in list)
		{
			ActionToolbarItem actionToolbarItem = item as ActionToolbarItem;
			if (!(item is ActionMenuItem actionMenuItem) || actionToolbarItem == null)
			{
				continue;
			}
			if (actionMenuItem.Type == ActionItemType.ToolbarItemSeparator)
			{
				actionMenuItem.Type = ActionItemType.MenuSeparator;
			}
			else
			{
				actionMenuItem.Type = ActionItemType.MenuItem;
				if (!string.IsNullOrWhiteSpace(actionMenuItem.Class))
				{
					IDictionary<string, object> dictionary = UIExtensions.ObjectToDictionary(actionMenuItem.Attributes);
					object value = null;
					dictionary["class"] = (dictionary.TryGetValue("class", out value) ? string.Concat(value, " ", actionMenuItem.Class) : actionMenuItem.Class);
					actionMenuItem.Attributes = dictionary;
				}
				if (!string.IsNullOrWhiteSpace(actionToolbarItem.ActionTypeProviderId) && !string.IsNullOrWhiteSpace(actionToolbarItem.ActionId))
				{
					IContentAction contentAction = contentActionRegistry.Get(actionToolbarItem.ActionTypeProviderId, actionToolbarItem.ActionId);
					if (contentAction != null)
					{
						actionMenuItem.Url = contentAction.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext());
						contentAction.OnRender(htmlHelper);
					}
				}
			}
			if (actionMenuItem.Items.Any())
			{
				actionMenuItem.Items = GetMenuItems(actionMenuItem.Items, contentActionRegistry, htmlHelper);
			}
			actionItemList.Add(item);
		}
		return actionItemList;
	}
}
