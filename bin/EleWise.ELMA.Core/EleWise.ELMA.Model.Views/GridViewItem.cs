using System;
using System.Collections.Generic;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class GridViewItem : RootViewItem, ICountViewItem, ISelectionItemViewItem
{
	[Component(Order = 500)]
	private class ToolboxItem : CommonViewItemToolboxItem<GridViewItem>
	{
		public override Guid Uid => new Guid("888D29D6-EEBB-4A61-AF1A-888B10D7093E");

		public override string Name => SR.T("Список связанных объектов");

		public override string Icon => "document-link";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public static Guid MenuSlotUid = new Guid("BFE48F9A-BF86-45D7-B94E-940D5BC82720");

	private Guid _003CEntity_003Ek__BackingField;

	private Guid? _003CProperty_003Ek__BackingField;

	private bool _003CShowCount_003Ek__BackingField;

	private string _003CQuery_003Ek__BackingField;

	private TableView _003CTableView_003Ek__BackingField;

	private Guid _003CSelectablePropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CSelectablePropertyParents_003Ek__BackingField;

	private bool _003CEnableSelection_003Ek__BackingField;

	private ActionWithParam<bool> _003COnSelect_003Ek__BackingField;

	public override bool IsHideable => true;

	public Guid Entity
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CEntity_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CEntity_003Ek__BackingField = value;
		}
	}

	public Guid? Property
	{
		get
		{
			return _003CProperty_003Ek__BackingField;
		}
		set
		{
			_003CProperty_003Ek__BackingField = value;
		}
	}

	public bool ShowCount
	{
		get
		{
			return _003CShowCount_003Ek__BackingField;
		}
		set
		{
			_003CShowCount_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Query
	{
		get
		{
			return _003CQuery_003Ek__BackingField;
		}
		set
		{
			_003CQuery_003Ek__BackingField = value;
		}
	}

	public TableView TableView
	{
		get
		{
			return _003CTableView_003Ek__BackingField;
		}
		set
		{
			_003CTableView_003Ek__BackingField = value;
		}
	}

	public Guid SelectablePropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CSelectablePropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CSelectablePropertyUid_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<Guid> SelectablePropertyParents
	{
		get
		{
			return _003CSelectablePropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CSelectablePropertyParents_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool EnableSelection
	{
		get
		{
			return _003CEnableSelection_003Ek__BackingField;
		}
		set
		{
			_003CEnableSelection_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(true)]
	public ActionWithParam<bool> OnSelect
	{
		get
		{
			return _003COnSelect_003Ek__BackingField;
		}
		set
		{
			_003COnSelect_003Ek__BackingField = value;
		}
	}

	public GridViewItem()
	{
		ReadOnly = true;
		ShowCount = true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (!(childViewItem is IGridColumnViewItem))
		{
			return childViewItem is SlotViewItem;
		}
		return true;
	}
}
