using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class EntityList
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CId_003Ek__BackingField;

		private bool _003CIsMultiple_003Ek__BackingField;

		private string _003CValue_003Ek__BackingField;

		private Action<string> _003COnChange_003Ek__BackingField;

		private Action<string> _003COnSearch_003Ek__BackingField;

		private Action<object> _003COnBlur_003Ek__BackingField;

		private Action<string, object> _003COnSelect_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private OptionData[] _003COptions_003Ek__BackingField;

		private ReactElement _003CSelectedEntities_003Ek__BackingField;

		private ReactElement[] _003CButtons_003Ek__BackingField;

		private Action _003COnClickClean_003Ek__BackingField;

		private Action<bool> _003COnClickOpenDropdown_003Ek__BackingField;

		private Action _003COnFocus_003Ek__BackingField;

		private Action _003COpenEntityLink_003Ek__BackingField;

		private bool _003CWithLink_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		[Name("id")]
		public string Id
		{
			get
			{
				return _003CId_003Ek__BackingField;
			}
			set
			{
				_003CId_003Ek__BackingField = value;
			}
		}

		[Name("isMultiple")]
		public bool IsMultiple
		{
			get
			{
				return _003CIsMultiple_003Ek__BackingField;
			}
			set
			{
				_003CIsMultiple_003Ek__BackingField = value;
			}
		}

		[Name("value")]
		public string Value
		{
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			set
			{
				_003CValue_003Ek__BackingField = value;
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

		[Name("onSearch")]
		public Action<string> OnSearch
		{
			get
			{
				return _003COnSearch_003Ek__BackingField;
			}
			set
			{
				_003COnSearch_003Ek__BackingField = value;
			}
		}

		[Name("onBlur")]
		public Action<object> OnBlur
		{
			get
			{
				return _003COnBlur_003Ek__BackingField;
			}
			set
			{
				_003COnBlur_003Ek__BackingField = value;
			}
		}

		[Name("onSelect")]
		public Action<string, object> OnSelect
		{
			get
			{
				return _003COnSelect_003Ek__BackingField;
			}
			set
			{
				_003COnSelect_003Ek__BackingField = value;
			}
		}

		[Name("placeholder")]
		public string Placeholder
		{
			get
			{
				return _003CPlaceholder_003Ek__BackingField;
			}
			set
			{
				_003CPlaceholder_003Ek__BackingField = value;
			}
		}

		[Name("options")]
		public OptionData[] Options
		{
			get
			{
				return _003COptions_003Ek__BackingField;
			}
			set
			{
				_003COptions_003Ek__BackingField = value;
			}
		}

		[Name("selectedEntities")]
		public ReactElement SelectedEntities
		{
			get
			{
				return _003CSelectedEntities_003Ek__BackingField;
			}
			set
			{
				_003CSelectedEntities_003Ek__BackingField = value;
			}
		}

		[Name("buttons")]
		public ReactElement[] Buttons
		{
			get
			{
				return _003CButtons_003Ek__BackingField;
			}
			set
			{
				_003CButtons_003Ek__BackingField = value;
			}
		}

		[Name("onClickClean")]
		public Action OnClickClean
		{
			get
			{
				return _003COnClickClean_003Ek__BackingField;
			}
			set
			{
				_003COnClickClean_003Ek__BackingField = value;
			}
		}

		[Name("onClickOpenDropdown")]
		public Action<bool> OnClickOpenDropdown
		{
			get
			{
				return _003COnClickOpenDropdown_003Ek__BackingField;
			}
			set
			{
				_003COnClickOpenDropdown_003Ek__BackingField = value;
			}
		}

		[Name("onFocus")]
		public Action OnFocus
		{
			get
			{
				return _003COnFocus_003Ek__BackingField;
			}
			set
			{
				_003COnFocus_003Ek__BackingField = value;
			}
		}

		[Name("openEntityLink")]
		public Action OpenEntityLink
		{
			get
			{
				return _003COpenEntityLink_003Ek__BackingField;
			}
			set
			{
				_003COpenEntityLink_003Ek__BackingField = value;
			}
		}

		[Name("withLink")]
		public bool WithLink
		{
			get
			{
				return _003CWithLink_003Ek__BackingField;
			}
			set
			{
				_003CWithLink_003Ek__BackingField = value;
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
	}

	[Template("React.createElement(elmaComponents.EntitySelection, {props}, {children})")]
	public extern EntityList(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(EntityList source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(EntityList source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
