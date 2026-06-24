using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class CookieWrapper : ICookieWrapper
{
	private readonly Cookie cookie;

	public string Name => cookie.get_Name();

	public string Domain => cookie.get_Domain();

	public string Path => cookie.get_Path();

	public string Value => cookie.get_Value();

	public CookieWrapper(Cookie cookie)
	{
		this.cookie = cookie;
	}
}
