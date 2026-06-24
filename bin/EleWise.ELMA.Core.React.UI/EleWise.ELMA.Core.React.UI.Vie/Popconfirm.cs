using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Popconfirm
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CTitle_003Ek__BackingField;

		private string _003CCancelText_003Ek__BackingField;

		private string _003COkText_003Ek__BackingField;

		private ButtonStyle _003COkType_003Ek__BackingField;

		private Action<MouseEvent<HTMLButtonElement>> _003COnCancel_003Ek__BackingField;

		private Action<MouseEvent<HTMLButtonElement>> _003COnConfirm_003Ek__BackingField;

		private TooltipPlacement _003CPlacement_003Ek__BackingField;

		private Action<bool> _003COnVisibleChange_003Ek__BackingField;

		private bool? _003CVisible_003Ek__BackingField;

		[Name("title")]
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

		[Name("cancelText")]
		public string CancelText
		{
			get
			{
				return _003CCancelText_003Ek__BackingField;
			}
			set
			{
				_003CCancelText_003Ek__BackingField = value;
			}
		}

		[Name("okText")]
		public string OkText
		{
			get
			{
				return _003COkText_003Ek__BackingField;
			}
			set
			{
				_003COkText_003Ek__BackingField = value;
			}
		}

		[Name("okType")]
		public ButtonStyle OkType
		{
			get
			{
				return _003COkType_003Ek__BackingField;
			}
			set
			{
				_003COkType_003Ek__BackingField = value;
			}
		}

		[Name("onCancel")]
		public Action<MouseEvent<HTMLButtonElement>> OnCancel
		{
			get
			{
				return _003COnCancel_003Ek__BackingField;
			}
			set
			{
				_003COnCancel_003Ek__BackingField = value;
			}
		}

		[Name("onConfirm")]
		public Action<MouseEvent<HTMLButtonElement>> OnConfirm
		{
			get
			{
				return _003COnConfirm_003Ek__BackingField;
			}
			set
			{
				_003COnConfirm_003Ek__BackingField = value;
			}
		}

		[Name("placement")]
		public TooltipPlacement Placement
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
		public bool? Visible
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

	[Template("React.createElement(elmaComponents.Popconfirm, {props}, {children})")]
	public extern Popconfirm(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Popconfirm source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Popconfirm source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
