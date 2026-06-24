using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

internal class TaskControlTreeItem
{
	public TaskControlTreeItem Parent { get; set; }

	public List<TaskControlTreeItem> Items { get; set; }

	public Guid ObjectTypeUid { get; set; }

	public ClassMetadata Metadata { get; set; }

	public Type FilterType { get; set; }

	public TaskControlTreeItem()
	{
		Items = new List<TaskControlTreeItem>();
	}
}
