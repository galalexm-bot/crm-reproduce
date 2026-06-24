using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class AbstractCheckboxProps<T> : BaseProps, IHasDataTestId
{
	private string _003CId_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private bool _003CDisabled_003Ek__BackingField;

	private bool _003CChecked_003Ek__BackingField;

	private string _003CValue_003Ek__BackingField;

	private string _003CDataTestId_003Ek__BackingField;

	private Action<T> _003COnChange_003Ek__BackingField;

	private Action<MouseEvent<HTMLInputElement>> _003COnClick_003Ek__BackingField;

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

	[Name("checked")]
	public bool Checked
	{
		get
		{
			return _003CChecked_003Ek__BackingField;
		}
		set
		{
			_003CChecked_003Ek__BackingField = value;
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

	[Name("dataTestId")]
	public string DataTestId
	{
		get
		{
			return _003CDataTestId_003Ek__BackingField;
		}
		set
		{
			_003CDataTestId_003Ek__BackingField = value;
		}
	}

	[Name("onChange")]
	public Action<T> OnChange
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

	[Name("onClick")]
	public Action<MouseEvent<HTMLInputElement>> OnClick
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
}
