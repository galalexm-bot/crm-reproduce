using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class RadioButton
{
	[ObjectLiteral]
	public sealed class Props : AbstractCheckboxProps<RadioChangeEvent>, IHasTooltip
	{
		private string _003CTooltip_003Ek__BackingField;

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

	[Template("React.createElement(elmaComponents.RadioButton, {props}, {children})")]
	public extern RadioButton(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(RadioButton source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(RadioButton source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
