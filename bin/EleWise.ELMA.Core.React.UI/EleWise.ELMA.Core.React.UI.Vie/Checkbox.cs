using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Checkbox
{
	[ObjectLiteral]
	public sealed class Props : AbstractCheckboxProps<CheckboxChangeEvent>
	{
		private bool _003CIndeterminate_003Ek__BackingField;

		private Union<ReactElement, string> _003CRightText_003Ek__BackingField;

		[Name("indeterminate")]
		public bool Indeterminate
		{
			get
			{
				return _003CIndeterminate_003Ek__BackingField;
			}
			set
			{
				_003CIndeterminate_003Ek__BackingField = value;
			}
		}

		[Name("rightText")]
		public Union<ReactElement, string> RightText
		{
			get
			{
				return _003CRightText_003Ek__BackingField;
			}
			set
			{
				_003CRightText_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Checkbox, {props})")]
	public extern Checkbox(Props props);

	public static implicit operator ReactElement(Checkbox source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Checkbox source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
