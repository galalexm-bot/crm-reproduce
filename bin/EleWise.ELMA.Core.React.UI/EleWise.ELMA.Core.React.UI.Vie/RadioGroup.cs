using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class RadioGroup
{
	[ObjectLiteral]
	public sealed class Props : AbstractCheckboxProps<RadioChangeEvent>
	{
		private RadioGroupType _003CType_003Ek__BackingField;

		[Name("type")]
		public RadioGroupType Type
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
	}

	[Template("React.createElement(elmaComponents.RadioGroup, {props}, {children})")]
	public extern RadioGroup(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.RadioGroup, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern RadioGroup(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(RadioGroup source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(RadioGroup source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
