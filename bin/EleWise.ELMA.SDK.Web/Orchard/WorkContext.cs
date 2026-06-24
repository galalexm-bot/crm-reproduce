using System;
using System.Web;
using Orchard.Environment.Extensions.Models;
using Orchard.Security;
using Orchard.Settings;

namespace Orchard;

public abstract class WorkContext
{
	public HttpContextBase HttpContext
	{
		get
		{
			return GetState<HttpContextBase>("HttpContext");
		}
		set
		{
			SetState("HttpContext", value);
		}
	}

	public dynamic Layout
	{
		get
		{
			return GetState<object>("Layout");
		}
		set
		{
			SetState("Layout", value);
		}
	}

	public ISite CurrentSite
	{
		get
		{
			return GetState<ISite>("CurrentSite");
		}
		set
		{
			SetState("CurrentSite", value);
		}
	}

	public IUser CurrentUser
	{
		get
		{
			return GetState<IUser>("CurrentUser");
		}
		set
		{
			SetState("CurrentUser", value);
		}
	}

	public ExtensionDescriptor CurrentTheme
	{
		get
		{
			return GetState<ExtensionDescriptor>("CurrentTheme");
		}
		set
		{
			SetState("CurrentTheme", value);
		}
	}

	public string CurrentCulture
	{
		get
		{
			return GetState<string>("CurrentCulture");
		}
		set
		{
			SetState("CurrentCulture", value);
		}
	}

	public string CurrentCalendar
	{
		get
		{
			return GetState<string>("CurrentCalendar");
		}
		set
		{
			SetState("CurrentCalendar", value);
		}
	}

	public TimeZoneInfo CurrentTimeZone
	{
		get
		{
			return GetState<TimeZoneInfo>("CurrentTimeZone");
		}
		set
		{
			SetState("CurrentTimeZone", value);
		}
	}

	public abstract T Resolve<T>();

	public abstract object Resolve(Type serviceType);

	public abstract bool TryResolve<T>(out T service);

	public abstract bool TryResolve(Type serviceType, out object service);

	public abstract T GetState<T>(string name);

	public abstract void SetState<T>(string name, T value);
}
