using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Web;
using Orchard.Mvc.Extensions;

namespace Orchard.Environment.State;

public class ContextState<T> where T : class
{
	private readonly string _name;

	private readonly Func<T> _defaultValue;

	public ContextState(string name)
	{
		_name = name;
	}

	public ContextState(string name, Func<T> defaultValue)
	{
		_name = name;
		_defaultValue = defaultValue;
	}

	public T GetState()
	{
		if (HttpContext.Current.IsBackgroundHttpContext())
		{
			object obj = ((CallContext.LogicalGetData(_name) is ObjectHandle objectHandle && !RemotingServices.IsTransparentProxy(objectHandle)) ? objectHandle.Unwrap() : null);
			if (obj == null && _defaultValue != null)
			{
				CallContext.LogicalSetData(_name, new ObjectHandle(obj = _defaultValue()));
				return obj as T;
			}
			return obj as T;
		}
		if (HttpContext.Current.Items[_name] == null)
		{
			HttpContext.Current.Items[_name] = ((_defaultValue == null) ? null : _defaultValue());
		}
		return HttpContext.Current.Items[_name] as T;
	}

	public void SetState(T state)
	{
		if (HttpContext.Current.IsBackgroundHttpContext())
		{
			CallContext.LogicalSetData(_name, new ObjectHandle(state));
		}
		else
		{
			HttpContext.Current.Items[_name] = state;
		}
	}
}
