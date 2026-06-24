using System;
using System.Web.Mvc;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Class;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

[Serializable]
public class ToolbarTreeItemTransformationAdd : TransformationAdd<ToolbarTreeItem, ToolbarTreeItemTransformation, string>, IToolbarTreeItemBaseTransformation
{
	public void Apply(HtmlHelper htmlHelper, IActionItem rootItem)
	{
		ActionItemTransformation instance = Transformation<IActionItem, ActionItemTransformation, string, string>.Instance;
		IActionItem actionItem = instance.FindItem(rootItem, base.Uid);
		if (actionItem != null)
		{
			TransformationAdd<IActionItem, ActionItemTransformation, string, string, IActionItem>.StaticApply(rootItem, base.Uid, Item.CreateItem(htmlHelper, actionItem), base.BeforeItem, base.AfterItem, instance);
		}
	}

	public override void ApplyLocalization()
	{
		base.ApplyLocalization();
		LocalizableAttributeHelper.Localize(Item);
	}
}
