using System;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Icon
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CType_003Ek__BackingField;

		private string _003CTooltip_003Ek__BackingField;

		private Action<object> _003COnClick_003Ek__BackingField;

		private bool _003CSpin_003Ek__BackingField;

		private ImageSize _003CSize_003Ek__BackingField;

		private string _003CColor_003Ek__BackingField;

		[Name("type")]
		public string Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		[Name("tooltip")]
		public string Tooltip
		{
			get
			{
				return _003CTooltip_003Ek__BackingField;
			}
			set
			{
				_003CTooltip_003Ek__BackingField = value;
			}
		}

		[Name("onClick")]
		public Action<object> OnClick
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

		[Name("spin")]
		public bool Spin
		{
			get
			{
				return _003CSpin_003Ek__BackingField;
			}
			set
			{
				_003CSpin_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public ImageSize Size
		{
			get
			{
				return _003CSize_003Ek__BackingField;
			}
			set
			{
				_003CSize_003Ek__BackingField = value;
			}
		}

		[Name("color")]
		public string Color
		{
			get
			{
				return _003CColor_003Ek__BackingField;
			}
			set
			{
				_003CColor_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Icon, {props}, {children})")]
	public extern Icon(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Icon source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Icon source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
