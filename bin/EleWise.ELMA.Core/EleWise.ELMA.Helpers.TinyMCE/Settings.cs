using System;
using Bridge;

namespace EleWise.ELMA.Helpers.TinyMCE;

[ObjectLiteral]
public sealed class Settings
{
	private bool _003CReadOnly_003Ek__BackingField;

	private bool _003CNeedButtonELMA_003Ek__BackingField;

	private bool _003CNeedButtonSource_003Ek__BackingField;

	private Action<string> _003COnChangeCallback_003Ek__BackingField;

	private string _003CTextAreaSelector_003Ek__BackingField;

	[Name("readonly")]
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

	[Name("needButtonELMA")]
	public bool NeedButtonELMA
	{
		get
		{
			return _003CNeedButtonELMA_003Ek__BackingField;
		}
		set
		{
			_003CNeedButtonELMA_003Ek__BackingField = value;
		}
	}

	[Name("needButtonSource")]
	public bool NeedButtonSource
	{
		get
		{
			return _003CNeedButtonSource_003Ek__BackingField;
		}
		set
		{
			_003CNeedButtonSource_003Ek__BackingField = value;
		}
	}

	[Name("onChangeCallback")]
	public Action<string> OnChangeCallback
	{
		get
		{
			return _003COnChangeCallback_003Ek__BackingField;
		}
		set
		{
			_003COnChangeCallback_003Ek__BackingField = value;
		}
	}

	[Name("textAreaSelector")]
	public string TextAreaSelector
	{
		get
		{
			return _003CTextAreaSelector_003Ek__BackingField;
		}
		set
		{
			_003CTextAreaSelector_003Ek__BackingField = value;
		}
	}
}
