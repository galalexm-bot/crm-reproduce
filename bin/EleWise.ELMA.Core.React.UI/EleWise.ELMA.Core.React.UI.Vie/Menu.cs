using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Menu
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CSelectable_003Ek__BackingField;

		private MenuType _003CMode_003Ek__BackingField;

		private string[] _003CSelectedKeys_003Ek__BackingField;

		private Action<ClickParam> _003COnClick_003Ek__BackingField;

		private Action<SelectParam> _003COnSelect_003Ek__BackingField;

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

		[Name("mode")]
		public MenuType Mode
		{
			get
			{
				return _003CMode_003Ek__BackingField;
			}
			set
			{
				_003CMode_003Ek__BackingField = value;
			}
		}

		[Name("selectedKeys")]
		public string[] SelectedKeys
		{
			get
			{
				return _003CSelectedKeys_003Ek__BackingField;
			}
			set
			{
				_003CSelectedKeys_003Ek__BackingField = value;
			}
		}

		[Name("onClick")]
		public Action<ClickParam> OnClick
		{
			get
			{
				return _003COnClick_003Ek__BackingField;
			}
			set
			{
				_003COnClick_003Ek__BackingField = value;
			}
		}

		[Name("onSelect")]
		public Action<SelectParam> OnSelect
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
	}

	[Template("React.createElement(elmaComponents.Menu, {props}, {children})")]
	public extern Menu(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.Menu, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Menu(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Menu source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Menu source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
