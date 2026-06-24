using System.Collections.Generic;

namespace EleWise.ELMA.Core.Api;

public class RequestOptions
{
	public const string AdditionalHeaders = "AdditionalHeaders";

	private readonly IDictionary<string, string> _003CHeaders_003Ek__BackingField;

	public IDictionary<string, string> Headers => _003CHeaders_003Ek__BackingField;

	public RequestOptions()
	{
		_003CHeaders_003Ek__BackingField = (IDictionary<string, string>)(object)new Dictionary<string, string>();
	}
}
