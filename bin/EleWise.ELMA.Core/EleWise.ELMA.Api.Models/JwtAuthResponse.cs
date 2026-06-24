using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
[ObjectLiteral]
public class JwtAuthResponse
{
	private string _003CAuthToken_003Ek__BackingField;

	private string _003CRefreshToken_003Ek__BackingField;

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

	public string RefreshToken
	{
		get
		{
			return _003CRefreshToken_003Ek__BackingField;
		}
		set
		{
			_003CRefreshToken_003Ek__BackingField = value;
		}
	}
}
