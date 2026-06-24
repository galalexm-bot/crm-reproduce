using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Content;
using EleWise.ELMA.Content.Helpers;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using Newtonsoft.Json;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class PagesExplorerController : BPMController
{
	private PagesExplorerModel GetExplorerModel(string explorerId, long? id, int? height, string disabledItems, bool personal)
	{
		PagesExplorerModel pagesExplorerModel = new PagesExplorerModel
		{
			Id = explorerId,
			Height = height,
			DisabledItemsJson = disabledItems,
			Personal = personal
		};
		if (personal)
		{
			IUser user = base.AuthenticationService.GetCurrentUser<IUser>();
			pagesExplorerModel.Items = (from IPortalObject s in PageBaseManager.Instance.Find((IPageBase p) => p.CreationAuthor == user)
				where s != null && base.SecurityService.HasPermission(user, PageSecurity.ViewPagePermission, s, skipAdmin: true)
				select s).ToList();
		}
		else
		{
			IPageFolder folder = (pagesExplorerModel.Folder = (id.HasValue ? AbstractNHEntityManager<IPageFolder, long>.Instance.Load(id.Value) : null));
			pagesExplorerModel.Items = PageBaseManager.Instance.GetFolderContents(folder, needLevelUp: true);
		}
		return pagesExplorerModel;
	}

	public ActionResult Explorer(string explorerId, long? id, int? height, string disabledItems, bool personal)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)GetExplorerModel(explorerId, id, height, disabledItems, personal));
	}

	public ActionResult ExplorerTree(string explorerId, long? id, string disabledItems, bool personal, string treeId)
	{
		PagesExplorerModel explorerModel = GetExplorerModel(explorerId, id, null, disabledItems, personal);
		TreeModel contentTreeModel = GetContentTreeModel(treeId, explorerModel);
		contentTreeModel.RouteValues = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Content" },
			{ "personal", explorerModel.Personal }
		};
		return (ActionResult)(object)((Controller)this).PartialView("ContentTree", (object)contentTreeModel);
	}

	public ActionResult ExplorerTreePopup(string explorerId, long? id, string disabledItems, bool personal, string treeId)
	{
		PagesExplorerModel explorerModel = GetExplorerModel(explorerId, id, null, disabledItems, personal);
		TreeModel contentTreeModel = GetContentTreeModel(treeId, explorerModel);
		contentTreeModel.RouteValues = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Content" },
			{ "personal", explorerModel.Personal },
			{ "disabledItemsJson", disabledItems }
		};
		contentTreeModel.ShowCheckBox = true;
		return (ActionResult)(object)((Controller)this).PartialView("ContentTreePopup", (object)contentTreeModel);
	}

	public ActionResult Content(string explorerId, long? id, int? height, bool personal)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)GetExplorerModel(explorerId, id, height, null, personal));
	}

	public JsonResult ContentNodes(TreeViewItem node, string explorerId, bool personal, string disabledItemsJson)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		long result;
		bool flag = long.TryParse(node.get_Value(), out result);
		PagesExplorerModel explorerModel = GetExplorerModel(explorerId, flag ? new long?(result) : null, null, disabledItemsJson, personal);
		JsonResult val = new JsonResult();
		val.set_Data((object)GetNodes(explorerModel.Items, explorerModel.DisabledItemsJson));
		return val;
	}

	private List<TreeViewItem> GetNodes(List<IPortalObject> list, string disabledItemsJson)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		long[] source = ((!string.IsNullOrWhiteSpace(disabledItemsJson)) ? JsonConvert.DeserializeObject<long[]>(disabledItemsJson) : Array.Empty<long>());
		List<TreeViewItem> list2 = new List<TreeViewItem>();
		int num = 0;
		string imageUrl = ((Controller)this).get_Url().Image("#folder.svg");
		string imageUrl2 = ((Controller)this).get_Url().Image("#page_outline.svg");
		foreach (IPortalObject item in list)
		{
			TreeViewItem val = new TreeViewItem();
			((NavigationItem<TreeViewItem>)val).set_Text(item.Name);
			val.set_Value(item.Id.ToString());
			TreeViewItem val2 = val;
			((NavigationItem<TreeViewItem>)(object)val2).get_HtmlAttributes().Add("tooltiptextTree", ((NavigationItem<TreeViewItem>)(object)val2).get_Text());
			if (item is IPageFolder)
			{
				val2.set_Checkable(false);
				((NavigationItem<TreeViewItem>)(object)val2).set_ImageUrl(imageUrl);
				val2.set_LoadOnDemand(true);
				list2.Insert(num, val2);
				num++;
				continue;
			}
			if (source.Any((long a) => a == item.Id))
			{
				val2.get_HtmlClass().Add("disabled");
				val2.set_Checkable(false);
			}
			val2.get_HtmlClass().Add("list2listItem");
			((NavigationItem<TreeViewItem>)(object)val2).get_HtmlAttributes().Add("objectid", item.Id);
			((NavigationItem<TreeViewItem>)(object)val2).get_HtmlAttributes().Add("pagewithsettings", PortalObjectHelper.PageWithSettings(item));
			((NavigationItem<TreeViewItem>)(object)val2).set_ImageUrl(imageUrl2);
			list2.Add(val2);
		}
		return list2;
	}

	private TreeModel GetContentTreeModel(string treeId, PagesExplorerModel model)
	{
		return new TreeModel
		{
			Id = treeId,
			SaveState = false,
			HtmlAttributes = new
			{
				disabledItemsJson = model.DisabledItemsJson
			},
			Children = (from a in GetNodes(model.Items, model.DisabledItemsJson)
				select new TreeMenuNode(a)).ToList(),
			AjaxDataBinding = true,
			ControllerName = "PagesExplorer",
			ActionName = "ContentNodes"
		};
	}
}
