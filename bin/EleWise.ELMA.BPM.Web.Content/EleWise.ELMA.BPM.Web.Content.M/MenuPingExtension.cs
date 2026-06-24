using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

[Component]
public class MenuPingExtension : IPingDataExtension
{
	public string ClientFunction => "elma.menuCountsUpdate";

	public string GetData()
	{
		List<IMenuItem> source = (from i in MenuItemManager.Instance.LoadItemsReadOnly(MenuManager.LeftMenuUid, allowDisabled: true)
			orderby i.Weight
			select i).ToList();
		IContentActionRegistry contentActionRegistry = Locator.GetService<IContentActionRegistry>();
		IEnumerable<IMenuItemCountEvaluator> countEvaluatorPoints = ComponentManager.Current.GetExtensionPoints<IMenuItemCountEvaluator>();
		return Json.Encode((object)(from i in source.Select(delegate(IMenuItem item)
			{
				MenuItemNode node = new MenuItemNode
				{
					Id = item.Id,
					MenuUid = item.MenuUid,
					MenuId = item.Menu.Id,
					ParentItemId = ((item.ParentItem != null) ? new long?(item.ParentItem.Id) : null),
					ParentItemName = ((item.ParentItem != null) ? item.ParentItem.Name : ""),
					Name = item.Name,
					Code = item.Code,
					Target = item.Target,
					Description = item.Description,
					ImageUrl = item.ImageUrl,
					NavigateUrl = item.NavigateUrl,
					Disabled = item.Disabled,
					Weight = item.Weight,
					OnTop = item.OnTop,
					Stretch = item.Stretch,
					Items = new List<MenuItemNode>(),
					Type = (MenuItemNodeType)item.Type
				};
				if (!string.IsNullOrWhiteSpace(item.ActionTypeProviderId))
				{
					IContentAction contentAction = contentActionRegistry.Get(item.ActionTypeProviderId, item.ActionId);
					if (contentAction != null && string.IsNullOrWhiteSpace(node.Code))
					{
						node.Code = contentAction.Id;
					}
				}
				node.IsHome = node.Code == "home";
				MenuItemCount count = null;
				IMenuItemCountEvaluator menuItemCountEvaluator = countEvaluatorPoints.FirstOrDefault((IMenuItemCountEvaluator r) => r.HasCountEvaluator(node));
				if (menuItemCountEvaluator != null && menuItemCountEvaluator.NeedUpdate(node))
				{
					count = menuItemCountEvaluator.Evaluate(node);
				}
				return new { node, count };
			})
			where i != null && i.count != null
			select new
			{
				code = i.node.Code,
				c = i.count.Count,
				f = i.count.ClientUpdateFunction,
				cssClass = i.count.CssClass
			}).ToList());
	}
}
