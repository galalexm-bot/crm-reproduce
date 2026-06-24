using System.Collections.Generic;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Text
{
	[ObjectLiteral]
	public sealed class Props : BaseProps, IHasDataTestId
	{
		private TextType _003CType_003Ek__BackingField;

		private TextPlacement _003CAlign_003Ek__BackingField;

		private TextColor _003CTextColor_003Ek__BackingField;

		private bool _003CUnescapeHtml_003Ek__BackingField;

		private string _003CTooltip_003Ek__BackingField;

		private string _003CDataTestId_003Ek__BackingField;

		[Name("type")]
		public TextType Type
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

		[Name("align")]
		public TextPlacement Align
		{
			get
			{
				return _003CAlign_003Ek__BackingField;
			}
			set
			{
				_003CAlign_003Ek__BackingField = value;
			}
		}

		[Name("textColor")]
		public TextColor TextColor
		{
			get
			{
				return _003CTextColor_003Ek__BackingField;
			}
			set
			{
				_003CTextColor_003Ek__BackingField = value;
			}
		}

		[Name("unescapeHtml")]
		public bool UnescapeHtml
		{
			get
			{
				return _003CUnescapeHtml_003Ek__BackingField;
			}
			set
			{
				_003CUnescapeHtml_003Ek__BackingField = value;
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

		[Name("dataTestId")]
		public string DataTestId
		{
			get
			{
				return _003CDataTestId_003Ek__BackingField;
			}
			set
			{
				_003CDataTestId_003Ek__BackingField = value;
			}
		}
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum TextType
	{
		Base,
		Secondary,
		MetaInformation,
		H1,
		H2,
		H3,
		H4
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum TextColor
	{
		Default,
		Primary,
		Success,
		Danger,
		Warning,
		Light
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum TextPlacement
	{
		Left,
		Center,
		Right
	}

	[Template("React.createElement(elmaComponents.Text, {props}, {children})")]
	public extern Text(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Text, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Text(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	[Template("React.createElement(elmaComponents.Text, null, {children})")]
	public extern Text(params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Text, null, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Text(global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Text source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Text source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
