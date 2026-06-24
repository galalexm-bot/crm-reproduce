using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Instrumentation;

public class TraceSourceCatalogService : ITraceSourceCatalogService
{
	private readonly Dictionary<string, TraceSource> sources = new Dictionary<string, TraceSource>();

	public ReadOnlyDictionary<string, TraceSource> TraceSources => new ReadOnlyDictionary<string, TraceSource>(sources);

	public event EventHandler<DataEventArgs<TraceSource>> TraceSourceAdded;

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public TraceSource GetTraceSource(string sourceName)
	{
		Guard.ArgumentNotNull(sourceName, "sourceName");
		if (sources.ContainsKey(sourceName))
		{
			return sources[sourceName];
		}
		TraceSource traceSource = new TraceSource(sourceName);
		sources.Add(traceSource.Name, traceSource);
		if (traceSource.Listeners.Count == 1 && traceSource.Listeners[0] is DefaultTraceListener)
		{
			traceSource.Listeners.Clear();
		}
		traceSource.Listeners.AddRange(Trace.Listeners);
		if (this.TraceSourceAdded != null)
		{
			this.TraceSourceAdded(this, new DataEventArgs<TraceSource>(traceSource));
		}
		return traceSource;
	}

	public void AddSharedListener(TraceListener listener)
	{
		Guard.ArgumentNotNull(listener, "listener");
		AddSharedListener(listener, string.Empty);
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public void AddSharedListener(TraceListener listener, string name)
	{
		Guard.ArgumentNotNull(listener, "listener");
		Guard.ArgumentNotNull(name, "name");
		if (name.Length != 0)
		{
			listener.Name = name;
		}
		foreach (KeyValuePair<string, TraceSource> source in sources)
		{
			source.Value.Listeners.Add(listener);
		}
	}
}
