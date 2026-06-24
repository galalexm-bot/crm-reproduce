using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Dropdown
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CDisabled_003Ek__BackingField;

		private ReactElement _003COverlay_003Ek__BackingField;

		private DropdownPlacement _003CPlacement_003Ek__BackingField;

		private bool _003CIsPopoverStyle_003Ek__BackingField;

		private DropdownTrigger _003CTrigger_003Ek__BackingField;

		private Action<bool> _003COnVisibleChange_003Ek__BackingField;

		private bool _003CVisible_003Ek__BackingField;

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

		[Name("overlay")]
		public ReactElement Overlay
		{
			get
			{
				return _003COverlay_003Ek__BackingField;
			}
			set
			{
				_003COverlay_003Ek__BackingField = value;
			}
		}

		[Name("placement")]
		public DropdownPlacement Placement
		{
			get
			{
				return _003CPlacement_003Ek__BackingField;
			}
			set
			{
				_003CPlacement_003Ek__BackingField = value;
			}
		}

		[Name("isPopoverStyle")]
		public bool IsPopoverStyle
		{
			get
			{
				return _003CIsPopoverStyle_003Ek__BackingField;
			}
			set
			{
				_003CIsPopoverStyle_003Ek__BackingField = value;
			}
		}

		[Name("trigger")]
		public DropdownTrigger Trigger
		{
			get
			{
				return _003CTrigger_003Ek__BackingField;
			}
			set
			{
				_003CTrigger_003Ek__BackingField = value;
			}
		}

		[Name("onVisibleChange")]
		public Action<bool> OnVisibleChange
		{
			get
			{
				return _003COnVisibleChange_003Ek__BackingField;
			}
			set
			{
				_003COnVisibleChange_003Ek__BackingField = value;
			}
		}

		[Name("visible")]
		public bool Visible
		{
			get
			{
				return _003CVisible_003Ek__BackingField;
			}
			set
			{
				_003CVisible_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Dropdown, {props}, {children})")]
	public extern Dropdown(Props props, ReactElement children);

	public static implicit operator ReactElement(Dropdown source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Dropdown source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
