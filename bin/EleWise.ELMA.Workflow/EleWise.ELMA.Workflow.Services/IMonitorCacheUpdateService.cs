using System;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IMonitorCacheUpdateService
{
	void InvokeAction(IProcessHeader header, Guid action);

	void InvokeAction(IProcessHeader header, Guid action, IUser user);
}
