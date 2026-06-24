namespace EleWise.ELMA.Api.Models;

public sealed class ServerVersionInfo
{
	private string _003CUIVersion_003Ek__BackingField;

	private string _003CVersion_003Ek__BackingField;

	private int _003CType_003Ek__BackingField;

	private int _003CMode_003Ek__BackingField;

	private string _003CRuntimeModelHash_003Ek__BackingField;

	public string UIVersion
	{
		get
		{
			return _003CUIVersion_003Ek__BackingField;
		}
		set
		{
			_003CUIVersion_003Ek__BackingField = value;
		}
	}

	public string Version
	{
		get
		{
			return _003CVersion_003Ek__BackingField;
		}
		set
		{
			_003CVersion_003Ek__BackingField = value;
		}
	}

	public int Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public int Mode
	{
		get
		{
			return _003CMode_003Ek__BackingField;
		}
		set
		{
			_003CMode_003Ek__BackingField = value;
		}
	}

	public string RuntimeModelHash
	{
		get
		{
			return _003CRuntimeModelHash_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeModelHash_003Ek__BackingField = value;
		}
	}
}
