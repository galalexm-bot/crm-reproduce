namespace EleWise.ELMA.TestFramework.Results;

internal sealed class AssertResult
{
	private bool _003CPassed_003Ek__BackingField;

	private object _003CActual_003Ek__BackingField;

	private object _003CExpected_003Ek__BackingField;

	private bool _003CNegative_003Ek__BackingField;

	private string _003CMessage_003Ek__BackingField;

	private string _003CSource_003Ek__BackingField;

	private string _003CModule_003Ek__BackingField;

	private string _003CId_003Ek__BackingField;

	public bool Passed
	{
		get
		{
			return _003CPassed_003Ek__BackingField;
		}
		set
		{
			_003CPassed_003Ek__BackingField = value;
		}
	}

	public object Actual
	{
		get
		{
			return _003CActual_003Ek__BackingField;
		}
		set
		{
			_003CActual_003Ek__BackingField = value;
		}
	}

	public object Expected
	{
		get
		{
			return _003CExpected_003Ek__BackingField;
		}
		set
		{
			_003CExpected_003Ek__BackingField = value;
		}
	}

	public bool Negative
	{
		get
		{
			return _003CNegative_003Ek__BackingField;
		}
		set
		{
			_003CNegative_003Ek__BackingField = value;
		}
	}

	public string Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			_003CMessage_003Ek__BackingField = value;
		}
	}

	public string Source
	{
		get
		{
			return _003CSource_003Ek__BackingField;
		}
		set
		{
			_003CSource_003Ek__BackingField = value;
		}
	}

	public string Module
	{
		get
		{
			return _003CModule_003Ek__BackingField;
		}
		set
		{
			_003CModule_003Ek__BackingField = value;
		}
	}

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
}
