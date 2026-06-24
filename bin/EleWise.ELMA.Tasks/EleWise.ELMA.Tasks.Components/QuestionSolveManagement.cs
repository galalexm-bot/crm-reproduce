using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class QuestionSolveManagement : ISolveTaskManagement
{
	public IEnumerable<Guid> TypeUid
	{
		get
		{
			yield return InterfaceActivator.UID<IQuestion>();
		}
	}

	public long GetCurrentControlCount(IUser user, bool debugMode)
	{
		return 0L;
	}

	public long GetExecutionControlCount(IUser user, bool debugMode)
	{
		return 0L;
	}
}
