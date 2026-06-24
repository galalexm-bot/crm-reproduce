using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class MonacoEditor
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CId_003Ek__BackingField;

		private string _003CWidth_003Ek__BackingField;

		private string _003CHeight_003Ek__BackingField;

		private string _003CBorder_003Ek__BackingField;

		private Action _003COnLoaded_003Ek__BackingField;

		private string _003CValue_003Ek__BackingField;

		private string _003CLanguage_003Ek__BackingField;

		private string _003CTheme_003Ek__BackingField;

		private object _003CContext_003Ek__BackingField;

		private string _003CHost_003Ek__BackingField;

		private string _003CFileName_003Ek__BackingField;

		private Action<string> _003CSetText_003Ek__BackingField;

		private Action _003CSaveText_003Ek__BackingField;

		private string _003CAuthToken_003Ek__BackingField;

		private int _003CPosition_003Ek__BackingField;

		private bool _003CReadOnly_003Ek__BackingField;

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

		[Name("width")]
		public string Width
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

		[Name("height")]
		public string Height
		{
			get
			{
				return _003CHeight_003Ek__BackingField;
			}
			set
			{
				_003CHeight_003Ek__BackingField = value;
			}
		}

		[Name("border")]
		public string Border
		{
			get
			{
				return _003CBorder_003Ek__BackingField;
			}
			set
			{
				_003CBorder_003Ek__BackingField = value;
			}
		}

		[Name("onLoaded")]
		public Action OnLoaded
		{
			get
			{
				return _003COnLoaded_003Ek__BackingField;
			}
			set
			{
				_003COnLoaded_003Ek__BackingField = value;
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

		[Name("language")]
		public string Language
		{
			get
			{
				return _003CLanguage_003Ek__BackingField;
			}
			set
			{
				_003CLanguage_003Ek__BackingField = value;
			}
		}

		[Name("theme")]
		public string Theme
		{
			get
			{
				return _003CTheme_003Ek__BackingField;
			}
			set
			{
				_003CTheme_003Ek__BackingField = value;
			}
		}

		[Name("context")]
		public object Context
		{
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			set
			{
				_003CContext_003Ek__BackingField = value;
			}
		}

		[Name("host")]
		public string Host
		{
			get
			{
				return _003CHost_003Ek__BackingField;
			}
			set
			{
				_003CHost_003Ek__BackingField = value;
			}
		}

		[Name("fileName")]
		public string FileName
		{
			get
			{
				return _003CFileName_003Ek__BackingField;
			}
			set
			{
				_003CFileName_003Ek__BackingField = value;
			}
		}

		[Name("setText")]
		public Action<string> SetText
		{
			get
			{
				return _003CSetText_003Ek__BackingField;
			}
			set
			{
				_003CSetText_003Ek__BackingField = value;
			}
		}

		[Name("saveText")]
		public Action SaveText
		{
			get
			{
				return _003CSaveText_003Ek__BackingField;
			}
			set
			{
				_003CSaveText_003Ek__BackingField = value;
			}
		}

		[Name("authToken")]
		public string AuthToken
		{
			get
			{
				return _003CAuthToken_003Ek__BackingField;
			}
			set
			{
				_003CAuthToken_003Ek__BackingField = value;
			}
		}

		[Name("position")]
		public int Position
		{
			get
			{
				return _003CPosition_003Ek__BackingField;
			}
			set
			{
				_003CPosition_003Ek__BackingField = value;
			}
		}

		[Name("readOnly")]
		public bool ReadOnly
		{
			get
			{
				return _003CReadOnly_003Ek__BackingField;
			}
			set
			{
				_003CReadOnly_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaCoreUI.MonacoEditor, {props}, {children})")]
	public extern MonacoEditor(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(MonacoEditor source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(MonacoEditor source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
