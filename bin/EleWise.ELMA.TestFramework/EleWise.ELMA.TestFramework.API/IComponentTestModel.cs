using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.TestFramework.API;

public interface IComponentTestModel<TContext, TController> where TContext : IContext where TController : IController
{
	TContext Context { get; }

	TController Controller { get; }
}
public interface IComponentTestModel<TController>
{
	IContext Context { get; }

	TController Controller { get; }
}
