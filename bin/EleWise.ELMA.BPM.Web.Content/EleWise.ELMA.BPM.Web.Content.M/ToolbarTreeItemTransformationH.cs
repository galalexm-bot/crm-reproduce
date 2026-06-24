using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Class;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

[Serializable]
public class ToolbarTreeItemTransformationHide : TransformationHide<ToolbarTreeItem, ToolbarTreeItemTransformation, string>, IToolbarTreeItemBaseTransformation
{
	public void Apply(HtmlHelper htmlHelper, IActionItem rootItem)
	{
		TransformationHide<IActionItem, ActionItemTransformation, string, string>.StaticApply(rootItem, base.Uid);
	}
}
