using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Toolbar
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CElementId_003Ek__BackingField;

		private string _003CElementName_003Ek__BackingField;

		private bool _003CIsVisible_003Ek__BackingField;

		private bool _003CShowCentered_003Ek__BackingField;

		private int _003CMaxElementHeight_003Ek__BackingField;

		[Name("elementId")]
		public string ElementId
		{
			get
			{
				return _003CElementId_003Ek__BackingField;
			}
			set
			{
				_003CElementId_003Ek__BackingField = value;
			}
		}

		[Name("elementName")]
		public string ElementName
		{
			get
			{
				return _003CElementName_003Ek__BackingField;
			}
			set
			{
				_003CElementName_003Ek__BackingField = value;
			}
		}

		[Name("isVisible")]
		public bool IsVisible
		{
			get
			{
				return _003CIsVisible_003Ek__BackingField;
			}
			set
			{
				_003CIsVisible_003Ek__BackingField = value;
			}
		}

		[Name("showCentered")]
		public bool ShowCentered
		{
			get
			{
				return _003CShowCentered_003Ek__BackingField;
			}
			set
			{
				_003CShowCentered_003Ek__BackingField = value;
			}
		}

		[Name("maxElementHeight")]
		public int MaxElementHeight
		{
			get
			{
				return _003CMaxElementHeight_003Ek__BackingField;
			}
			set
			{
				_003CMaxElementHeight_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Toolbar, {props}, {children})")]
	public extern Toolbar(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Toolbar source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Toolbar source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
