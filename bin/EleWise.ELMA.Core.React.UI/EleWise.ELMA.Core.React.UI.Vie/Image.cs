using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Image
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CSrc_003Ek__BackingField;

		private string _003CAlt_003Ek__BackingField;

		private ImageShape _003CShape_003Ek__BackingField;

		private int _003CWidth_003Ek__BackingField;

		private int _003CHeight_003Ek__BackingField;

		private ImageSize _003CSize_003Ek__BackingField;

		private string _003CTooltip_003Ek__BackingField;

		[Name("src")]
		public string Src
		{
			get
			{
				return _003CSrc_003Ek__BackingField;
			}
			set
			{
				_003CSrc_003Ek__BackingField = value;
			}
		}

		[Name("alt")]
		public string Alt
		{
			get
			{
				return _003CAlt_003Ek__BackingField;
			}
			set
			{
				_003CAlt_003Ek__BackingField = value;
			}
		}

		[Name("shape")]
		public ImageShape Shape
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

		[Name("width")]
		public int Width
		{
			get
			{
				return _003CWidth_003Ek__BackingField;
			}
			set
			{
				_003CWidth_003Ek__BackingField = value;
			}
		}

		[Name("height")]
		public int Height
		{
			get
			{
				return _003CHeight_003Ek__BackingField;
			}
			set
			{
				_003CHeight_003Ek__BackingField = value;
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
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum ImageShape
	{
		Default,
		Round,
		Circle
	}

	[Template("React.createElement(elmaComponents.Image, {props})")]
	public extern Image(Props props);

	public static implicit operator ReactElement(Image source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Image source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
