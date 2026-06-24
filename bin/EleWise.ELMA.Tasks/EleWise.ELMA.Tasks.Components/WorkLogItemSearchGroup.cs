using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Tasks.Components;

internal class WorkLogItemSearchGroup
{
	public List<Guid> ObjectTypeUids { get; private set; }

	public List<IWorkLogObjectSearchExtension> WorkLogObjectSearchExtensions { get; private set; }

	public Guid BaseObjectType { get; private set; }

	public WorkLogItemSearchGroup(Guid baseObjectType, List<Guid> uids, List<IWorkLogObjectSearchExtension> workLogObjectSearchExtensions)
	{
		BaseObjectType = baseObjectType;
		ObjectTypeUids = uids;
		WorkLogObjectSearchExtensions = workLogObjectSearchExtensions;
	}

	public bool CanGrouping(WorkLogItemSearchGroup searchGroup)
	{
		if (searchGroup == null)
		{
			return false;
		}
		if (BaseObjectType != searchGroup.BaseObjectType)
		{
			return false;
		}
		if (searchGroup.WorkLogObjectSearchExtensions.Count != WorkLogObjectSearchExtensions.Count)
		{
			return false;
		}
		if (WorkLogObjectSearchExtensions.Any((IWorkLogObjectSearchExtension e) => !e.GroupBySearch))
		{
			return false;
		}
		if (searchGroup.WorkLogObjectSearchExtensions.Any((IWorkLogObjectSearchExtension e) => !e.GroupBySearch))
		{
			return false;
		}
		if (WorkLogObjectSearchExtensions.Any((IWorkLogObjectSearchExtension extension) => !searchGroup.WorkLogObjectSearchExtensions.Exists((IWorkLogObjectSearchExtension e) => e.Uid == extension.Uid)))
		{
			return false;
		}
		if (searchGroup.WorkLogObjectSearchExtensions.Any((IWorkLogObjectSearchExtension extension) => !WorkLogObjectSearchExtensions.Exists((IWorkLogObjectSearchExtension e) => e.Uid == extension.Uid)))
		{
			return false;
		}
		return true;
	}
}
