using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class ObjectFormViewItem : ViewItem, IViewItemLoading, IViewItem, IReactive, IViewItemWithPropertyParents
{
	[Component(Order = 470)]
	private sealed class ToolboxItem : AdditionalViewItemToolboxItem<ObjectFormViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{8D283B4F-6D9B-4686-949E-D211A90B161C}");

		public override string Name => SR.T("Форма объекта");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "object-form";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private ViewType _003CType_003Ek__BackingField;

	private Guid _003CFormUid_003Ek__BackingField;

	private Guid _003CContextPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private Guid _003CIncludedTypeUid_003Ek__BackingField;

	private bool _003CSaveFormState_003Ek__BackingField;

	private ViewItemLoadingType _003CLoadingType_003Ek__BackingField;

	[DynamicProperty(false)]
	public ViewType Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public Guid FormUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CFormUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CFormUid_003Ek__BackingField = value;
		}
	}

	public Guid ContextPropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CContextPropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CContextPropertyUid_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<Guid> PropertyParents
	{
		get
		{
			return _003CPropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CPropertyParents_003Ek__BackingField = value;
		}
	}

	public Guid IncludedTypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CIncludedTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CIncludedTypeUid_003Ek__BackingField = value;
		}
	}

	public bool SaveFormState
	{
		get
		{
			return _003CSaveFormState_003Ek__BackingField;
		}
		set
		{
			_003CSaveFormState_003Ek__BackingField = value;
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

	public ObjectFormViewItem()
	{
		Type = ViewType.Create;
		LoadingType = ViewItemLoadingType.AsyncLoading;
		PropertyParents = new ReactiveCollection<Guid>();
	}
}
