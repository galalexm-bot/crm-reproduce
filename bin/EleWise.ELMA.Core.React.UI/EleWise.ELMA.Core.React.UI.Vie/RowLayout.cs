using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class RowLayout
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Align _003CAlign_003Ek__BackingField;

		private VerticalAlign _003CVerticalAlign_003Ek__BackingField;

		[Name("align")]
		public Align Align
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

		[Name("verticalAlign")]
		public VerticalAlign VerticalAlign
		{
			get
			{
				return _003CVerticalAlign_003Ek__BackingField;
			}
			set
			{
				_003CVerticalAlign_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum Align
	{
		Left,
		Center,
		Right,
		Justify
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum VerticalAlign
	{
		Top,
		Center,
		Bottom
	}

	[Template("React.createElement(elmaComponents.RowLayout, {props}, {children})")]
	public extern RowLayout(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.RowLayout, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern RowLayout(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(RowLayout source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(RowLayout source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
