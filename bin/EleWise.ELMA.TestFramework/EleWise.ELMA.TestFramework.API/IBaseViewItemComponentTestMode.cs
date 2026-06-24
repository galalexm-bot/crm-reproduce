using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.TestFramework.API;

public interface IBaseViewItemComponentTestModel<TViewItem, TInputs, TContext, TController> where TViewItem : IViewItem where TInputs : IInputs where TContext : IContext where TController : IController
{
	TViewItem ViewItem { get; }

	TContext Context { get; }

	TController Controller { get; }

	TInputs Inputs { get; }
}
