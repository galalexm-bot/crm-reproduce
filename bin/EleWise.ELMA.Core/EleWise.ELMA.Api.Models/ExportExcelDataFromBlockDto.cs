using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Api.Models;

public sealed class ExportExcelDataFromBlockDto
{
	private Guid _003CEntityTypeUid_003Ek__BackingField;

	private long _003CParentId_003Ek__BackingField;

	private string _003CExportExcelFileName_003Ek__BackingField;

	private string _003CGridId_003Ek__BackingField;

	private Guid _003CProviderUid_003Ek__BackingField;

	private int _003CCount_003Ek__BackingField;

	private int _003CPage_003Ek__BackingField;

	private int _003CPageSize_003Ek__BackingField;

	private bool _003CPageable_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<TableViewSortDescriptor> _003CSortDescriptors_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<TableViewGroupDescriptor> _003CGroupDescriptors_003Ek__BackingField;

	private string _003CTablePartChangesModelSerialized_003Ek__BackingField;

	private Guid _003CPropertyViewItemUid_003Ek__BackingField;

	private string[] _003CColumnsOrder_003Ek__BackingField;

	public Guid EntityTypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CEntityTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CEntityTypeUid_003Ek__BackingField = value;
		}
	}

	public long ParentId
	{
		get
		{
			return _003CParentId_003Ek__BackingField;
		}
		set
		{
			_003CParentId_003Ek__BackingField = value;
		}
	}

	public string ExportExcelFileName
	{
		get
		{
			return _003CExportExcelFileName_003Ek__BackingField;
		}
		set
		{
			_003CExportExcelFileName_003Ek__BackingField = value;
		}
	}

	public string GridId
	{
		get
		{
			return _003CGridId_003Ek__BackingField;
		}
		set
		{
			_003CGridId_003Ek__BackingField = value;
		}
	}

	public Guid ProviderUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CProviderUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CProviderUid_003Ek__BackingField = value;
		}
	}

	public int Count
	{
		get
		{
			return _003CCount_003Ek__BackingField;
		}
		set
		{
			_003CCount_003Ek__BackingField = value;
		}
	}

	public int Page
	{
		get
		{
			return _003CPage_003Ek__BackingField;
		}
		set
		{
			_003CPage_003Ek__BackingField = value;
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

	public System.Collections.Generic.IEnumerable<TableViewSortDescriptor> SortDescriptors
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

	public System.Collections.Generic.IEnumerable<TableViewGroupDescriptor> GroupDescriptors
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

	public string TablePartChangesModelSerialized
	{
		get
		{
			return _003CTablePartChangesModelSerialized_003Ek__BackingField;
		}
		set
		{
			_003CTablePartChangesModelSerialized_003Ek__BackingField = value;
		}
	}

	public Guid PropertyViewItemUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPropertyViewItemUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPropertyViewItemUid_003Ek__BackingField = value;
		}
	}

	public string[] ColumnsOrder
	{
		get
		{
			return _003CColumnsOrder_003Ek__BackingField;
		}
		set
		{
			_003CColumnsOrder_003Ek__BackingField = value;
		}
	}
}
