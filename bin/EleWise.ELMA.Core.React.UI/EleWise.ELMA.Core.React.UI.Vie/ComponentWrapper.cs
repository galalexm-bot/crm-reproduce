using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class ComponentWrapper
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CName_003Ek__BackingField;

		private bool _003CVisible_003Ek__BackingField;

		private bool _003CForceRender_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseEnter_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseLeave_003Ek__BackingField;

		[Name("name")]
		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		[Name("visible")]
		public bool Visible
		{
			get
			{
				return _003CVisible_003Ek__BackingField;
			}
			set
			{
				_003CVisible_003Ek__BackingField = value;
			}
		}

		[Name("forceRender")]
		public bool ForceRender
		{
			get
			{
				return _003CForceRender_003Ek__BackingField;
			}
			set
			{
				_003CForceRender_003Ek__BackingField = value;
			}
		}

		[Name("onMouseEnter")]
		public Action<MouseEvent<HTMLElement>> OnMouseEnter
		{
			get
			{
				return _003COnMouseEnter_003Ek__BackingField;
			}
			set
			{
				_003COnMouseEnter_003Ek__BackingField = value;
			}
		}

		[Name("onMouseLeave")]
		public Action<MouseEvent<HTMLElement>> OnMouseLeave
		{
			get
			{
				return _003COnMouseLeave_003Ek__BackingField;
			}
			set
			{
				_003COnMouseLeave_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.ComponentWrapper, {props}, {children})")]
	public extern ComponentWrapper(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.ComponentWrapper, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern ComponentWrapper(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(ComponentWrapper source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(ComponentWrapper source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
