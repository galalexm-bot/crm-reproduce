using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Tasks.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class EmptyEntityWorkLogExtension : IWorkLogExtension
{
	public Guid Uid => new Guid("{2B3A2E3D-ED52-4C6B-948C-40FAE0F1A123}");

	public Guid BaseObjectUid => Guid.Empty;

	public virtual List<Guid> ObjectUidList => new List<Guid> { BaseObjectUid };

	public virtual List<Guid> DefaultObjectsUidsList => new List<Guid>();

	public IUser DefaultHarmonizator(IEntity entity)
	{
		return GetDefaultHarmonizator(entity);
	}

	protected virtual IUser GetDefaultHarmonizator(IEntity entity)
	{
		return WorkLogExtensionHelper.DefaultHarmonizator();
	}

	public virtual WorkTime? PlanWorkLog(IEntity entity)
	{
		return null;
	}
}
