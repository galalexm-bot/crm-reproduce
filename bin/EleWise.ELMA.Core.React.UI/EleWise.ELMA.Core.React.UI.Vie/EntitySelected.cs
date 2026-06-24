using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class EntitySelected
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CId_003Ek__BackingField;

		private string _003CListId_003Ek__BackingField;

		private string _003CName_003Ek__BackingField;

		private string _003CValue_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private string _003CHref_003Ek__BackingField;

		private Action<object> _003COnClick_003Ek__BackingField;

		private Action<FormEvent<HTMLButtonElement>> _003COnClickRemove_003Ek__BackingField;

		private ReactElement _003CIcon_003Ek__BackingField;

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

		[Name("listId")]
		public string ListId
		{
			get
			{
				return _003CListId_003Ek__BackingField;
			}
			set
			{
				_003CListId_003Ek__BackingField = value;
			}
		}

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

		[Name("href")]
		public string Href
		{
			get
			{
				return _003CHref_003Ek__BackingField;
			}
			set
			{
				_003CHref_003Ek__BackingField = value;
			}
		}

		[Name("onClick")]
		public Action<object> OnClick
		{
			get
			{
				return _003COnClick_003Ek__BackingField;
			}
			set
			{
				_003COnClick_003Ek__BackingField = value;
			}
		}

		[Name("onClickRemove")]
		public Action<FormEvent<HTMLButtonElement>> OnClickRemove
		{
			get
			{
				return _003COnClickRemove_003Ek__BackingField;
			}
			set
			{
				_003COnClickRemove_003Ek__BackingField = value;
			}
		}

		[Name("icon")]
		public ReactElement Icon
		{
			get
			{
				return _003CIcon_003Ek__BackingField;
			}
			set
			{
				_003CIcon_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.EntitySelected, {props}, {children})")]
	public extern EntitySelected(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(EntitySelected source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(EntitySelected source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
