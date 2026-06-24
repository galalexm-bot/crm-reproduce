using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class ServiceDependencyAttribute : OptionalDependencyAttribute
{
	private class ServiceDependencyParameter : IParameter
	{
		private readonly bool ensureExists;

		private readonly Type serviceType;

		public ServiceDependencyParameter(Type serviceType, bool ensureExists)
		{
			this.serviceType = serviceType;
			this.ensureExists = ensureExists;
		}

		public Type GetParameterType(IBuilderContext context)
		{
			return serviceType;
		}

		public object GetValue(IBuilderContext context)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			WorkItem workItem = (WorkItem)((IReadableLocator)context.get_Locator()).Get((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null));
			return workItem.Services.Get(serviceType, ensureExists);
		}
	}

	private Type type;

	public Type Type
	{
		get
		{
			return type;
		}
		set
		{
			type = value;
		}
	}

	public override IParameter CreateParameter(Type memberType)
	{
		return (IParameter)(object)new ServiceDependencyParameter(type ?? memberType, base.Required);
	}
}
