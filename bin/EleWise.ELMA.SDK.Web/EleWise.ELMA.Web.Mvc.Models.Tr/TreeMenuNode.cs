using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Models.Trees;

public class TreeMenuNode
{
	public string id { get; set; }

	public string text { get; set; }

	public string textAdditional { get; set; }

	public bool isHtml { get; set; }

	public bool expanded { get; set; }

	public bool loadOnDemand { get; set; }

	public bool disabled { get; set; }

	public bool Checked { get; set; }

	public bool Selected { get; set; }

	public bool checkable { get; set; }

	public string icon { get; set; }

	public string iconCls { get; set; }

	public string href { get; set; }

	public string onclick { get; set; }

	public object tag { get; set; }

	public List<TreeMenuNode> children { get; set; }

	public Guid typeuid { get; set; }

	public bool Virtual { get; set; }

	public IList<string> HtmlClass { get; set; }

	public IDictionary<string, object> HtmlAttributes { get; set; }

	public IDictionary<string, object> ImageHtmlAttributes { get; set; }

	protected UrlHelper Url => TreeModel.Url;

	public TreeMenuNode()
	{
		icon = "";
		iconCls = "no-icon";
		children = new List<TreeMenuNode>();
		expanded = false;
		Checked = false;
		checkable = true;
		Selected = false;
	}

	public TreeMenuNode(TreeViewItem item)
		: this()
	{
		text = ((NavigationItem<TreeViewItem>)(object)item).get_Text();
		icon = ((NavigationItem<TreeViewItem>)(object)item).get_ImageUrl();
		id = item.get_Value();
		Checked = item.get_Checked();
		loadOnDemand = item.get_LoadOnDemand();
		onclick = ((NavigationItem<TreeViewItem>)(object)item).get_OnClick();
		href = ((NavigationItem<TreeViewItem>)(object)item).get_Url();
		checkable = item.get_Checkable();
		typeuid = item.get_TypeUid();
		disabled = !((NavigationItem<TreeViewItem>)(object)item).get_Enabled();
		HtmlClass = item.get_HtmlClass();
		HtmlAttributes = ((NavigationItem<TreeViewItem>)(object)item).get_HtmlAttributes();
		ImageHtmlAttributes = ((NavigationItem<TreeViewItem>)(object)item).get_ImageHtmlAttributes();
	}

	public virtual string GetEncodedText()
	{
		return $"<span>{((isHtml || string.IsNullOrEmpty(text)) ? (text + textAdditional) : (HttpUtility.HtmlEncode(text) + textAdditional))}</span>";
	}

	public bool HasChecked()
	{
		if (!Checked)
		{
			return children.Any((TreeMenuNode c) => c.HasChecked());
		}
		return true;
	}

	public List<TreeMenuNode> CheckedNodes()
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		if (Checked)
		{
			list.Add(this);
		}
		list.AddRange(children.SelectMany((TreeMenuNode c) => c.CheckedNodes()));
		return list;
	}
}
