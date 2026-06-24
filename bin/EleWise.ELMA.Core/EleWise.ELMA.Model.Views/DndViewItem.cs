using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.ViewModel;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class DndViewItem : RootViewItem
{
	[Component(Order = 930)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<DndViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{1B7CCABF-E305-49E2-AC82-8F16A082DB27}");

		public override string Name => SR.T("Перетаскивание");

		public override string Icon => "drag";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	public static Guid ContainerSlotUid = new Guid("1f03bd2c-bd21-4daf-b13a-e0d5f26bc736");

	private string _003CDndId_003Ek__BackingField;

	private bool _003CCanDrag_003Ek__BackingField;

	private bool _003CAccept_003Ek__BackingField;

	private ActionWithParamResult<DroppedObjectInfo, bool> _003CAllowDrop_003Ek__BackingField;

	private string _003CDragEngineInstanceKey_003Ek__BackingField;

	private ActionWithParam<DraggedObjectInfo> _003COnDrag_003Ek__BackingField;

	private ActionWithParam<DroppedObjectInfo> _003COnDrop_003Ek__BackingField;

	[DynamicProperty(false)]
	public string DndId
	{
		get
		{
			return _003CDndId_003Ek__BackingField;
		}
		set
		{
			_003CDndId_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool CanDrag
	{
		get
		{
			return _003CCanDrag_003Ek__BackingField;
		}
		set
		{
			_003CCanDrag_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Accept
	{
		get
		{
			return _003CAccept_003Ek__BackingField;
		}
		set
		{
			_003CAccept_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParamResult<DroppedObjectInfo, bool> AllowDrop
	{
		get
		{
			return _003CAllowDrop_003Ek__BackingField;
		}
		set
		{
			_003CAllowDrop_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string DragEngineInstanceKey
	{
		get
		{
			return _003CDragEngineInstanceKey_003Ek__BackingField;
		}
		set
		{
			_003CDragEngineInstanceKey_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<DraggedObjectInfo> OnDrag
	{
		get
		{
			return _003COnDrag_003Ek__BackingField;
		}
		set
		{
			_003COnDrag_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<DroppedObjectInfo> OnDrop
	{
		get
		{
			return _003COnDrop_003Ek__BackingField;
		}
		set
		{
			_003COnDrop_003Ek__BackingField = value;
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
