using System;
using System.Diagnostics;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Instrumentation;

public interface ITraceSourceCatalogService
{
	ReadOnlyDictionary<string, TraceSource> TraceSources { get; }

	event EventHandler<DataEventArgs<TraceSource>> TraceSourceAdded;

	TraceSource GetTraceSource(string sourceName);
}
