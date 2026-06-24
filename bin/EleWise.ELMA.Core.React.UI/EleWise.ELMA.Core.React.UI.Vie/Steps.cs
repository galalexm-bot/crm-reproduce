using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Steps
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private DirectionType _003CDirection_003Ek__BackingField;

		private string _003CActiveKey_003Ek__BackingField;

		private Union<ReactElement, string> _003CStepsBarExtraContent_003Ek__BackingField;

		private Action<string> _003COnChange_003Ek__BackingField;

		[Name("direction")]
		public DirectionType Direction
		{
			get
			{
				return _003CDirection_003Ek__BackingField;
			}
			set
			{
				_003CDirection_003Ek__BackingField = value;
			}
		}

		[Name("activeKey")]
		public string ActiveKey
		{
			get
			{
				return _003CActiveKey_003Ek__BackingField;
			}
			set
			{
				_003CActiveKey_003Ek__BackingField = value;
			}
		}

		[Name("stepsBarExtraContent")]
		public Union<ReactElement, string> StepsBarExtraContent
		{
			get
			{
				return _003CStepsBarExtraContent_003Ek__BackingField;
			}
			set
			{
				_003CStepsBarExtraContent_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action<string> OnChange
		{
			get
			{
				return _003COnChange_003Ek__BackingField;
			}
			set
			{
				_003COnChange_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Steps, {props}, {children})")]
	public extern Steps(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.Steps, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Steps(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Steps source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Steps source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
