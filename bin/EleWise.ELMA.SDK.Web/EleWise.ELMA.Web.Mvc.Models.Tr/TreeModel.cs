using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Models.Trees;

public class TreeModel
{
	internal const string ContextItemsUrlHelperKey = "TreeModelCurrentContextItemsUrlHelper";

	private object htmlAttributes = new
	{
		style = "height:300px;"
	};

	private List<TreeMenuNode> children;

	public static ISecurityService _securityService { get; set; }

	public static ISecurityService securityService => _securityService ?? (_securityService = Locator.GetServiceNotNull<ISecurityService>());

	protected internal static UrlHelper Url
	{
		get
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			if (HttpContextAccessor.CurrentContext.Items.Contains("TreeModelCurrentContextItemsUrlHelper"))
			{
				return (UrlHelper)HttpContextAccessor.CurrentContext.Items["TreeModelCurrentContextItemsUrlHelper"];
			}
			UrlHelper val = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
			HttpContextAccessor.CurrentContext.Items["TreeModelCurrentContextItemsUrlHelper"] = val;
			return val;
		}
	}

	public object HtmlAttributes
	{
		get
		{
			return htmlAttributes;
		}
		set
		{
			htmlAttributes = value;
		}
	}

	public string ControllerName { get; set; }

	public string ActionName { get; set; }

	public RouteValueDictionary RouteValues { get; set; }

	public TreeType Type { get; set; }

	public string Id { get; set; }

	public string Current { get; set; }

	public string OnNodeDragStartFunction { get; set; }

	public string OnNodeDropFunction { get; set; }

	public string OnNodeDroppedFunction { get; set; }

	public string OnSelectFunction { get; set; }

	public string OnDataBoundFunction { get; set; }

	public string OnNodeDraggingFunction { get; set; }

	public string Width { get; set; }

	public string Height { get; set; }

	public bool ShowCheckBox { get; set; }

	public bool SaveState { get; set; }

	public bool HighlightPath { get; set; }

	public bool ShowExpandCollapseButtons { get; set; }

	public bool AjaxDataBinding { get; set; }

	public bool ReadOnly { get; set; }

	public Func<dynamic, object> ItemTextTemplate { get; set; }

	public bool KeepChildNodes { get; set; }

	public List<TreeMenuNode> Children
	{
		get
		{
			return children;
		}
		set
		{
			children = value;
		}
	}

	public bool MultiSelect { get; set; }

	public string LoadingStack { get; set; }

	public bool PartialTree { get; set; }

	public bool AsyncPartialLoading { get; set; }

	public TreeModel()
	{
		Width = "";
		Height = "";
		Children = new List<TreeMenuNode>();
		SaveState = true;
		HighlightPath = true;
		ControllerName = "Fake";
		ActionName = "Fake";
		MultiSelect = true;
		KeepChildNodes = false;
	}

	public string JsonChildren()
	{
		return new JsonSerializer().Serialize(Children).Replace(",\"children\":null", "");
	}

	public TreeMenuNode Get([NotNull] string id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		TreeMenuNode treeMenuNode = Children.SelectRecursive((TreeMenuNode c) => c.children).FirstOrDefault((TreeMenuNode n) => n.id == id);
		if (treeMenuNode == null)
		{
			throw new ArgumentException(SR.T("Не удалось найти элемент с иднетификатором \"{0}\"", id), id);
		}
		return treeMenuNode;
	}

	public bool HasPermission(Permission permission, Guid typeUid, long id)
	{
		Type typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(typeUid);
		if (typeByUid == null)
		{
			return false;
		}
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		if (manager == null)
		{
			return false;
		}
		object entity = null;
		securityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			entity = manager.Load(id).CastAsRealType();
		});
		return Locator.GetService<ISecurityService>().HasPermission(permission, entity);
	}

	public void ItemDataBinder(TreeViewItem item, TreeMenuNode node)
	{
		string text = node.GetEncodedText() ?? string.Empty;
		if (string.IsNullOrEmpty(text))
		{
			text = "-";
		}
		((NavigationItem<TreeViewItem>)(object)item).set_Text(text);
		((NavigationItem<TreeViewItem>)(object)item).set_Encoded(false);
		if (!string.IsNullOrEmpty(node.href))
		{
			((NavigationItem<TreeViewItem>)(object)item).set_Url(node.href);
		}
		if (!string.IsNullOrEmpty(node.onclick))
		{
			((NavigationItem<TreeViewItem>)(object)item).set_OnClick(node.onclick);
		}
		if (!string.IsNullOrEmpty(node.icon))
		{
			((NavigationItem<TreeViewItem>)(object)item).set_ImageUrl(Url.Image(node.icon));
		}
		item.set_Expanded(node.expanded);
		item.set_Value(node.id);
		item.set_Checked(node.Checked);
		if (!HighlightPath)
		{
			((NavigationItem<TreeViewItem>)(object)item).set_Selected(node.Selected);
		}
		item.set_Checkable(node.checkable);
		item.set_TypeUid(node.typeuid);
		item.set_LoadOnDemand(node.loadOnDemand);
		((NavigationItem<TreeViewItem>)(object)item).set_Enabled(!node.disabled);
		if (node.HtmlClass != null)
		{
			node.HtmlClass.ToList().ForEach(delegate(string k)
			{
				item.get_HtmlClass().Add(k);
			});
		}
		if (node.HtmlAttributes != null)
		{
			node.HtmlAttributes.ToList().ForEach(delegate(KeyValuePair<string, object> k)
			{
				((NavigationItem<TreeViewItem>)(object)item).get_HtmlAttributes().Add(k.Key, k.Value);
			});
		}
		if (node.ImageHtmlAttributes != null)
		{
			node.ImageHtmlAttributes.ToList().ForEach(delegate(KeyValuePair<string, object> k)
			{
				((NavigationItem<TreeViewItem>)(object)item).get_ImageHtmlAttributes().Add(k.Key, k.Value);
			});
		}
	}

	public IList<TreeViewItem> ToTreeViewItemList()
	{
		return GetItems(Children);
	}

	private IList<TreeViewItem> GetItems(IEnumerable<TreeMenuNode> items)
	{
		if (items == null)
		{
			return (IList<TreeViewItem>)(object)new TreeViewItem[0];
		}
		return items.Select(delegate(TreeMenuNode i)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			TreeViewItem val = new TreeViewItem();
			ItemDataBinder(val, i);
			val.set_Items(GetItems(i.children));
			return val;
		}).ToArray();
	}
}
