using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.Buttons;

public class ButtonGroupBuilder : ActionSubItemBuilderBase<ActionButtonGroup, ButtonGroupBuilder, ActionButton, ActionButtonBuilder>
{
	public ButtonGroupBuilder(HtmlHelper htmlHelper, ActionButtonGroup actionItem)
		: base(htmlHelper, actionItem, (Func<string, ActionButtonGroup>)null, "action-item-")
	{
	}

	public override string ToHtmlString()
	{
		return ((HtmlString)(object)htmlHelper.ActionItem(ActionItem)).ToHtmlString();
	}

	protected override ActionButtonBuilder CreateSubItemBuilder(ActionButton actionSubItem = null)
	{
		return new ActionButtonBuilder(HtmlHelper, actionSubItem ?? new ActionButton());
	}

	public override ButtonGroupBuilder Item([NotNull] Action<ActionButtonBuilder> itemBuilder)
	{
		Contract.NotNull(itemBuilder, "itemBuilder");
		ActionButtonBuilder actionButtonBuilder = CreateSubItemBuilder();
		itemBuilder(actionButtonBuilder);
		Add(actionButtonBuilder.ActionItem);
		return Builder;
	}

	public virtual ButtonGroupBuilder Item([NotNull] ActionButtonBuilder itemBuilder)
	{
		Contract.NotNull(itemBuilder, "itemBuilder");
		Add(itemBuilder.ActionItem);
		return Builder;
	}

	public virtual ButtonGroupBuilder Insert(int index, [NotNull] Action<ActionButtonBuilder> itemBuilder)
	{
		Contract.NotNull(itemBuilder, "itemBuilder");
		ActionButtonBuilder actionButtonBuilder = CreateSubItemBuilder();
		itemBuilder(actionButtonBuilder);
		Insert(index, actionButtonBuilder.ActionItem);
		return Builder;
	}

	public ButtonGroupBuilder Attributes(object attributes)
	{
		ActionItem.Attributes = attributes;
		return Builder;
	}

	public ButtonGroupBuilder IsSplitted()
	{
		ActionItem.IsMerged = false;
		return Builder;
	}

	public ButtonGroupBuilder AsBreadcrumbs()
	{
		ActionItem.AsBreadcrumbs = true;
		return Builder;
	}
}
