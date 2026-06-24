using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

[Serializable]
public class ToolbarTreeItem : IActionText, IActionIcon
{
	public Guid TypeUid { get; set; }

	public string Uid { get; set; }

	public bool IsUidSet { get; set; }

	[ChangeableProperty]
	[DefaultValue(false)]
	public bool PosibleHidden { get; set; }

	[ChangeableProperty]
	[DefaultValue(true)]
	public bool Visible { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	[EleWise.ELMA.Globalization.Localizable]
	public string Text { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	[EleWise.ELMA.Globalization.Localizable]
	public string ToolTip { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	[EleWise.ELMA.Globalization.Localizable]
	public string ToolTipHeader { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	public string IconUrl { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	public string IconCls { get; set; }

	[ChangeableProperty]
	[DefaultValue(false)]
	public bool Checked { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	public string ActionTypeProviderId { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	public string ActionId { get; set; }

	[ChangeableProperty]
	[DefaultValue("")]
	public string ActionData { get; set; }

	[DefaultValue(null)]
	public List<ToolbarTreeItem> Items { get; set; }

	public ToolbarTreeItem()
	{
		Text = "";
		ToolTip = "";
		ToolTipHeader = "";
		IconUrl = "";
		IconCls = "";
		ActionTypeProviderId = "";
		ActionId = "";
		ActionData = "";
		Visible = true;
		IsUidSet = true;
	}

	public ToolbarTreeItem(IActionItem item)
		: this()
	{
		if (item != null)
		{
			Uid = item.Uid;
			ActionToolbarItem actionToolbarItem = item as ActionToolbarItem;
			IsUidSet = actionToolbarItem?.IsUidSet ?? (!(item is ActionToolbarGroup) || ((ActionToolbarGroup)item).IsUidSet);
			Visible = true;
			TypeUid = item.Type.Uid;
			if (item is IPossibleHiddenActionItem possibleHiddenActionItem)
			{
				PosibleHidden = possibleHiddenActionItem.PosibleHidden;
			}
			if (item is IActionText actionText)
			{
				Text = actionText.Text;
				ToolTip = actionText.ToolTip;
				ToolTipHeader = actionText.ToolTipHeader;
			}
			if (item is IActionIcon actionIcon)
			{
				IconUrl = actionIcon.IconUrl;
				IconCls = actionIcon.IconCls;
				Checked = actionIcon.Checked;
			}
			ActionTypeProviderId = ((actionToolbarItem != null) ? actionToolbarItem.ActionTypeProviderId : "");
			ActionId = ((actionToolbarItem != null) ? actionToolbarItem.ActionId : "");
		}
	}

	public IActionItem CreateItem(HtmlHelper htmlHelper, IActionItem container)
	{
		if (TypeUid == ActionItemTypeToolbarGroup.Guid)
		{
			return new ActionToolbarGroup(Uid);
		}
		if (TypeUid == ActionItemTypeToolbarItemSeparator.Guid)
		{
			return new ActionToolbarSeparator(Uid);
		}
		if (TypeUid != ActionItemTypeToolbarItem.Guid)
		{
			return null;
		}
		IContentActionRegistry serviceNotNull = Locator.GetServiceNotNull<IContentActionRegistry>();
		IContentAction contentAction = ((!string.IsNullOrWhiteSpace(ActionTypeProviderId) && !string.IsNullOrWhiteSpace(ActionId)) ? serviceNotNull.Get(ActionTypeProviderId, ActionId) : null);
		if (contentAction != null && !contentAction.IsAvalilable(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext()))
		{
			contentAction = null;
		}
		return new ActionToolbarItem(Uid)
		{
			Url = contentAction?.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext()),
			Text = ((!string.IsNullOrWhiteSpace(Text)) ? Text : ((contentAction != null) ? SR.T(contentAction.NameForLocalization) : null)),
			ToolTip = ((!string.IsNullOrWhiteSpace(ToolTip)) ? ToolTip : ((contentAction != null) ? SR.T(contentAction.DescriptionForLocalization) : null)),
			IconUrl = ((!string.IsNullOrWhiteSpace(IconUrl)) ? IconUrl : contentAction?.GetImage((container is ActionToolbarGroup) ? ObjectIconFormat.x32 : ObjectIconFormat.x16)),
			ToolTipHeader = ((!string.IsNullOrWhiteSpace(ToolTipHeader)) ? ToolTipHeader : null),
			IconCls = ((!string.IsNullOrWhiteSpace(IconCls)) ? IconCls : null),
			Checked = Checked,
			Visible = Visible,
			OnRender = ((contentAction != null) ? new Action<HtmlHelper>(contentAction.OnRender) : null),
			ActionTypeProviderId = ActionTypeProviderId,
			ActionId = ActionId
		};
	}

	public override string ToString()
	{
		return Uid;
	}
}
