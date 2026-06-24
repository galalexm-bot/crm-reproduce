using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Instrumentation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
public class TraceSourceAttribute : ParameterAttribute
{
	private class TraceSourceParameter : KnownTypeParameter
	{
		private readonly string sourceName;

		public TraceSourceParameter(Type memberType, string sourceName)
			: base(memberType)
		{
			this.sourceName = sourceName;
		}

		public override object GetValue(IBuilderContext context)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			DependencyResolutionLocatorKey val = new DependencyResolutionLocatorKey(typeof(ITraceSourceCatalogService), (string)null);
			return ((ITraceSourceCatalogService)((IReadableLocator)context.get_Locator()).Get((object)val))?.GetTraceSource(sourceName);
		}
	}

	private readonly string sourceName;

	public string SourceName => sourceName;

	public TraceSourceAttribute(string sourceName)
	{
		this.sourceName = sourceName;
	}

	public override IParameter CreateParameter(Type memberType)
	{
		return (IParameter)(object)new TraceSourceParameter(memberType, sourceName);
	}
}
