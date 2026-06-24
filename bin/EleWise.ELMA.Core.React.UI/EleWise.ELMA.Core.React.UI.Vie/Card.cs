using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Card
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private ReactElement[] _003CActions_003Ek__BackingField;

		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private Union<ReactElement, string> _003CExtra_003Ek__BackingField;

		private bool _003CLoading_003Ek__BackingField;

		private CardSize _003CSize_003Ek__BackingField;

		private string _003CLabelText_003Ek__BackingField;

		private CardLabelColor _003CLabelColor_003Ek__BackingField;

		private CardShadow _003CShadow_003Ek__BackingField;

		private PaddingType _003CPadding_003Ek__BackingField;

		[Name("actions")]
		public ReactElement[] Actions
		{
			get
			{
				return _003CActions_003Ek__BackingField;
			}
			set
			{
				_003CActions_003Ek__BackingField = value;
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

		[Name("extra")]
		public Union<ReactElement, string> Extra
		{
			get
			{
				return _003CExtra_003Ek__BackingField;
			}
			set
			{
				_003CExtra_003Ek__BackingField = value;
			}
		}

		[Name("loading")]
		public bool Loading
		{
			get
			{
				return _003CLoading_003Ek__BackingField;
			}
			set
			{
				_003CLoading_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public CardSize Size
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

		[Name("labelText")]
		public string LabelText
		{
			get
			{
				return _003CLabelText_003Ek__BackingField;
			}
			set
			{
				_003CLabelText_003Ek__BackingField = value;
			}
		}

		[Name("labelColor")]
		public CardLabelColor LabelColor
		{
			get
			{
				return _003CLabelColor_003Ek__BackingField;
			}
			set
			{
				_003CLabelColor_003Ek__BackingField = value;
			}
		}

		[Name("shadow")]
		public CardShadow Shadow
		{
			get
			{
				return _003CShadow_003Ek__BackingField;
			}
			set
			{
				_003CShadow_003Ek__BackingField = value;
			}
		}

		[Name("padding")]
		public PaddingType Padding
		{
			get
			{
				return _003CPadding_003Ek__BackingField;
			}
			set
			{
				_003CPadding_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Card, {props}, {children})")]
	public extern Card(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Card, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Card(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Card source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Card source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
