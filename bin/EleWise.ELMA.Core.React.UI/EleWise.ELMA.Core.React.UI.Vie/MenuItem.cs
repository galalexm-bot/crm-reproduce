using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class MenuItem
{
	[ObjectLiteral]
	public sealed class Props : MenuItemBaseProps
	{
		private bool _003CActive_003Ek__BackingField;

		private Action<ClickParam> _003COnClick_003Ek__BackingField;

		[Name("active")]
		public bool Active
		{
			get
			{
				return _003CActive_003Ek__BackingField;
			}
			set
			{
				_003CActive_003Ek__BackingField = value;
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
	}

	[ObjectLiteral]
	public class MenuItemBaseProps : BaseProps
	{
		private object _003COnItemHover_003Ek__BackingField;

		private object _003CEventKey_003Ek__BackingField;

		private object _003CRootPrefixCls_003Ek__BackingField;

		private object _003CParentMenu_003Ek__BackingField;

		private string[] _003CSelectedKeys_003Ek__BackingField;

		[Name("onItemHover")]
		public object OnItemHover
		{
			get
			{
				return _003COnItemHover_003Ek__BackingField;
			}
			set
			{
				_003COnItemHover_003Ek__BackingField = value;
			}
		}

		[Name("eventKey")]
		public object EventKey
		{
			get
			{
				return _003CEventKey_003Ek__BackingField;
			}
			set
			{
				_003CEventKey_003Ek__BackingField = value;
			}
		}

		[Name("rootPrefixCls")]
		public object RootPrefixCls
		{
			get
			{
				return _003CRootPrefixCls_003Ek__BackingField;
			}
			set
			{
				_003CRootPrefixCls_003Ek__BackingField = value;
			}
		}

		[Name("parentMenu")]
		public object ParentMenu
		{
			get
			{
				return _003CParentMenu_003Ek__BackingField;
			}
			set
			{
				_003CParentMenu_003Ek__BackingField = value;
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
	}

	[Template("React.createElement(elmaComponents.MenuItem, {props}, {children})")]
	public extern MenuItem(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.MenuItem, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern MenuItem(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(MenuItem source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(MenuItem source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
