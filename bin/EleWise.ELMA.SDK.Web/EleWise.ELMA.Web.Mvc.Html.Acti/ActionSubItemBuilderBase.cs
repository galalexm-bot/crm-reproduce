using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.ActionItems;

public abstract class ActionSubItemBuilderBase<TItem, TBuilder, TSubItem, TSubItemBuilder> : ActionItemBuilderBase<TItem, TBuilder> where TItem : class, IActionItem where TBuilder : ActionSubItemBuilderBase<TItem, TBuilder, TSubItem, TSubItemBuilder> where TSubItem : class, IActionItem where TSubItemBuilder : ActionItemBuilderBase<TSubItem, TSubItemBuilder>
{
	protected ActionSubItemBuilderBase([NotNull] HtmlHelper htmlHelper, [NotNull] TItem actionItem, Func<string, TItem> itemGenerator = null, string namePrefix = "action-item-")
		: base(htmlHelper, actionItem, itemGenerator, namePrefix)
	{
	}

	[NotNull]
	protected abstract TSubItemBuilder CreateSubItemBuilder(TSubItem actionSubItem = null);

	[NotNull]
	public virtual TBuilder Item([NotNull] Action<TSubItemBuilder> itemBuilder)
	{
		if (itemBuilder == null)
		{
			throw new ArgumentNullException("itemBuilder");
		}
		itemBuilder(CreateSubItemBuilder());
		return Builder;
	}

	[NotNull]
	public virtual TSubItemBuilder AddItem([NotNull] TSubItem actionSubItem)
	{
		return Add(actionSubItem).CreateSubItemBuilder(actionSubItem);
	}

	[NotNull]
	public virtual TBuilder Add([NotNull] TSubItem actionSubItem)
	{
		if (actionSubItem == null)
		{
			throw new ArgumentNullException("actionItem");
		}
		ActionItem.Items.Add(actionSubItem);
		ChangeVisible(actionSubItem);
		return Builder;
	}

	[NotNull]
	public virtual TBuilder Insert([NotNull] int index, [NotNull] TSubItem actionSubItem)
	{
		Contract.ArgumentNotNull(actionSubItem, "actionItem");
		ActionItem.Items.Insert(index, actionSubItem);
		ChangeVisible(actionSubItem);
		return Builder;
	}

	private void ChangeVisible(TSubItem actionSubItem)
	{
		if (ActionItemBuilderBase<TItem, TBuilder>.Hidden)
		{
			actionSubItem.Visible = false;
		}
		if (ActionItemBuilderBase<TItem, TBuilder>.PosibleHidden && actionSubItem is IPossibleHiddenActionItem possibleHiddenActionItem)
		{
			possibleHiddenActionItem.PosibleHidden = true;
		}
	}
}
