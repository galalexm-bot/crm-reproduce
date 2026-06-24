using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
public class TaskBaseWorkLogObjectSearchExtension : WorkLogObjectSearchExtensionBase
{
	public override Guid Uid => new Guid("{7396752C-06D4-4745-B413-C010A1061FD0}");

	public override Type BaseObjectType => typeof(ITaskBase);

	protected override void Init()
	{
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
		AddProperty((IWorkLogObjectSearchFilter p) => p.EndDate);
	}

	public override void SetupFilter(IEntityFilter entityFilter, IWorkLogObjectSearchFilter filter)
	{
		base.SetupFilter(entityFilter, filter);
		if (entityFilter is ITaskBaseFilter taskBaseFilter)
		{
			taskBaseFilter.CreationDate = filter.CreationDate;
			taskBaseFilter.Subject = filter.Name;
			taskBaseFilter.EndDate = new RelativeDateTime(filter.EndDate.From, filter.EndDate.To);
			taskBaseFilter.CreationAuthor = filter.CreationAuthor;
		}
	}
}
