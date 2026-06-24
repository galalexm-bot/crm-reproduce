using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Tabs
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CActiveKey_003Ek__BackingField;

		private string _003CDefaultActiveKey_003Ek__BackingField;

		private Action<string> _003COnChange_003Ek__BackingField;

		private Action<string> _003COnRemove_003Ek__BackingField;

		private Union<ReactElement, string> _003CTabBarExtraContent_003Ek__BackingField;

		private TabStyle _003CTabStyle_003Ek__BackingField;

		private TabType _003CTabType_003Ek__BackingField;

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

		[Name("defaultActiveKey")]
		public string DefaultActiveKey
		{
			get
			{
				return _003CDefaultActiveKey_003Ek__BackingField;
			}
			set
			{
				_003CDefaultActiveKey_003Ek__BackingField = value;
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

		[Name("onRemove")]
		public Action<string> OnRemove
		{
			get
			{
				return _003COnRemove_003Ek__BackingField;
			}
			set
			{
				_003COnRemove_003Ek__BackingField = value;
			}
		}

		[Name("tabBarExtraContent")]
		public Union<ReactElement, string> TabBarExtraContent
		{
			get
			{
				return _003CTabBarExtraContent_003Ek__BackingField;
			}
			set
			{
				_003CTabBarExtraContent_003Ek__BackingField = value;
			}
		}

		[Name("tabStyle")]
		public TabStyle TabStyle
		{
			get
			{
				return _003CTabStyle_003Ek__BackingField;
			}
			set
			{
				_003CTabStyle_003Ek__BackingField = value;
			}
		}

		[Name("tabType")]
		public TabType TabType
		{
			get
			{
				return _003CTabType_003Ek__BackingField;
			}
			set
			{
				_003CTabType_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Tabs, {props}, {children})")]
	public extern Tabs(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.Tabs, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Tabs(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Tabs source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Tabs source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
