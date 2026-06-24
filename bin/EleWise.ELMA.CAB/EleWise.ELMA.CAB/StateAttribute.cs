using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
public sealed class StateAttribute : ParameterAttribute
{
	private class StateParameter : KnownTypeParameter
	{
		private readonly string id;

		public StateParameter(Type type, string id)
			: base(type)
		{
			this.id = id;
		}

		public override object GetValue(IBuilderContext context)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			DependencyResolutionLocatorKey val = new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null);
			WorkItem workItem = (WorkItem)((IReadableLocator)context.get_Locator()).Get((object)val);
			if (id != null)
			{
				return workItem.State[id];
			}
			foreach (string key in workItem.State.Keys)
			{
				if (base.type.IsAssignableFrom(workItem.State[key].GetType()))
				{
					return workItem.State[key];
				}
			}
			return null;
		}
	}

	private readonly string id;

	public StateAttribute()
	{
	}

	public StateAttribute(string id)
	{
		this.id = id;
	}

	public override IParameter CreateParameter(Type memberType)
	{
		return (IParameter)(object)new StateParameter(memberType, id);
	}
}
