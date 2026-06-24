using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Sider
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<int, string> _003CWidth_003Ek__BackingField;

		private bool _003CFixed_003Ek__BackingField;

		private bool _003CCollapsible_003Ek__BackingField;

		private bool _003CCollapsed_003Ek__BackingField;

		private Union<string, int> _003CCollapsedWidth_003Ek__BackingField;

		private Action<bool> _003COnCollapse_003Ek__BackingField;

		[Name("width")]
		public Union<int, string> Width
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

		[Name("fixed")]
		public bool Fixed
		{
			get
			{
				return _003CFixed_003Ek__BackingField;
			}
			set
			{
				_003CFixed_003Ek__BackingField = value;
			}
		}

		[Name("collapsible")]
		public bool Collapsible
		{
			get
			{
				return _003CCollapsible_003Ek__BackingField;
			}
			set
			{
				_003CCollapsible_003Ek__BackingField = value;
			}
		}

		[Name("collapsed")]
		public bool Collapsed
		{
			get
			{
				return _003CCollapsed_003Ek__BackingField;
			}
			set
			{
				_003CCollapsed_003Ek__BackingField = value;
			}
		}

		[Name("collapsedWidth")]
		public Union<string, int> CollapsedWidth
		{
			get
			{
				return _003CCollapsedWidth_003Ek__BackingField;
			}
			set
			{
				_003CCollapsedWidth_003Ek__BackingField = value;
			}
		}

		[Name("onCollapse")]
		public Action<bool> OnCollapse
		{
			get
			{
				return _003COnCollapse_003Ek__BackingField;
			}
			set
			{
				_003COnCollapse_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Sider, {props}, {children})")]
	public extern Sider(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Sider source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Sider source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
