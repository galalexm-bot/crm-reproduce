using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Orchard.ContentManagement;

internal class CallSiteCollection : ConcurrentDictionary<string, CallSite<Func<CallSite, object, object>>>
{
	private readonly Func<string, CallSite<Func<CallSite, object, object>>> _valueFactory;

	public CallSiteCollection(Func<string, CallSite<Func<CallSite, object, object>>> callSiteFactory)
	{
		_valueFactory = callSiteFactory;
	}

	public CallSiteCollection(Func<string, CallSiteBinder> callSiteBinderFactory)
	{
		_valueFactory = (string key) => CallSite<Func<CallSite, object, object>>.Create(callSiteBinderFactory(key));
	}

	public object Invoke(object callee, string key)
	{
		CallSite<Func<CallSite, object, object>> orAdd = GetOrAdd(key, _valueFactory);
		return orAdd.Target(orAdd, callee);
	}
}
