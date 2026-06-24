using System.Collections.Generic;

namespace EleWise.ELMA.Binder;

public sealed class RequestContext
{
	private readonly string _003CUrl_003Ek__BackingField;

	private readonly Dictionary<string, string> _003CRouteData_003Ek__BackingField;

	private readonly string[] _003CAnchors_003Ek__BackingField;

	public string Url => _003CUrl_003Ek__BackingField;

	public Dictionary<string, string> RouteData => _003CRouteData_003Ek__BackingField;

	public string[] Anchors => _003CAnchors_003Ek__BackingField;

	public RequestContext(string baseUrl)
	{
		_003CUrl_003Ek__BackingField = UrlHelper.GetCurrentUrl(baseUrl);
		_003CRouteData_003Ek__BackingField = UrlHelper.ParseUrl(Url);
		_003CAnchors_003Ek__BackingField = UrlHelper.GetCurrentHashes();
	}
}
