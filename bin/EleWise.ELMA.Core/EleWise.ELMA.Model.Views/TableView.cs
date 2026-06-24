using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;

namespace EleWise.ELMA.Model.Views;

public class TableView : Reactive
{
	private Guid _003CUid_003Ek__BackingField;

	private ViewType _003CViewType_003Ek__BackingField;

	private bool _003CPageable_003Ek__BackingField;

	private int _003CPageSize_003Ek__BackingField;

	private bool _003CCustomizable_003Ek__BackingField;

	private bool _003CShowHeader_003Ek__BackingField;

	private bool _003CResizeable_003Ek__BackingField;

	private bool _003CReorderable_003Ek__BackingField;

	private bool _003CSortable_003Ek__BackingField;

	private System.Collections.Generic.ICollection<TableViewSortDescriptor> _003CSortDescriptors_003Ek__BackingField;

	private bool _003CGroupable_003Ek__BackingField;

	private System.Collections.Generic.ICollection<TableViewGroupDescriptor> _003CGroupDescriptors_003Ek__BackingField;

	private bool _003CCanAdd_003Ek__BackingField;

	private bool _003CCanEdit_003Ek__BackingField;

	private bool _003CCanDelete_003Ek__BackingField;

	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	public ViewType ViewType
	{
		get
		{
			return _003CViewType_003Ek__BackingField;
		}
		set
		{
			_003CViewType_003Ek__BackingField = value;
		}
	}

	public bool Pageable
	{
		get
		{
			return _003CPageable_003Ek__BackingField;
		}
		set
		{
			_003CPageable_003Ek__BackingField = value;
		}
	}

	public int PageSize
	{
		get
		{
			return _003CPageSize_003Ek__BackingField;
		}
		set
		{
			_003CPageSize_003Ek__BackingField = value;
		}
	}

	public bool Customizable
	{
		get
		{
			return _003CCustomizable_003Ek__BackingField;
		}
		set
		{
			_003CCustomizable_003Ek__BackingField = value;
		}
	}

	public bool ShowHeader
	{
		get
		{
			return _003CShowHeader_003Ek__BackingField;
		}
		set
		{
			_003CShowHeader_003Ek__BackingField = value;
		}
	}

	public bool Resizeable
	{
		get
		{
			return _003CResizeable_003Ek__BackingField;
		}
		set
		{
			_003CResizeable_003Ek__BackingField = value;
		}
	}

	public bool Reorderable
	{
		get
		{
			return _003CReorderable_003Ek__BackingField;
		}
		set
		{
			_003CReorderable_003Ek__BackingField = value;
		}
	}

	public bool Sortable
	{
		get
		{
			return _003CSortable_003Ek__BackingField;
		}
		set
		{
			_003CSortable_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<TableViewSortDescriptor> SortDescriptors
	{
		get
		{
			return _003CSortDescriptors_003Ek__BackingField;
		}
		set
		{
			_003CSortDescriptors_003Ek__BackingField = value;
		}
	}

	public bool Groupable
	{
		get
		{
			return _003CGroupable_003Ek__BackingField;
		}
		set
		{
			_003CGroupable_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<TableViewGroupDescriptor> GroupDescriptors
	{
		get
		{
			return _003CGroupDescriptors_003Ek__BackingField;
		}
		set
		{
			_003CGroupDescriptors_003Ek__BackingField = value;
		}
	}

	public bool CanAdd
	{
		get
		{
			return _003CCanAdd_003Ek__BackingField;
		}
		set
		{
			_003CCanAdd_003Ek__BackingField = value;
		}
	}

	public bool CanEdit
	{
		get
		{
			return _003CCanEdit_003Ek__BackingField;
		}
		set
		{
			_003CCanEdit_003Ek__BackingField = value;
		}
	}

	public bool CanDelete
	{
		get
		{
			return _003CCanDelete_003Ek__BackingField;
		}
		set
		{
			_003CCanDelete_003Ek__BackingField = value;
		}
	}

	public TableView()
	{
		ViewType = ViewType.Custom;
		Pageable = true;
		PageSize = 15;
		Customizable = true;
		ShowHeader = true;
		Sortable = true;
		SortDescriptors = new ReactiveCollection<TableViewSortDescriptor>();
		GroupDescriptors = new ReactiveCollection<TableViewGroupDescriptor>();
	}
}
