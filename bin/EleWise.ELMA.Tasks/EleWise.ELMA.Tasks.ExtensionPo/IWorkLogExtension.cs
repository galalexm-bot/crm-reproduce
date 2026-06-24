using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogExtension
{
	Guid Uid { get; }

	Guid BaseObjectUid { get; }

	List<Guid> ObjectUidList { get; }

	List<Guid> DefaultObjectsUidsList { get; }

	IUser DefaultHarmonizator(IEntity entity);

	WorkTime? PlanWorkLog(IEntity entity);
}
