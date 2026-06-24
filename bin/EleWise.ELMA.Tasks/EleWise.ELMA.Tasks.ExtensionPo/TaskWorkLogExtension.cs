using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component(Order = int.MaxValue)]
public class TaskWorkLogExtension : WorkLogExtensionBase<ITaskBase>
{
	public static readonly Guid uid = new Guid("{CCDF8E43-324F-42B2-99D1-BA6502F8C1C7}");

	public override Guid Uid => uid;

	public override List<Guid> DefaultObjectsUidsList => new List<Guid> { InterfaceActivator.UID<ITask>() };

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is ITaskBase taskBase))
		{
			return null;
		}
		return taskBase.CreationAuthor;
	}

	public override WorkTime? PlanWorkLog(IEntity entity)
	{
		if (entity is IWorkLogItem workLogItem)
		{
			return PlanWorkLog(WorkLogExtensionHelper.LoadObject(workLogItem));
		}
		if (entity is ITaskBase taskBase)
		{
			return taskBase.PlanWorkLog;
		}
		return null;
	}
}
