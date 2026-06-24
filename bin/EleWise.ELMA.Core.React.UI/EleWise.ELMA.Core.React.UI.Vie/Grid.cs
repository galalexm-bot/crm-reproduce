using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Grid
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private object[] _003CSource_003Ek__BackingField;

		private bool _003CShowHeader_003Ek__BackingField;

		private bool _003CShowPagination_003Ek__BackingField;

		private int _003CPageSize_003Ek__BackingField;

		private int _003CCurrentPage_003Ek__BackingField;

		private Union<ReactElement, string> _003CTableExtraContent_003Ek__BackingField;

		private bool _003CResizable_003Ek__BackingField;

		private bool _003CReorderable_003Ek__BackingField;

		private bool _003CSelectable_003Ek__BackingField;

		private int _003CCount_003Ek__BackingField;

		private object[] _003CSelectedItems_003Ek__BackingField;

		private object _003CLocaleText_003Ek__BackingField;

		private Action<RowSelectedEvent> _003COnRowSelected_003Ek__BackingField;

		private Func<object, string> _003CGetRowId_003Ek__BackingField;

		private Action<PaginationChangedEvent> _003COnPaginationChanged_003Ek__BackingField;

		private Action<string, string> _003COnSortChanged_003Ek__BackingField;

		[Name("source")]
		public object[] Source
		{
			get
			{
				return _003CSource_003Ek__BackingField;
			}
			set
			{
				_003CSource_003Ek__BackingField = value;
			}
		}

		[Name("showHeader")]
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

		[Name("pagination")]
		public bool ShowPagination
		{
			get
			{
				return _003CShowPagination_003Ek__BackingField;
			}
			set
			{
				_003CShowPagination_003Ek__BackingField = value;
			}
		}

		[Name("paginationPageSize")]
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

		[Name("currentPage")]
		public int CurrentPage
		{
			get
			{
				return _003CCurrentPage_003Ek__BackingField;
			}
			set
			{
				_003CCurrentPage_003Ek__BackingField = value;
			}
		}

		[Name("tableExtraContent")]
		public Union<ReactElement, string> TableExtraContent
		{
			get
			{
				return _003CTableExtraContent_003Ek__BackingField;
			}
			set
			{
				_003CTableExtraContent_003Ek__BackingField = value;
			}
		}

		[Name("resizable")]
		public bool Resizable
		{
			get
			{
				return _003CResizable_003Ek__BackingField;
			}
			set
			{
				_003CResizable_003Ek__BackingField = value;
			}
		}

		[Name("reorderable")]
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

		[Name("selectable")]
		public bool Selectable
		{
			get
			{
				return _003CSelectable_003Ek__BackingField;
			}
			set
			{
				_003CSelectable_003Ek__BackingField = value;
			}
		}

		[Name("count")]
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

		[Name("selectedItems")]
		public object[] SelectedItems
		{
			get
			{
				return _003CSelectedItems_003Ek__BackingField;
			}
			set
			{
				_003CSelectedItems_003Ek__BackingField = value;
			}
		}

		[Name("localeText")]
		public object LocaleText
		{
			get
			{
				return _003CLocaleText_003Ek__BackingField;
			}
			set
			{
				_003CLocaleText_003Ek__BackingField = value;
			}
		}

		[Name("onRowSelected")]
		public Action<RowSelectedEvent> OnRowSelected
		{
			get
			{
				return _003COnRowSelected_003Ek__BackingField;
			}
			set
			{
				_003COnRowSelected_003Ek__BackingField = value;
			}
		}

		[Name("getRowId")]
		public Func<object, string> GetRowId
		{
			get
			{
				return _003CGetRowId_003Ek__BackingField;
			}
			set
			{
				_003CGetRowId_003Ek__BackingField = value;
			}
		}

		[Name("onPaginationChanged")]
		public Action<PaginationChangedEvent> OnPaginationChanged
		{
			get
			{
				return _003COnPaginationChanged_003Ek__BackingField;
			}
			set
			{
				_003COnPaginationChanged_003Ek__BackingField = value;
			}
		}

		[Name("onSortChanged")]
		public Action<string, string> OnSortChanged
		{
			get
			{
				return _003COnSortChanged_003Ek__BackingField;
			}
			set
			{
				_003COnSortChanged_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Grid, {props}, {children})")]
	public extern Grid(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.Grid, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Grid(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Grid source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Grid source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
