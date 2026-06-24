using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IMonitorUpdateQueueAction
{
	Guid ActionUid { get; }

	string ActionName { get; }

	void DoAction(IProcessHeader header, IUser user);
}
