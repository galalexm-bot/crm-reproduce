using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.Controllers;

public abstract class BaseCustomController<TServerController, TType, TSettings, TContext> : BaseController<TContext, TServerController> where TServerController : IServerController where TContext : IContext
{
	private readonly ICustomTypeContainer<TType, TSettings> _003CComponent_003Ek__BackingField;

	public new ICustomTypeContainer<TType, TSettings> Component => _003CComponent_003Ek__BackingField;
}
public abstract class BaseCustomController<TServerController, TContext> : BaseController<TContext, TServerController> where TServerController : IServerController where TContext : IContext
{
	private readonly ICustomTypeContainer _003CComponent_003Ek__BackingField;

	public new ICustomTypeContainer Component => _003CComponent_003Ek__BackingField;
}
public abstract class BaseCustomController<TServerController> : BaseController<TServerController> where TServerController : IServerController
{
	public new ICustomTypeContainer Component => (ICustomTypeContainer)base.Component;
}
