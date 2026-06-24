using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class TableColumn
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CName_003Ek__BackingField;

		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private Func<string, object, long, Union<ReactElement, string>> _003CRender_003Ek__BackingField;

		private bool _003CSorter_003Ek__BackingField;

		private Union<string, bool> _003CSortOrder_003Ek__BackingField;

		private Union<int, string> _003CWidth_003Ek__BackingField;

		private bool _003CEnableChangeWidth_003Ek__BackingField;

		private bool _003CEnableChangeOrder_003Ek__BackingField;

		private bool _003CIsDragDisabled_003Ek__BackingField;

		private bool _003CEnableGroup_003Ek__BackingField;

		private Func<object, object, bool> _003CShouldCellUpdate_003Ek__BackingField;

		[Name("dataIndex")]
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

		[Name("title")]
		public Union<ReactElement, string> Title
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

		[Name("render")]
		public Func<string, object, long, Union<ReactElement, string>> Render
		{
			get
			{
				return _003CRender_003Ek__BackingField;
			}
			set
			{
				_003CRender_003Ek__BackingField = value;
			}
		}

		[Name("sorter")]
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

		[Name("sortOrder")]
		public Union<string, bool> SortOrder
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

		[Name("width")]
		public Union<int, string> Width
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

		[Name("enableChangeWidth")]
		public bool EnableChangeWidth
		{
			get
			{
				return _003CEnableChangeWidth_003Ek__BackingField;
			}
			set
			{
				_003CEnableChangeWidth_003Ek__BackingField = value;
			}
		}

		[Name("enableChangeOrder")]
		public bool EnableChangeOrder
		{
			get
			{
				return _003CEnableChangeOrder_003Ek__BackingField;
			}
			set
			{
				_003CEnableChangeOrder_003Ek__BackingField = value;
			}
		}

		[Name("isDragDisabled")]
		public bool IsDragDisabled
		{
			get
			{
				return _003CIsDragDisabled_003Ek__BackingField;
			}
			set
			{
				_003CIsDragDisabled_003Ek__BackingField = value;
			}
		}

		[Name("enableGroup")]
		public bool EnableGroup
		{
			get
			{
				return _003CEnableGroup_003Ek__BackingField;
			}
			set
			{
				_003CEnableGroup_003Ek__BackingField = value;
			}
		}

		[Name("shouldCellUpdate")]
		public Func<object, object, bool> ShouldCellUpdate
		{
			get
			{
				return _003CShouldCellUpdate_003Ek__BackingField;
			}
			set
			{
				_003CShouldCellUpdate_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.TableColumn, {props}, {children})")]
	public extern TableColumn(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.GridColumn, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern TableColumn(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(TableColumn source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TableColumn source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
