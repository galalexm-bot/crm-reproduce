using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.TestFramework.API;

public class ComponentTestModel<TContext, TController> : IComponentTestModel<TContext, TController> where TContext : IContext where TController : IController
{
	private TContext _003CContext_003Ek__BackingField;

	private TController _003CController_003Ek__BackingField;

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

	public ComponentTestModel(IContext context, IController controller)
	{
		Context = (TContext)context;
		Controller = (TController)controller;
	}
}
public class ComponentTestModel<TController> : IComponentTestModel<TController> where TController : IController
{
	private IContext _003CContext_003Ek__BackingField;

	private TController _003CController_003Ek__BackingField;

	public IContext Context
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

	public ComponentTestModel(IContext context, IController controller)
	{
		Context = context;
		Controller = (TController)controller;
	}
}
