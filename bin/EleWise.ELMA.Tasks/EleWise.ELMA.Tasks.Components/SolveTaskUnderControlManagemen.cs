using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class SolveTaskUnderControlManagement : ISolveTaskUnderControlManagement
{
	public IEnumerable<Guid> TypeUid
	{
		get
		{
			yield return InterfaceActivator.UID<ITask>();
		}
	}
}
