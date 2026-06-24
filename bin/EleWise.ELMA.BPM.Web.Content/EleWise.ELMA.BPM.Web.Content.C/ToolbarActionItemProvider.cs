using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.Models.Toolbar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = int.MaxValue)]
public class ToolbarActionItemProvider : IActionItemProvider
{
	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (rootItem is ActionToolbar actionToolbar)
		{
			TestUids(rootItem, htmlHelper, new List<string>());
			string virtualPath = ((htmlHelper.get_ViewDataContainer() is WebPageExecutingBase) ? ((WebPageExecutingBase)htmlHelper.get_ViewDataContainer()).get_VirtualPath() : null);
			string uid = rootItem.Uid;
			if (WorkPlaceExtensions.CustomizerEnabled)
			{
				ToolbarTreeItem toolbarTreeItem = CreateToolbarTreeItem(rootItem, posibleHidden: false, new List<string>());
				actionToolbar.Items.Add(new ActionToolbarSerialized
				{
					Uid = "8DD1886A-2DA8-4F08-B8F9-3945E12003E1",
					VirtualPath = virtualPath,
					ToolbarTreeItem = toolbarTreeItem
				});
			}
			WorkPlaceExtensions.GetToolbarTransformation(virtualPath, uid, localize: true)?.Apply(htmlHelper, actionToolbar);
		}
	}

	private static ToolbarTreeItem CreateToolbarTreeItem(IActionItem item, bool posibleHidden, ICollection<string> uids)
	{
		if (uids.Contains(item.Uid))
		{
			return null;
		}
		uids.Add(item.Uid);
		ToolbarTreeItem res = new ToolbarTreeItem(item);
		res.PosibleHidden = res.PosibleHidden || posibleHidden;
		if (item.Items != null)
		{
			List<ToolbarTreeItem> list = (from i in item.Items
				select CreateToolbarTreeItem(i, res.PosibleHidden, uids) into i
				where i != null
				select i).ToList();
			if (list.Count > 0)
			{
				res.Items = list;
			}
		}
		return res;
	}

	private void TestUids(IActionItem item, HtmlHelper htmlHelper, List<string> uids)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (uids.Contains(item.Uid))
		{
			string arg = ((htmlHelper.get_ViewDataContainer() is WebPageExecutingBase) ? ((WebPageExecutingBase)htmlHelper.get_ViewDataContainer()).get_VirtualPath() : null);
			Logger.Log.Error($"Дублирущиеся кнопки тулбара. virtualPath: {arg}, Uid: {item.Uid}");
		}
		else
		{
			uids.Add(item.Uid);
		}
		if (item.Items != null)
		{
			item.Items.Each(delegate(IActionItem i)
			{
				TestUids(i, htmlHelper, uids);
			});
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		yield break;
	}
}
