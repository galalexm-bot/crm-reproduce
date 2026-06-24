using System;
using Bridge;
using Bridge.Html5;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class ICellRendererParams
{
	private Func<object> _003CGetValue_003Ek__BackingField;

	private Action<object> _003CSetValue_003Ek__BackingField;

	private Func<object, object> _003CFormatValue_003Ek__BackingField;

	private object _003CData_003Ek__BackingField;

	private ColDef _003CColDef_003Ek__BackingField;

	private long _003CRowIndex_003Ek__BackingField;

	private GridApi _003CApi_003Ek__BackingField;

	private ColumnApi _003CColumnApi_003Ek__BackingField;

	private Action _003CRefreshCell_003Ek__BackingField;

	private HTMLElement _003CEGridCell_003Ek__BackingField;

	private HTMLElement _003CEParentOfValue_003Ek__BackingField;

	private Action<string, Action> _003CAddRenderedRowListener_003Ek__BackingField;

	private RowNode _003CNode_003Ek__BackingField;

	[Name("getValue")]
	public Func<object> GetValue
	{
		get
		{
			return _003CGetValue_003Ek__BackingField;
		}
		set
		{
			_003CGetValue_003Ek__BackingField = value;
		}
	}

	[Name("setValue")]
	public Action<object> SetValue
	{
		get
		{
			return _003CSetValue_003Ek__BackingField;
		}
		set
		{
			_003CSetValue_003Ek__BackingField = value;
		}
	}

	[Name("formatValue")]
	public Func<object, object> FormatValue
	{
		get
		{
			return _003CFormatValue_003Ek__BackingField;
		}
		set
		{
			_003CFormatValue_003Ek__BackingField = value;
		}
	}

	[Name("data")]
	public object Data
	{
		get
		{
			return _003CData_003Ek__BackingField;
		}
		set
		{
			_003CData_003Ek__BackingField = value;
		}
	}

	[Name("colDef")]
	public ColDef ColDef
	{
		get
		{
			return _003CColDef_003Ek__BackingField;
		}
		set
		{
			_003CColDef_003Ek__BackingField = value;
		}
	}

	[Name("rowIndex")]
	public long RowIndex
	{
		get
		{
			return _003CRowIndex_003Ek__BackingField;
		}
		set
		{
			_003CRowIndex_003Ek__BackingField = value;
		}
	}

	[Name("api")]
	public GridApi Api
	{
		get
		{
			return _003CApi_003Ek__BackingField;
		}
		set
		{
			_003CApi_003Ek__BackingField = value;
		}
	}

	[Name("columnApi")]
	public ColumnApi ColumnApi
	{
		get
		{
			return _003CColumnApi_003Ek__BackingField;
		}
		set
		{
			_003CColumnApi_003Ek__BackingField = value;
		}
	}

	[Name("refreshCell")]
	public Action RefreshCell
	{
		get
		{
			return _003CRefreshCell_003Ek__BackingField;
		}
		set
		{
			_003CRefreshCell_003Ek__BackingField = value;
		}
	}

	[Name("eGridCell")]
	public HTMLElement EGridCell
	{
		get
		{
			return _003CEGridCell_003Ek__BackingField;
		}
		set
		{
			_003CEGridCell_003Ek__BackingField = value;
		}
	}

	[Name("eParentOfValue")]
	public HTMLElement EParentOfValue
	{
		get
		{
			return _003CEParentOfValue_003Ek__BackingField;
		}
		set
		{
			_003CEParentOfValue_003Ek__BackingField = value;
		}
	}

	[Name("addRenderedRowListener")]
	public Action<string, Action> AddRenderedRowListener
	{
		get
		{
			return _003CAddRenderedRowListener_003Ek__BackingField;
		}
		set
		{
			_003CAddRenderedRowListener_003Ek__BackingField = value;
		}
	}

	[Name("node")]
	public RowNode Node
	{
		get
		{
			return _003CNode_003Ek__BackingField;
		}
		set
		{
			_003CNode_003Ek__BackingField = value;
		}
	}
}
