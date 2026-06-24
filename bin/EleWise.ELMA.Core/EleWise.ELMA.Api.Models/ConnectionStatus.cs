using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
public sealed class ConnectionStatus
{
	private bool _003CHasConnection_003Ek__BackingField;

	private string[] _003CErrors_003Ek__BackingField;

	public bool HasConnection
	{
		get
		{
			return _003CHasConnection_003Ek__BackingField;
		}
		set
		{
			_003CHasConnection_003Ek__BackingField = value;
		}
	}

	public string[] Errors
	{
		get
		{
			return _003CErrors_003Ek__BackingField;
		}
		set
		{
			_003CErrors_003Ek__BackingField = value;
		}
	}
}
