using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Api.Models;

public sealed class ExportExcelDataFromGridDto
{
	private string _003CQuery_003Ek__BackingField;

	private Guid _003CEntityTypeUid_003Ek__BackingField;

	private string _003CExportExcelFileName_003Ek__BackingField;

	private string _003CGridId_003Ek__BackingField;

	private Guid _003CProviderUid_003Ek__BackingField;

	private int _003CCount_003Ek__BackingField;

	private int _003CPage_003Ek__BackingField;

	private int _003CPageSize_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<TableViewSortDescriptor> _003CSortDescriptors_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<TableViewGroupDescriptor> _003CGroupDescriptors_003Ek__BackingField;

	private string _003CFilter_003Ek__BackingField;

	private string _003CTitle_003Ek__BackingField;

	private string _003CTitleUrl_003Ek__BackingField;

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

	public string Filter
	{
		get
		{
			return _003CFilter_003Ek__BackingField;
		}
		set
		{
			_003CFilter_003Ek__BackingField = value;
		}
	}

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

	public string TitleUrl
	{
		get
		{
			return _003CTitleUrl_003Ek__BackingField;
		}
		set
		{
			_003CTitleUrl_003Ek__BackingField = value;
		}
	}
}
