using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class ModalViewItem : RootViewItem, IViewItemLoading, IViewItem, IReactive, IContainerViewItem
{
	[Component(Order = 460)]
	private class ToolboxItem : CommonViewItemToolboxItem<ModalViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{ABC6966A-425A-4973-816E-D9276BB197B2}");

		public override string Name => SR.T("Модальное окно");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

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
			if (uid == FooterSlotUid)
			{
				result = SR.T("Подвал модального окна");
			}
			return result;
		}
	}

	public static Guid FooterSlotUid = new Guid("65F4258E-81BC-460D-A4BC-B892DB87F3C0");

	private ViewItemComponentSize _003CSize_003Ek__BackingField;

	private string _003CTitle_003Ek__BackingField;

	private bool _003CDestroyOnClose_003Ek__BackingField;

	private DefaultAction _003COnClose_003Ek__BackingField;

	private ViewItemLoadingType _003CLoadingType_003Ek__BackingField;

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
	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	public bool DestroyOnClose
	{
		get
		{
			return _003CDestroyOnClose_003Ek__BackingField;
		}
		set
		{
			_003CDestroyOnClose_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public DefaultAction OnClose
	{
		get
		{
			return _003COnClose_003Ek__BackingField;
		}
		set
		{
			_003COnClose_003Ek__BackingField = value;
		}
	}

	public ViewItemLoadingType LoadingType
	{
		get
		{
			return _003CLoadingType_003Ek__BackingField;
		}
		set
		{
			_003CLoadingType_003Ek__BackingField = value;
		}
	}

	public ModalViewItem()
	{
		LoadingType = ViewItemLoadingType.AsyncLoading;
		Size = ViewItemComponentSize.Medium;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
