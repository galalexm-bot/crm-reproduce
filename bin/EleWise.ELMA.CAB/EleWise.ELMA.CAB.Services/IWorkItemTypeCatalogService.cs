using System;
using System.Collections.Generic;

namespace EleWise.ELMA.CAB.Services;

public interface IWorkItemTypeCatalogService
{
	ICollection<Type> RegisteredWorkItemTypes { get; }

	void CreateEachWorkItem<TWorkItem>(WorkItem parentWorkItem, Action<TWorkItem> action);

	void CreateEachWorkItem(Type workItemType, WorkItem parentWorkItem, Action<WorkItem> action);

	void RegisterWorkItem<TWorkItem>() where TWorkItem : WorkItem;

	void RegisterWorkItem(Type workItemType);
}
