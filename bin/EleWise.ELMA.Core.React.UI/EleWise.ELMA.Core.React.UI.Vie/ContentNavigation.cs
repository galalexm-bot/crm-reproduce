using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class ContentNavigation
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CCnKey_003Ek__BackingField;

		private string _003CActiveKey_003Ek__BackingField;

		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private bool _003CHideTitle_003Ek__BackingField;

		private Action<string> _003COnChangeActiveKey_003Ek__BackingField;

		private Union<ReactElement, string> _003CMenuExtraContent_003Ek__BackingField;

		private Union<ReactElement, string> _003CBarExtraContent_003Ek__BackingField;

		private Action _003COnClose_003Ek__BackingField;

		private bool _003CForceVerticalView_003Ek__BackingField;

		private bool _003CCompactMode_003Ek__BackingField;

		private bool _003CDisableNested_003Ek__BackingField;

		private bool _003CVisible_003Ek__BackingField;

		private bool _003CDestroyOnClose_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseEnter_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseLeave_003Ek__BackingField;

		private Action<KeyboardEvent<HTMLElement>> _003COnKeyDown_003Ek__BackingField;

		[Name("cnKey")]
		public string CnKey
		{
			get
			{
				return _003CCnKey_003Ek__BackingField;
			}
			set
			{
				_003CCnKey_003Ek__BackingField = value;
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

		[Name("title")]
		public Union<ReactElement, string> Title
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

		[Name("hideTitle")]
		public bool HideTitle
		{
			get
			{
				return _003CHideTitle_003Ek__BackingField;
			}
			set
			{
				_003CHideTitle_003Ek__BackingField = value;
			}
		}

		[Name("onChangeActiveKey")]
		public Action<string> OnChangeActiveKey
		{
			get
			{
				return _003COnChangeActiveKey_003Ek__BackingField;
			}
			set
			{
				_003COnChangeActiveKey_003Ek__BackingField = value;
			}
		}

		[Name("menuExtraContent")]
		public Union<ReactElement, string> MenuExtraContent
		{
			get
			{
				return _003CMenuExtraContent_003Ek__BackingField;
			}
			set
			{
				_003CMenuExtraContent_003Ek__BackingField = value;
			}
		}

		[Name("barExtraContent")]
		public Union<ReactElement, string> BarExtraContent
		{
			get
			{
				return _003CBarExtraContent_003Ek__BackingField;
			}
			set
			{
				_003CBarExtraContent_003Ek__BackingField = value;
			}
		}

		[Name("onClose")]
		public Action OnClose
		{
			get
			{
				return _003COnClose_003Ek__BackingField;
			}
			set
			{
				_003COnClose_003Ek__BackingField = value;
			}
		}

		[Name("forceVerticalView")]
		public bool ForceVerticalView
		{
			get
			{
				return _003CForceVerticalView_003Ek__BackingField;
			}
			set
			{
				_003CForceVerticalView_003Ek__BackingField = value;
			}
		}

		[Name("compactMode")]
		public bool CompactMode
		{
			get
			{
				return _003CCompactMode_003Ek__BackingField;
			}
			set
			{
				_003CCompactMode_003Ek__BackingField = value;
			}
		}

		[Name("disableNested")]
		public bool DisableNested
		{
			get
			{
				return _003CDisableNested_003Ek__BackingField;
			}
			set
			{
				_003CDisableNested_003Ek__BackingField = value;
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

		[Name("destroyOnClose")]
		public bool DestroyOnClose
		{
			get
			{
				return _003CDestroyOnClose_003Ek__BackingField;
			}
			set
			{
				_003CDestroyOnClose_003Ek__BackingField = value;
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

		[Name("onKeyDown")]
		public Action<KeyboardEvent<HTMLElement>> OnKeyDown
		{
			get
			{
				return _003COnKeyDown_003Ek__BackingField;
			}
			set
			{
				_003COnKeyDown_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public class ParentInfo
	{
		private Action _003CCallback_003Ek__BackingField;

		private Func<Union<ReactElement, string>> _003CTitle_003Ek__BackingField;

		[Name("callback")]
		public Action Callback
		{
			get
			{
				return _003CCallback_003Ek__BackingField;
			}
			set
			{
				_003CCallback_003Ek__BackingField = value;
			}
		}

		[Name("title")]
		public Func<Union<ReactElement, string>> Title
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
	}

	[Template("React.createElement(elmaComponents.ContentNavigation, {props}, {children})")]
	public extern ContentNavigation(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.ContentNavigation, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern ContentNavigation(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(ContentNavigation source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(ContentNavigation source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
