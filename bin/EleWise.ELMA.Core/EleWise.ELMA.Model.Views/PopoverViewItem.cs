using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class PopoverViewItem : RootViewItem
{
	[Component(Order = 460)]
	private class ToolboxItem : CommonViewItemToolboxItem<PopoverViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{E25C5050-AD90-441F-8775-69896C237EDE}");

		public override string Name => SR.T("Окно с подсказкой");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "popover";

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
			string result = base.GetSlotName(uid);
			if (uid == ButtonSlotUid)
			{
				result = SR.T("Контент видимой части окна с подсказкой");
			}
			return result;
		}
	}

	public static Guid ButtonSlotUid = new Guid("72765BA1-E6B7-4671-A97E-5DA6467220B9");

	private ActionWithParam<bool> _003COnChangeVisible_003Ek__BackingField;

	private ViewItemComponentSize _003CSize_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<bool> OnChangeVisible
	{
		get
		{
			return _003COnChangeVisible_003Ek__BackingField;
		}
		set
		{
			_003COnChangeVisible_003Ek__BackingField = value;
		}
	}

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

	public PopoverViewItem()
	{
		Size = ViewItemComponentSize.Full;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}
}
