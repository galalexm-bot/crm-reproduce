using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Button
{
	[ObjectLiteral]
	public sealed class Props : BaseProps, IHasTooltip, IHasDataTestId
	{
		private string _003CIcon_003Ek__BackingField;

		private ButtonShape _003CShape_003Ek__BackingField;

		private ButtonSize _003CSize_003Ek__BackingField;

		private ButtonStyle _003CStyle_003Ek__BackingField;

		private ButtonType _003CType_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private Action<FormEvent<HTMLButtonElement>> _003COnClick_003Ek__BackingField;

		private string _003CTooltip_003Ek__BackingField;

		private bool _003CLink_003Ek__BackingField;

		private string _003CHref_003Ek__BackingField;

		private Text.TextType _003CTextType_003Ek__BackingField;

		private string _003CTarget_003Ek__BackingField;

		private string _003CDataTestId_003Ek__BackingField;

		[Name("icon")]
		public string Icon
		{
			get
			{
				return _003CIcon_003Ek__BackingField;
			}
			set
			{
				_003CIcon_003Ek__BackingField = value;
			}
		}

		[Name("shape")]
		public ButtonShape Shape
		{
			get
			{
				return _003CShape_003Ek__BackingField;
			}
			set
			{
				_003CShape_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public ButtonSize Size
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

		[Name("style")]
		public ButtonStyle Style
		{
			get
			{
				return _003CStyle_003Ek__BackingField;
			}
			set
			{
				_003CStyle_003Ek__BackingField = value;
			}
		}

		[Name("type")]
		public ButtonType Type
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

		[Name("onClick")]
		public Action<FormEvent<HTMLButtonElement>> OnClick
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

		[Name("link")]
		public bool Link
		{
			get
			{
				return _003CLink_003Ek__BackingField;
			}
			set
			{
				_003CLink_003Ek__BackingField = value;
			}
		}

		[Name("href")]
		public string Href
		{
			get
			{
				return _003CHref_003Ek__BackingField;
			}
			set
			{
				_003CHref_003Ek__BackingField = value;
			}
		}

		[Name("textType")]
		public Text.TextType TextType
		{
			get
			{
				return _003CTextType_003Ek__BackingField;
			}
			set
			{
				_003CTextType_003Ek__BackingField = value;
			}
		}

		[Name("target")]
		public string Target
		{
			get
			{
				return _003CTarget_003Ek__BackingField;
			}
			set
			{
				_003CTarget_003Ek__BackingField = value;
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

	[Template("React.createElement(elmaComponents.Button, {props}, {children})")]
	public extern Button(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Button, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Button(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Button source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Button source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
