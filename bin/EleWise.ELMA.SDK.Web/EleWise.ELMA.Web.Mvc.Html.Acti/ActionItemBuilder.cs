using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.ActionItems;

public class ActionItemBuilder<TItem, TBuilder> : ActionItemBuilderBase<TItem, TBuilder> where TItem : ActionItem, new()where TBuilder : ActionItemBuilderBase<TItem, TBuilder>
{
	public ActionItemBuilder(HtmlHelper htmlHelper, TItem actionItem)
		: base(htmlHelper, actionItem, (Func<string, TItem>)null, "action-item-")
	{
	}

	[NotNull]
	public virtual TBuilder Uid(string guidProperty)
	{
		ActionItem.Uid = guidProperty;
		return Builder;
	}

	[NotNull]
	public virtual TBuilder Guid(Guid guidProperty)
	{
		ActionItem.Uid = guidProperty.ToString();
		return Builder;
	}

	[NotNull]
	public virtual TBuilder Visible(bool isVisible)
	{
		if (ActionItem is IPossibleHiddenActionItem possibleHiddenActionItem)
		{
			possibleHiddenActionItem.PosibleHidden = BuildPosibleHidden();
		}
		ActionItem.Visible = isVisible;
		return Builder;
	}

	[NotNull]
	public virtual TBuilder OnRender(Action<HtmlHelper> onRenderAction)
	{
		ActionItem.OnRender = onRenderAction;
		return Builder;
	}

	[NotNull]
	public virtual TBuilder Attributes(object attributes)
	{
		ActionItem.Attributes = attributes;
		return Builder;
	}

	[NotNull]
	public TBuilder CustomAttributes(IDictionary<string, object> value)
	{
		ActionItem.CustomAttributes = value;
		return Builder;
	}

	[NotNull]
	public TBuilder Items(IActionItemList value)
	{
		ActionItem.Items = value;
		return Builder;
	}

	[NotNull]
	public virtual TBuilder ItemType(IActionItemType itemType)
	{
		ActionItem.Type = itemType;
		return Builder;
	}
}
