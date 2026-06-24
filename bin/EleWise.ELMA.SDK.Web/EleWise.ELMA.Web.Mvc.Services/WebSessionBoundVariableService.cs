using System;
using System.Web;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Services;

public class WebSessionBoundVariableService : ISessionBoundVariableService, IAbstractBoundVariableService
{
	[Serializable]
	private class CachedNull
	{
		public byte Value { get; set; }
	}

	private static readonly CachedNull NullValue = new CachedNull
	{
		Value = 0
	};

	private readonly IHttpContextAccessor httpContextAccessor;

	public WebSessionBoundVariableService(IHttpContextAccessor httpContextAccessor)
	{
		this.httpContextAccessor = httpContextAccessor;
	}

	public bool Contains(string name)
	{
		HttpSessionStateBase httpSessionStateBase = SafeGetHttpSession();
		if (httpSessionStateBase != null)
		{
			return httpSessionStateBase[name] != null;
		}
		return ContextVars.Contains(name);
	}

	public T Get<T>(string name)
	{
		if (!TryGetValue<T>(name, out var value))
		{
			throw new VariableNotFoundException(name);
		}
		return value;
	}

	public bool TryGetValue<T>(string name, out T value)
	{
		HttpSessionStateBase httpSessionStateBase = SafeGetHttpSession();
		object obj = ((httpSessionStateBase != null) ? httpSessionStateBase[name] : ((object)ContextVars.GetOrDefault<T>(name)));
		if (obj == null)
		{
			value = default(T);
			return false;
		}
		if (obj is CachedNull)
		{
			value = default(T);
			return true;
		}
		value = (T)obj;
		return true;
	}

	public void Set(string name, object value)
	{
		HttpSessionStateBase httpSessionStateBase = SafeGetHttpSession();
		if (httpSessionStateBase != null)
		{
			httpSessionStateBase[name] = AssembleValue(value);
		}
		else
		{
			ContextVars.Set(name, AssembleValue(value));
		}
	}

	public void Remove(string key)
	{
		HttpSessionStateBase httpSessionStateBase = SafeGetHttpSession();
		if (httpSessionStateBase != null)
		{
			httpSessionStateBase.Remove(key);
		}
		else
		{
			ContextVars.Remove(key);
		}
	}

	private static object AssembleValue<T>(T value)
	{
		return ((object)value) ?? NullValue;
	}

	private HttpSessionStateBase SafeGetHttpSession()
	{
		return httpContextAccessor.Current()?.Session;
	}
}
