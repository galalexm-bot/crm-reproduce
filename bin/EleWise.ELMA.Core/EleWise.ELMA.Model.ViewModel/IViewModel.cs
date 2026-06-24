using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Dispatcher;

namespace EleWise.ELMA.Model.ViewModel;

public interface IViewModel
{
	bool Ready { get; }

	IInputModel InputModel { get; }

	IViewModel RenderOwner { get; }

	IContext Context { get; }

	IComponentContainer Component { get; }

	IComponentDispatcher ComponentDispatcher { get; }

	IController Controller { get; }

	void SetDynamicData(DataStackItem dataItem);

	void RestoreDynamicData(DataStackItem dataItem);

	IDataStack GetDynamicData();
}
public interface IViewModel<TContext, TController> : IViewModel where TContext : IContext where TController : IController
{
	new TContext Context { get; }

	new TController Controller { get; }
}
