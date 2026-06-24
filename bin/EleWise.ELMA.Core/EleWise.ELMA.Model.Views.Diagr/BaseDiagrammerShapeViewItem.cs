using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal abstract class BaseDiagrammerShapeViewItem : RootViewItem, IDiagrammerShapeViewItem, IViewItem, IReactive
{
	private Guid _003CPropertyUid_003Ek__BackingField;

	private string _003CType_003Ek__BackingField;

	private Guid _003CId_003Ek__BackingField;

	private bool _003CIsSelected_003Ek__BackingField;

	private bool _003CDisplayControls_003Ek__BackingField;

	private DefaultAction _003COnElementClick_003Ek__BackingField;

	private DefaultAction _003COnElementDoubleClick_003Ek__BackingField;

	public Guid PropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPropertyUid_003Ek__BackingField = value;
		}
	}

	public string Type
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public Guid Id
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CId_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CId_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool IsSelected
	{
		get
		{
			return _003CIsSelected_003Ek__BackingField;
		}
		set
		{
			_003CIsSelected_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public bool DisplayControls
	{
		get
		{
			return _003CDisplayControls_003Ek__BackingField;
		}
		set
		{
			_003CDisplayControls_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnElementClick
	{
		get
		{
			return _003COnElementClick_003Ek__BackingField;
		}
		set
		{
			_003COnElementClick_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnElementDoubleClick
	{
		get
		{
			return _003COnElementDoubleClick_003Ek__BackingField;
		}
		set
		{
			_003COnElementDoubleClick_003Ek__BackingField = value;
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is SlotViewItem;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem != null && parentViewItem is DynamicSlotViewItem && parentViewItem.Parent?.Parent != null)
		{
			return parentViewItem.Parent?.Parent is DiagrammerViewItem;
		}
		return false;
	}
}
