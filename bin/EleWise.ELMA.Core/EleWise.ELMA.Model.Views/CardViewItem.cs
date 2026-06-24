using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class CardViewItem : RootViewItem, IContainerViewItem
{
	[Component(Order = 180)]
	private class ToolboxItem : CommonViewItemToolboxItem<CardViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{ABB5F481-E679-4184-AE2A-1362033A5077}");

		public override string Name => SR.T("Карточка");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "toolbar";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}

		public override string GetSlotName(Guid uid)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			string result = base.GetSlotName(uid);
			if (uid == HeaderSlotUid)
			{
				result = SR.T("Заголовок карточки");
			}
			if (uid == ContentSlotUid)
			{
				result = SR.T("Контент карточки");
			}
			if (uid == FooterSlotUid)
			{
				result = SR.T("Подвал карточки");
			}
			return result;
		}
	}

	public static Guid ContentSlotUid = new Guid("74660197-2DD4-4D8B-B9AE-53867FD21A92");

	public static Guid FooterSlotUid = new Guid("7B8AF2E9-E77C-42B2-8D14-A69B8769A25A");

	private ViewItemComponentSize _003CSize_003Ek__BackingField;

	private CardPaddingType _003CPadding_003Ek__BackingField;

	private string _003CLabelText_003Ek__BackingField;

	private CardLabelColor _003CLabelColor_003Ek__BackingField;

	private CardShadow _003CShadowType_003Ek__BackingField;

	public static Guid HeaderSlotUid => new Guid("1B5CC727-A79F-4511-ACCC-521AF47BC3CE");

	[DynamicProperty(false)]
	public ViewItemComponentSize Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public CardPaddingType Padding
	{
		get
		{
			return _003CPadding_003Ek__BackingField;
		}
		set
		{
			_003CPadding_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string LabelText
	{
		get
		{
			return _003CLabelText_003Ek__BackingField;
		}
		set
		{
			_003CLabelText_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public CardLabelColor LabelColor
	{
		get
		{
			return _003CLabelColor_003Ek__BackingField;
		}
		set
		{
			_003CLabelColor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public CardShadow ShadowType
	{
		get
		{
			return _003CShadowType_003Ek__BackingField;
		}
		set
		{
			_003CShadowType_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
