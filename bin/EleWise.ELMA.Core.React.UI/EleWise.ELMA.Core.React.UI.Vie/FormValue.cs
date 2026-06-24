using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views.FormControl;

[External]
public sealed class FormValue
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CIsReadOnly_003Ek__BackingField;

		private bool _003CIsErrorValidation_003Ek__BackingField;

		private bool _003CHideValidation_003Ek__BackingField;

		private Func<bool> _003CValidationFunc_003Ek__BackingField;

		[Name("isReadOnly")]
		public bool IsReadOnly
		{
			get
			{
				return _003CIsReadOnly_003Ek__BackingField;
			}
			set
			{
				_003CIsReadOnly_003Ek__BackingField = value;
			}
		}

		[Name("isErrorValidation")]
		public bool IsErrorValidation
		{
			get
			{
				return _003CIsErrorValidation_003Ek__BackingField;
			}
			set
			{
				_003CIsErrorValidation_003Ek__BackingField = value;
			}
		}

		[Name("hideValidation")]
		public bool HideValidation
		{
			get
			{
				return _003CHideValidation_003Ek__BackingField;
			}
			set
			{
				_003CHideValidation_003Ek__BackingField = value;
			}
		}

		[Name("validationFunction")]
		[Obsolete("Выпилить ELMA4-6705")]
		public Func<bool> ValidationFunc
		{
			get
			{
				return _003CValidationFunc_003Ek__BackingField;
			}
			set
			{
				_003CValidationFunc_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.FormValue, {props}, {children})")]
	public extern FormValue(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.FormValue, null, {children})")]
	public extern FormValue(params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(FormValue source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(FormValue source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
