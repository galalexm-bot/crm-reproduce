using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.TestFramework.API;

public class BaseReactComponentTestModel<TContext, TController, TInputs> : IBaseReactComponentTestModel<TContext, TController, TInputs> where TContext : IContext where TController : IController where TInputs : IInputs
{
	private TContext _003CContext_003Ek__BackingField;

	private TController _003CController_003Ek__BackingField;

	private TInputs _003CInputs_003Ek__BackingField;

	public TContext Context
	{
		get
		{
			return _003CContext_003Ek__BackingField;
		}
		private set
		{
			_003CContext_003Ek__BackingField = value;
		}
	}

	public TController Controller
	{
		get
		{
			return _003CController_003Ek__BackingField;
		}
		private set
		{
			_003CController_003Ek__BackingField = value;
		}
	}

	public TInputs Inputs
	{
		get
		{
			return _003CInputs_003Ek__BackingField;
		}
		private set
		{
			_003CInputs_003Ek__BackingField = value;
		}
	}

	public BaseReactComponentTestModel(IContext context, IController controller, IInputs inputs)
	{
		Context = (TContext)context;
		Controller = (TController)controller;
		Inputs = (TInputs)inputs;
	}
}
