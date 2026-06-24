using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.TestFramework.API;

public interface IBaseReactComponentTestModel<TContext, TController, TInputs> where TContext : IContext where TController : IController where TInputs : IInputs
{
	TContext Context { get; }

	TController Controller { get; }

	TInputs Inputs { get; }
}
