using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class RequestWrapper : IRequestWrapper
{
	internal readonly IRequest request;

	public Uri Url => request.get_Url();

	public string LocalPath => request.get_LocalPath();

	public INameValueCollectionWrapper QueryString => new NameValueCollectionWrapper(request.get_QueryString());

	public INameValueCollectionWrapper Headers => new NameValueCollectionWrapper(request.get_QueryString());

	public IDictionary<string, ICookieWrapper> Cookies => ((IEnumerable<KeyValuePair<string, Cookie>>)request.get_Cookies()).ToDictionary((Func<KeyValuePair<string, Cookie>, string>)((KeyValuePair<string, Cookie> key) => key.Key), (Func<KeyValuePair<string, Cookie>, ICookieWrapper>)((KeyValuePair<string, Cookie> value) => new CookieWrapper(value.Value)));

	public IPrincipal User => request.get_User();

	public IDictionary<string, object> Environment => request.get_Environment();

	public RequestWrapper(IRequest request)
	{
		this.request = request;
	}

	public async Task<INameValueCollectionWrapper> ReadForm()
	{
		return new NameValueCollectionWrapper(await request.ReadForm());
	}

	public static bool operator ==(RequestWrapper wrapper, IRequest request)
	{
		return wrapper?.request == request;
	}

	public static bool operator !=(RequestWrapper wrapper, IRequest request)
	{
		return !(wrapper == request);
	}
}
