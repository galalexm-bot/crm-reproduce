using System;
using System.Collections.Generic;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Services;

public class WorkItemTypeCatalogService : IWorkItemTypeCatalogService
{
	private readonly Set<Type> registeredTypes = new Set<Type>();

	public ICollection<Type> RegisteredWorkItemTypes => registeredTypes.AsReadOnly();

	public void CreateEachWorkItem<TWorkItem>(WorkItem parentWorkItem, Action<TWorkItem> action)
	{
		Guard.ArgumentNotNull(parentWorkItem, "parentWorkItem");
		Guard.ArgumentNotNull(action, "action");
		foreach (Type registeredType in registeredTypes)
		{
			if (typeof(TWorkItem).IsAssignableFrom(registeredType))
			{
				action((TWorkItem)parentWorkItem.Items.AddNew(registeredType));
			}
		}
	}

	public void CreateEachWorkItem(Type workItemType, WorkItem parentWorkItem, Action<WorkItem> action)
	{
		Guard.ArgumentNotNull(parentWorkItem, "parentWorkItem");
		Guard.ArgumentNotNull(action, "action");
		foreach (Type registeredType in registeredTypes)
		{
			if (workItemType.IsAssignableFrom(registeredType))
			{
				action((WorkItem)parentWorkItem.Items.AddNew(registeredType));
			}
		}
	}

	public void RegisterWorkItem<TWorkItem>() where TWorkItem : WorkItem
	{
		RegisterWorkItem(typeof(TWorkItem));
	}

	public void RegisterWorkItem(Type workItemType)
	{
		Guard.TypeIsAssignableFromType(workItemType, typeof(WorkItem), "workItemType");
		registeredTypes.Add(workItemType);
	}
}
