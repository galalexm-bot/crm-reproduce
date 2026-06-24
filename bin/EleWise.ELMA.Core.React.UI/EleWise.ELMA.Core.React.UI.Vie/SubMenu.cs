using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class SubMenu
{
	[ObjectLiteral]
	public sealed class Props : MenuItem.MenuItemBaseProps
	{
		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private object _003COnOpenChange_003Ek__BackingField;

		private object _003COnClick_003Ek__BackingField;

		private object _003COnSelect_003Ek__BackingField;

		private object _003CExpandIcon_003Ek__BackingField;

		private object _003CTriggerSubMenuAction_003Ek__BackingField;

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

		[Name("disabled")]
		public bool Disabled
		{
			get
			{
				return _003CDisabled_003Ek__BackingField;
			}
			set
			{
				_003CDisabled_003Ek__BackingField = value;
			}
		}

		[Name("onOpenChange")]
		public object OnOpenChange
		{
			get
			{
				return _003COnOpenChange_003Ek__BackingField;
			}
			set
			{
				_003COnOpenChange_003Ek__BackingField = value;
			}
		}

		[Name("onClick")]
		public object OnClick
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
		public object OnSelect
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

		[Name("expandIcon")]
		public object ExpandIcon
		{
			get
			{
				return _003CExpandIcon_003Ek__BackingField;
			}
			set
			{
				_003CExpandIcon_003Ek__BackingField = value;
			}
		}

		[Name("triggerSubMenuAction")]
		public object TriggerSubMenuAction
		{
			get
			{
				return _003CTriggerSubMenuAction_003Ek__BackingField;
			}
			set
			{
				_003CTriggerSubMenuAction_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.SubMenu, {props}, {children})")]
	public extern SubMenu(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.SubMenu, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern SubMenu(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(SubMenu source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(SubMenu source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
