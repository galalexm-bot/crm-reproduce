using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class HotKeys
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Action _003COnCtrlAltS_003Ek__BackingField;

		private Action _003COnCtrlAltP_003Ek__BackingField;

		[Name("onCtrlAltS")]
		public Action OnCtrlAltS
		{
			get
			{
				return _003COnCtrlAltS_003Ek__BackingField;
			}
			set
			{
				_003COnCtrlAltS_003Ek__BackingField = value;
			}
		}

		[Name("onCtrlAltP")]
		public Action OnCtrlAltP
		{
			get
			{
				return _003COnCtrlAltP_003Ek__BackingField;
			}
			set
			{
				_003COnCtrlAltP_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.HotKeys, {props}, {children})")]
	public extern HotKeys(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(HotKeys source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(HotKeys source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
