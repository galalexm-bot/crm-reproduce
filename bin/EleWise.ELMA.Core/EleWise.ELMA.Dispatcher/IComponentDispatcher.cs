using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Controllers;

namespace EleWise.ELMA.Dispatcher;

public interface IComponentDispatcher
{
	System.Threading.Tasks.Task DispatchAction(string actionTypeProviderId, string actionId, params object[] args);

	void Dispatch(Action method);

	System.Threading.Tasks.Task Dispatch(Func<System.Threading.Tasks.Task> method);
}
public interface IComponentDispatcher<TController> : IComponentDispatcher where TController : IController
{
	void Dispatch(Action<TController> method);

	System.Threading.Tasks.Task Dispatch(Func<TController, System.Threading.Tasks.Task> method);
}
