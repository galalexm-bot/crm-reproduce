using System;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class WorkItemExtensionAttribute : Attribute
{
	private readonly Type workItemType;

	public Type WorkItemType => workItemType;

	public WorkItemExtensionAttribute(Type workItemType)
	{
		Guard.ArgumentNotNull(workItemType, "workItemType");
		this.workItemType = workItemType;
	}
}
