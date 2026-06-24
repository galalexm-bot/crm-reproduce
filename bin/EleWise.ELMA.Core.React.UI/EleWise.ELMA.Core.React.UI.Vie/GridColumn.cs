using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class GridColumn
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CColId_003Ek__BackingField;

		private string _003CName_003Ek__BackingField;

		private object _003CHeaderParams_003Ek__BackingField;

		private object _003CParams_003Ek__BackingField;

		private bool _003CSorter_003Ek__BackingField;

		private string _003CSortOrder_003Ek__BackingField;

		private bool _003CIsGrouping_003Ek__BackingField;

		private int _003CRowGroupIndex_003Ek__BackingField;

		private bool _003CCheckboxSelection_003Ek__BackingField;

		private int _003CWidth_003Ek__BackingField;

		[Name("colId")]
		public string ColId
		{
			get
			{
				return _003CColId_003Ek__BackingField;
			}
			set
			{
				_003CColId_003Ek__BackingField = value;
			}
		}

		[Name("field")]
		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		[Name("headerComponentParams")]
		public object HeaderParams
		{
			get
			{
				return _003CHeaderParams_003Ek__BackingField;
			}
			set
			{
				_003CHeaderParams_003Ek__BackingField = value;
			}
		}

		[Name("cellRendererParams")]
		public object Params
		{
			get
			{
				return _003CParams_003Ek__BackingField;
			}
			set
			{
				_003CParams_003Ek__BackingField = value;
			}
		}

		[Name("sortable")]
		public bool Sorter
		{
			get
			{
				return _003CSorter_003Ek__BackingField;
			}
			set
			{
				_003CSorter_003Ek__BackingField = value;
			}
		}

		[Name("sort")]
		public string SortOrder
		{
			get
			{
				return _003CSortOrder_003Ek__BackingField;
			}
			set
			{
				_003CSortOrder_003Ek__BackingField = value;
			}
		}

		[Name("rowGroup")]
		public bool IsGrouping
		{
			get
			{
				return _003CIsGrouping_003Ek__BackingField;
			}
			set
			{
				_003CIsGrouping_003Ek__BackingField = value;
			}
		}

		[Name("rowGroupIndex")]
		public int RowGroupIndex
		{
			get
			{
				return _003CRowGroupIndex_003Ek__BackingField;
			}
			set
			{
				_003CRowGroupIndex_003Ek__BackingField = value;
			}
		}

		[Name("checkboxSelection")]
		public bool CheckboxSelection
		{
			get
			{
				return _003CCheckboxSelection_003Ek__BackingField;
			}
			set
			{
				_003CCheckboxSelection_003Ek__BackingField = value;
			}
		}

		[Name("width")]
		public int Width
		{
			get
			{
				return _003CWidth_003Ek__BackingField;
			}
			set
			{
				_003CWidth_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.GridColumn, {props}, {children})")]
	public extern GridColumn(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.GridColumn, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern GridColumn(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(GridColumn source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(GridColumn source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
