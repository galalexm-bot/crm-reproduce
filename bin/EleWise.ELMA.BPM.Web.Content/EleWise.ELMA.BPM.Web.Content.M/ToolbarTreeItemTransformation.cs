using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Transformations.Class;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

[Serializable]
[XmlInclude(typeof(ToolbarTreeItem))]
[XmlInclude(typeof(ToolbarTreeItemTransformationAdd))]
[XmlInclude(typeof(ToolbarTreeItemTransformationMove))]
[XmlInclude(typeof(ToolbarTreeItemTransformationHide))]
[XmlInclude(typeof(ToolbarTreeItemTransformationChange))]
public class ToolbarTreeItemTransformation : Transformation<ToolbarTreeItem, ToolbarTreeItemTransformation, string, ToolbarTreeItemTransformationAdd, ToolbarTreeItemTransformationMove, ToolbarTreeItemTransformationHide, ToolbarTreeItemTransformationChange>, IToolbarTreeItemBaseTransformation
{
	public string VirtualPath { get; set; }

	protected override IList<ToolbarTreeItem> GetSubItems(ToolbarTreeItem item)
	{
		return item.Items;
	}

	protected override string GetUid(ToolbarTreeItem item)
	{
		return item.Uid;
	}

	protected override bool IsHide(ToolbarTreeItem item)
	{
		return !item.Visible;
	}

	protected override void SetHide(ToolbarTreeItem parentItem, ToolbarTreeItem item, bool hide = true)
	{
		item.Visible = !hide;
	}

	protected override ToolbarTreeItem CreateCopy(ToolbarTreeItem item)
	{
		return CloneHelperBuilder.Create(item).Restrictions(delegate(RestrictionsBuilder<ToolbarTreeItem> r)
		{
			r.Rule().ForPropertyName((ToolbarTreeItem t) => t.Items).Ignore();
		}).Clone();
	}

	protected override ToolbarTreeItem Clone(ToolbarTreeItem item)
	{
		return CloneHelperBuilder.Create(item).Clone();
	}

	public void Apply(HtmlHelper htmlHelper, IActionItem rootItem)
	{
		foreach (IToolbarTreeItemBaseTransformation item in base.Items.OfType<IToolbarTreeItemBaseTransformation>())
		{
			item.Apply(htmlHelper, rootItem);
		}
	}

	protected override void AddItem(ToolbarTreeItem item, ToolbarTreeItem subItem)
	{
		item.Items = item.Items ?? new List<ToolbarTreeItem>();
		base.AddItem(item, subItem);
	}

	protected override void InsertItem(ToolbarTreeItem item, int index, ToolbarTreeItem subItem)
	{
		item.Items = item.Items ?? new List<ToolbarTreeItem>();
		base.InsertItem(item, index, subItem);
	}

	internal new ToolbarTreeItem FindItem(ToolbarTreeItem viewItem, string itemUid)
	{
		return base.FindItem(viewItem, itemUid);
	}

	internal new ToolbarTreeItem FindItem(ToolbarTreeItem viewItem, string itemUid, out ToolbarTreeItem container)
	{
		return base.FindItem(viewItem, itemUid, out container);
	}

	public ToolbarTreeItemTransformation Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}
}
