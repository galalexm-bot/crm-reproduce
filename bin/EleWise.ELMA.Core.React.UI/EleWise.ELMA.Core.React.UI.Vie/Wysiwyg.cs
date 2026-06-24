using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Wysiwyg
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private StateData _003CEditorState_003Ek__BackingField;

		private object _003CToolbar_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private string _003CLocale_003Ek__BackingField;

		private Action<StateData> _003COnEditorStateChange_003Ek__BackingField;

		[Name("editorState")]
		public StateData EditorState
		{
			get
			{
				return _003CEditorState_003Ek__BackingField;
			}
			set
			{
				_003CEditorState_003Ek__BackingField = value;
			}
		}

		[Name("toolbar")]
		public object Toolbar
		{
			get
			{
				return _003CToolbar_003Ek__BackingField;
			}
			set
			{
				_003CToolbar_003Ek__BackingField = value;
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

		[Name("locale")]
		public string Locale
		{
			get
			{
				return _003CLocale_003Ek__BackingField;
			}
			set
			{
				_003CLocale_003Ek__BackingField = value;
			}
		}

		[Name("onEditorStateChange")]
		public Action<StateData> OnEditorStateChange
		{
			get
			{
				return _003COnEditorStateChange_003Ek__BackingField;
			}
			set
			{
				_003COnEditorStateChange_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public class StateData
	{
		private object _003CState_003Ek__BackingField;

		private dynamic _003CHtml_003Ek__BackingField;

		public object State
		{
			get
			{
				return _003CState_003Ek__BackingField;
			}
			set
			{
				_003CState_003Ek__BackingField = value;
			}
		}

		public dynamic Html
		{
			get
			{
				return _003CHtml_003Ek__BackingField;
			}
			set
			{
				_003CHtml_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Wysiwyg, {props}, {children})")]
	public extern Wysiwyg(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Wysiwyg source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Wysiwyg source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
