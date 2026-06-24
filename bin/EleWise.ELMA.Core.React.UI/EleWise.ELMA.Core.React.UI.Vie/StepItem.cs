using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class StepItem
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private ReactElement _003CTitle_003Ek__BackingField;

		private string _003CDescription_003Ek__BackingField;

		private string _003CStepNumber_003Ek__BackingField;

		[Name("title")]
		public ReactElement Title
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

		[Name("description")]
		public string Description
		{
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			set
			{
				_003CDescription_003Ek__BackingField = value;
			}
		}

		[Name("stepNumber")]
		public string StepNumber
		{
			get
			{
				return _003CStepNumber_003Ek__BackingField;
			}
			set
			{
				_003CStepNumber_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.StepItem, {props}, {children})")]
	public extern StepItem(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(StepItem source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(StepItem source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
