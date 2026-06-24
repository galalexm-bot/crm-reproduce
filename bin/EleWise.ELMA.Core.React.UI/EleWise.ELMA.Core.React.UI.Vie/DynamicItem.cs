using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class DynamicItem
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
	}

	[Template("React.createElement(elmaComponents.DynamicItem, {props}, {children})")]
	public extern DynamicItem(Props props, Func<object, ReactElement[]> children);

	public static implicit operator ReactElement(DynamicItem source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(DynamicItem source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
