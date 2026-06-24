using System;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class ComponentDependencyAttribute : OptionalDependencyAttribute
{
	private readonly string id;

	private bool createIfNotFound;

	private Type type;

	public string ID => id;

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

	public bool CreateIfNotFound
	{
		get
		{
			return createIfNotFound;
		}
		set
		{
			createIfNotFound = value;
		}
	}

	public ComponentDependencyAttribute(string id)
	{
		Guard.ArgumentNotNull(id, "id");
		this.id = id;
	}

	public override IParameter CreateParameter(Type memberType)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		return (IParameter)new DependencyParameter(type ?? memberType, id, (Type)null, GetNotPresentBehavior(), (SearchMode)1);
	}

	private NotPresentBehavior GetNotPresentBehavior()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (createIfNotFound)
		{
			return (NotPresentBehavior)0;
		}
		if (base.Required)
		{
			return (NotPresentBehavior)2;
		}
		return (NotPresentBehavior)1;
	}
}
