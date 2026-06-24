using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class CollapsePanel
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CHeader_003Ek__BackingField;

		private bool _003CCollapsed_003Ek__BackingField;

		private bool _003CCollapsible_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private PanelType _003CPanelType_003Ek__BackingField;

		private Action _003COnChange_003Ek__BackingField;

		private bool _003CAsyncLoading_003Ek__BackingField;

		private string _003CCssClass_003Ek__BackingField;

		private Text.TextType _003CTextType_003Ek__BackingField;

		[Name("header")]
		public Union<ReactElement, string> Header
		{
			get
			{
				return _003CHeader_003Ek__BackingField;
			}
			set
			{
				_003CHeader_003Ek__BackingField = value;
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

		[Name("disabled")]
		public bool Disabled
		{
			get
			{
				return _003CDisabled_003Ek__BackingField;
			}
			set
			{
				_003CDisabled_003Ek__BackingField = value;
			}
		}

		[Name("panelType")]
		public PanelType PanelType
		{
			get
			{
				return _003CPanelType_003Ek__BackingField;
			}
			set
			{
				_003CPanelType_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action OnChange
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

		[Name("asyncLoading")]
		public bool AsyncLoading
		{
			get
			{
				return _003CAsyncLoading_003Ek__BackingField;
			}
			set
			{
				_003CAsyncLoading_003Ek__BackingField = value;
			}
		}

		[Name("cssClass")]
		public string CssClass
		{
			get
			{
				return _003CCssClass_003Ek__BackingField;
			}
			set
			{
				_003CCssClass_003Ek__BackingField = value;
			}
		}

		[Name("textType")]
		public Text.TextType TextType
		{
			get
			{
				return _003CTextType_003Ek__BackingField;
			}
			set
			{
				_003CTextType_003Ek__BackingField = value;
			}
		}

		public Props()
		{
			PanelType = PanelType.Default;
			Collapsible = true;
		}
	}

	[Template("React.createElement(elmaComponents.CollapsePanel, {props}, {children})")]
	public extern CollapsePanel(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.CollapsePanel, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern CollapsePanel(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(CollapsePanel source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(CollapsePanel source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
